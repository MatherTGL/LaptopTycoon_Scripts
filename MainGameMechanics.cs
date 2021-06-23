using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainGameMechanics : MonoBehaviour
{
    [Header("Доступ к скрипту с панелями")]
    [SerializeField] private FunctionPanelButton _functionPanelButton;
    [SerializeField] private CompanyNameInputField _companyNameInputField;
    [SerializeField] private SettingGame _settingGame;
    private Quest _quest;
    [SerializeField] private BuyCompany _buyCopmpany;
    private Staff _staff;
    private UpgradeTreeData _upgradeTreeData;
    [SerializeField] private CreateLaptop _createLaptop;
    [SerializeField] private GameData _gameData;
    [SerializeField] private RatingCreate _ratingCreate;
    [SerializeField] private Crisis _crisis;
    

    [Header("Доступ к пост процессингу")]
    [SerializeField] private GameObject _camera;
    
    [Header("Деньги игрока")]
    public double Money; //Переменная денег игрока
    [SerializeField] private Text _TextMoney; //Переменная текста для вывода на экран переменной денег

    [Header("Фанаты игрока")]
    public double Fun; //Переменная фанатов игрока
    public double currenFunsMarketingBuy;
    public byte validMarketingBuy;
    [SerializeField] private Text _TextFun;

    [Header("Очки исследования")]
    public ushort RecearchPoint; //Переменная очков исследования
    [SerializeField] private Text _TextRecearchPoint; //Переменная текста для вывода на экран переменной очков исследования
    [SerializeField] private Text _TextRecearchPointTwo;

    [Header("Название компании")]
    public Text _TextNameCompany; //Переменная текста для вывода переменной string (_NameCompany)

    [Header("Формат")]
    public string NumberFormate; //Используемый формат для многих переменных (типо $100 000 000)
    [HideInInspector]
    [SerializeField] private string _DollarRateFormate; //Формат для переменной курса доллара
    
    //Random Number    
    [Header("Random Setting Money")]
    [Tooltip("сколько минимально денег вычитается каждый игровой день")]
    public int MinMoneyRandom; //Сколько будет минимально вычитаться денег в рандоме каждый игровой день
    [Tooltip("сколько максимально денег вычитается каждый игровой день")]
    public int MaxMoneyRandom; //Сколько будет минимально вычитаться денег в рандоме каждый игровой день


    [Header("Совокупный доход")]
    public double _IncomeCumulative;
    public Text _TextIncomeCumulative;

    [Header("Расходы на компанию")]
    public double _ExpenditureCumulative;
    public Text _TextExpenditureCumulative;

    [Header("Сколько компаний в собственности")]
    public byte MyCompanys;

    [Header("Сколько сотрудников у игрока")]
    public byte staffsPlayer;
    public Text textStaffsPlayer;
    public byte maxStaffsPlayer;

    [Header("Затраты на сотрудников")]
    public double ExpenditureStaff;
    public Text _TextExpenditureStaff;

    [Header("Game over")]
    public GameObject _gameoverPanel;

    [Header("Себестоимость ноутбука")]
    public int fullCostLaptop;
    public Text textCostOption;
    public bool boolDisplay;
    [Header("Картинки для ноута")]
    public Image[] imageDisplay;
    public Image[] greenCyrcleButton;
    [Header("Стоимость ноутбука на рынке")]
    public int retailPrice;
    [Header("Сбор стоимости по отдельности")]
    public ushort FullZeroCostLaptop; //FullCost + Display + keyboard

    [Header("quest")]
    [SerializeField] private GameObject[] _questObjects;

    private void Awake()
    {
        if (_crisis.ActiveCrisis != true) { MinMoneyRandom = 500000; MaxMoneyRandom = 700000; }
        else { MinMoneyRandom = 1650000; MaxMoneyRandom = 2300000; }
       
        fullCostLaptop = 365;
        FullZeroCostLaptop = 365;
        textCostOption.text = "$ " + FullZeroCostLaptop;

        if (!PlayerPrefs.HasKey("MoneyPlayer")) Money = 1000000000;
        TextMoneyFormate();

        if (!PlayerPrefs.HasKey("FunPlayer")) Fun = 16;
        TextFunFormate();

        if (PlayerPrefs.HasKey("RecearchPointPlayer")) RecearchPoint = (ushort)PlayerPrefs.GetInt("RecearchPointPlayer");
        else RecearchPoint = 20;

        _TextNameCompany.text = _companyNameInputField.NameCompany + " Company";

        Application.targetFrameRate = 60;
    }

    void Start()
    {
        StartCoroutine(MinesMoneyCoroutine());
        StartCoroutine(CheckMoneyPlayer());
        StartCoroutine(_checkEverySecond());

        if (!PlayerPrefs.HasKey("ExpenditureStaff")) ExpenditureStaff = 0;
        _gameoverPanel.SetActive(false);              
        ToggleActiveSoundGame();
        _settingGame.ActiveCheats.isOn = false;
        _camera.GetComponent<AudioSource>().enabled = true;
        StartCoroutine(PlusMoneyIncome());

        //Name company
        NameCompanyString();

        TextRecearchPointFormate();
    }

    void Update()
    {
        textCostOption.text = "$ " + FullZeroCostLaptop;
        _TextNameCompany.text = _companyNameInputField.NameCompany + " Company";

        ToggleActiveSoundGame();
        //Money
        TextMoneyFormate();
        //Recearch point
        TextRecearchPointFormate();
        //Fun
        TextFunFormate();
    }

    void ToggleActiveSoundGame()
    {
        if (_settingGame.ActiveSound.isOn == false)
        {
            _camera.GetComponent<AudioSource>().enabled = false;
            _settingGame.AudioSourceObject.GetComponent<AudioSource>().enabled = false;
        }
        else
        {
            _camera.GetComponent<AudioSource>().enabled = true;
            _settingGame.AudioSourceObject.GetComponent<AudioSource>().enabled = true;
        }
    } 
    void TextMoneyFormate() 
    {
        _TextMoney.text = "$" + Money.ToString("### ### ### ### ### ###");
        if (Money <= 0) { if (!_functionPanelButton.MainPanel.activeSelf) { _gameoverPanel.SetActive(true); } }
    }
    void TextFunFormate() { _TextFun.text = Fun.ToString("### ### ### ### ### ###"); }
    public void TextRecearchPointFormate()
    {
        _TextRecearchPoint.text = RecearchPoint.ToString(NumberFormate);
        _TextRecearchPointTwo.text = RecearchPoint.ToString(NumberFormate);

        if (RecearchPoint <= 0) { _TextRecearchPoint.text = "0"; _TextRecearchPointTwo.text = "0"; }
        else _TextRecearchPoint.text = RecearchPoint.ToString(NumberFormate);      
    }
    void NameCompanyString() { _TextNameCompany.text = _companyNameInputField.NameCompany + " Company"; }

    private IEnumerator _checkEverySecond()
    {
        while(true)
        {           
            if (staffsPlayer >= 1) textStaffsPlayer.text = staffsPlayer.ToString(NumberFormate) + " / " + _upgradeTreeData.OfficeStafs;
            else textStaffsPlayer.text = "0" + " / " + _upgradeTreeData.OfficeStafs;
            yield return new WaitForSeconds(1);
        }
    }
    public IEnumerator MinesMoneyCoroutine()
    {
        while(true)
        {
            //Рандом сколько будет вычитаться денег каждый игровой день   
            if (!_functionPanelButton.MainPanel.activeSelf) { Money -= UnityEngine.Random.Range(MinMoneyRandom, MaxMoneyRandom); }
            if (Money >= 999999999999999) Money = 999999999999999;  
            yield return new WaitForSeconds(1);
        }
    }    
    public IEnumerator CheckMoneyPlayer()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            if (_gameoverPanel.activeSelf) { _functionPanelButton._NameCompanyPanel.SetActive(false); yield break; }
            else yield return new WaitForSeconds(1);     
        }
    }
    public IEnumerator PlusMoneyIncome()
    {
        while(true) { Money += _IncomeCumulative; Money -= _ExpenditureCumulative; yield return new WaitForSeconds(175); }
    }
}
