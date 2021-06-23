using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class BuyCompany : MonoBehaviour
{
    [SerializeField] private MainGameMechanics _mainGameMechanics;
    [SerializeField] private UpgradeTreeData _upgradeTreeData;
    [SerializeField] private RealtorUpgrade _realtorUpgrade;
    [SerializeField] private Quest _quest;
    [SerializeField] private LocalizationManager _localizationManager;
   
    [Header("Стоимость компании")]
    [SerializeField] private double _CostCompany = 0;
    [Header("Вывод стоимости в текст")]
    [SerializeField] private Text _TextCostCompany;
    [Header("Доходность компании")]
    public double IncomeBuyCompany;
    [Header("Расходы на компанию")]
    public double ExpenditureCompany;
    [SerializeField] private Text _TextExpenditureBuyCompany;
    [Header("Вывод доходности в текст")]
    [SerializeField] private Text _TextIncomeBuyCompany;    
    [SerializeField] private Text _TextOwnCompany;

    [Header("Рандомное название компании")]
    [SerializeField] private byte _nameCompanyBuy = 31;
    [Header("Текст вывода названия")]
    [SerializeField] private Text _textNameCompany;

    [SerializeField] private Text _textBuyButtonCompany;
    [SerializeField] private Color _deactiveTextBuyCompany;
    [SerializeField] private Color _activeTextBuyCompany;
    [SerializeField] private Color _purchasedTextColor;
    [SerializeField] private Color _fullCompanyColor;

    [SerializeField] private GameObject _defaultInfoButCompany;
    [SerializeField] private Text _textPurchasedBuyCompany;

    void Start()
    {
        _defaultInfoButCompany.SetActive(true);
        _textPurchasedBuyCompany.enabled = false;
        _textPurchasedBuyCompany.color = _purchasedTextColor;
    }

    void OnEnable()
    {
        RandomSettingMethod();
        _textPurchasedBuyCompany.enabled = false;
        _defaultInfoButCompany.SetActive(true);
    }

    private void Update() { helperTextOptimize(); }

    void helperTextOptimize()
    {
        if (_CostCompany > _mainGameMechanics.Money) { _textBuyButtonCompany.color = _deactiveTextBuyCompany; }
        else { _textBuyButtonCompany.color = _activeTextBuyCompany; }

        _TextCostCompany.text = "$" + _CostCompany.ToString("#,#");
        _TextIncomeBuyCompany.text = "+ " + "$" + IncomeBuyCompany.ToString("#,#") + " / 6M";
        _TextExpenditureBuyCompany.text = "- " + "$" + ExpenditureCompany.ToString("#,#") + " / 6M";
        _TextOwnCompany.text = "Owned " + _mainGameMechanics.MyCompanys.ToString() + " / 13";
        if (_mainGameMechanics.MyCompanys == _realtorUpgrade.ownCompany)
        {
            _textBuyButtonCompany.text = "FULL";
            _TextOwnCompany.color = _fullCompanyColor;
            _textBuyButtonCompany.color = _fullCompanyColor;
        }
        else { _TextOwnCompany.color = _activeTextBuyCompany; }
    }

    void checkNameCompanys()
    {
        switch (_nameCompanyBuy)
        {
            case 1:
                _textNameCompany.text = "Macresoft";
                break;
            case 2:
                _textNameCompany.text = "AZUZ";
                break;
            case 3:
                _textNameCompany.text = "Acatela";
                break;
            case 4:
                _textNameCompany.text = "Nuka";
                break;
            case 5:
                _textNameCompany.text = "AZER";
                break;
            case 6:
                _textNameCompany.text = "Samsaung";
                break;
            case 7:
                _textNameCompany.text = "Hiaomi";
                break;
            case 8:
                _textNameCompany.text = "Razor";
                break;
            case 9:
                _textNameCompany.text = "Levono";
                break;
            case 10:
                _textNameCompany.text = "Logeteg";
                break;
            case 11:
                _textNameCompany.text = "KSOS";
                break;
            case 12:
                _textNameCompany.text = "Deepda";
                break;
            case 13:
                _textNameCompany.text = "Apople";
                break;
            case 14:
                _textNameCompany.text = "Smataboy";
                break;
            case 15:
                _textNameCompany.text = "Abibas";
                break;
            case 16:
                _textNameCompany.text = "Ubeysoft";
                break;
            case 17:
                _textNameCompany.text = "Puc games";
                break;
            case 18:
                _textNameCompany.text = "Strem";
                break;
            case 19:
                _textNameCompany.text = "Intol";
                break;
            case 20:
                _textNameCompany.text = "Amude";
                break;
            case 21:
                _textNameCompany.text = "Nvidete";
                break;
            case 22:
                _textNameCompany.text = "Aeroboom";
                break;
            case 23:
                _textNameCompany.text = "TGL";
                break;
            case 24:
                _textNameCompany.text = "VELVA 3";
                break;
            case 25:
                _textNameCompany.text = "Nentenido";
                break;
            case 26:
                _textNameCompany.text = "Besedka";
                break;
            case 27:
                _textNameCompany.text = "Electro Arts";
                break;
            case 28:
                _textNameCompany.text = "Killersoft";
                break;
            case 29:
                _textNameCompany.text = "Rost Games";
                break;
            case 30:
                _textNameCompany.text = "BoomBax Games";
                break;
            case 31:
                _textNameCompany.text = "Redheart games";
                break;
        }
    }

    public void CheckBuyButton()
    {
        if (_mainGameMechanics.MyCompanys != 13)
        {
            if (_mainGameMechanics.Money >= _CostCompany)
            {
                if (_CostCompany != IncomeBuyCompany)
                {
                    if (_mainGameMechanics.MyCompanys < _realtorUpgrade.ownCompany)
                    {
                        _quest.checkQuest();
                        _mainGameMechanics.Money -= _CostCompany;
                        _mainGameMechanics._IncomeCumulative += IncomeBuyCompany;
                        _mainGameMechanics._ExpenditureCumulative += ExpenditureCompany;
                        _mainGameMechanics._TextIncomeCumulative.text = "+ $" + _mainGameMechanics._IncomeCumulative.ToString("#,#") + " / 6M";
                        _mainGameMechanics._TextExpenditureCumulative.text = "- " + "$" + _mainGameMechanics._ExpenditureCumulative.ToString("#,#") + " / 6M";
                        _CostCompany = (double)Random.Range(100000000, 9000000000);
                        IncomeBuyCompany = _CostCompany / Random.Range(3, 10);
                        ExpenditureCompany = IncomeBuyCompany / Random.Range(4, 10);
                        _mainGameMechanics.MyCompanys += 1;
                        _nameCompanyBuy = (byte)Random.Range(1, 31);
                        StartCoroutine(checkInfoBuyCompany());
                        checkNameCompanys();                       
                        PlayerPrefs.SetInt("IncomePlayer", (int)_mainGameMechanics._IncomeCumulative);
                        PlayerPrefs.SetInt("ExpenditurePlayer", (int)_mainGameMechanics._ExpenditureCumulative);
                        PlayerPrefs.SetInt("MyCompanys", _mainGameMechanics.MyCompanys);
                    }
                }
            }
        }   
    }

    IEnumerator checkInfoBuyCompany()
    {
        while(true)
        {
            _textPurchasedBuyCompany.enabled = true;
            _defaultInfoButCompany.SetActive(false);
            _textPurchasedBuyCompany.color = _purchasedTextColor;
            yield return new WaitForSeconds(1.4f);
            _textPurchasedBuyCompany.enabled = false;
            _defaultInfoButCompany.SetActive(true);
            yield break;
        }
    }

    public void RandomSettingMethod()
    {
        _CostCompany = (int)Random.Range(10000000, 900000000);
        _TextCostCompany.text = "$" + _CostCompany.ToString("#.#");
        IncomeBuyCompany = _CostCompany / Random.Range(3, 10);
        ExpenditureCompany = IncomeBuyCompany / Random.Range(4, 10);
        _nameCompanyBuy = (byte)Random.Range(1, 31);
        checkNameCompanys();
    }
}
