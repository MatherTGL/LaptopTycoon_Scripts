using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FunctionPanelButton : MonoBehaviour
{
    [Header("Доступ к скрипту по туториалу")]
    [SerializeField] private Tutorial _tutorial;
    [SerializeField] private MainGameMechanics _mainGameMechanics;
    private UpgradeTreeData upgradeTreeData;
    [SerializeField] private CreateLaptop _createLaptop;
    [SerializeField] private MyOSPanel _myOS;
    [SerializeField] private CompanyNameInputField _companyName;
    private UpgradeTree _upgradeTree;
    [SerializeField] private SettingGame _settingGame;
    [SerializeField] private OpenOS _openOS;
    private Staff _staff;
    [SerializeField] private OfficeUpgrade _officeUpgrade;
    [SerializeField] private SSDUpgrade _ssdUpgrade;
    [SerializeField] private dlcAnimationManager _dlcAnimationManager;
    [SerializeField] private GameData _gameData;
    private Quest _quest;
    [SerializeField] private settingMenuManagerAnim _settingMenuManagerAnim;
    [SerializeField] private menuAnimationManager _menuAnimationManager;

    [Header("Панели")]
    [Header("Главная панель (Меню)")]
    public GameObject MainPanel;

    [Header("Панель в меню")]
    public GameObject _MenuPanelButtons;

    [Header("Кнопка старта игры в меню")]
    public GameObject ButtonStartMenu;

    [Header("Кнопка настроек игры в меню")]
    public GameObject ButtonSettingMenu;

    [Header("Кнопка выхода из игры в меню")]
    public GameObject ButtonQuitMenu;

    [Header("Панель настроек")]
    public GameObject _SettingPanel;

    [Header("Панель улучшений")]
    public GameObject _UpgradePanel;
    [SerializeField] private GameObject _upgradeScrollbar;

    [Header("Панель паузы")]
    [SerializeField] private GameObject _PausePanel;

    [Header("Панель новостей")]
    [SerializeField] private GameObject _NewsPanel;

    [Header("Панель заданий")]
    [SerializeField] private GameObject _QuestPanel;

    [Header("Панель с вводом названия компании")]
    public GameObject _NameCompanyPanel;

    [Header("Панель покупки компаний")]
    [SerializeField] private GameObject _BuyCopmanyPanel;
    [SerializeField] private GameObject _buyCompanyScrollbar;

    [Header("Оснавная игровая панель")]
    public GameObject _MenuPanel;

    [Header("Панель информации об игре")]
    [SerializeField] private GameObject _InformationPanel;

    [Header("Панель маркетинга")]
    [SerializeField] private GameObject _markertingPanel;

    [Header("Туториал")]
    [Header("Панель выбора прохождения туториала или нет")]
    public GameObject _TutorialPanel;

    [Header("Точно ли игрок хочет выйти из игры")]
    [SerializeField] private GameObject _quitTheGamePanel; //Панель точно ли игрок хочет выйти из игры

    [Header("Панель создания ноутбука")]
    public GameObject CreateLaptopPanel;

    [Header("Скролл в панели маркетинга")]
    public GameObject ScrollPanelMarketing;
    [Header("Кнопка выхода маркетинг")]
    public GameObject quitMarketingButton;

    [Header("Текста для оформления")]
    public GameObject textLaptopTycoon;

    [Header("Панель найма рабочих")]
    public GameObject _StaffPanel;
    [SerializeField] private GameObject _staffScrollbar;
    


    [Header("Офисы")]

    [Header("Пустышка со всеми оффисами")]
    public GameObject _allOffices;

    [Header("Первый офис в игре")]
    public GameObject _FirstOffice; //Самый начальный офис

    [Header("Второй офис в игре")]
    public GameObject _SecondOffice; //Второй офис в игре

    [Header("Третий офис в игре")]
    public GameObject _ThirdOffice; //Третий офис в игре

    [Header("Четвертый офис в игре")]
    public GameObject _FourthOffice;

    [Header("Пятый офис в игре")]
    public GameObject _FifthOffice;



    [HideInInspector]
    [Header("Булевая панели ввода имени компании")]
    [SerializeField] private bool _ActiveNameCompanyPanelBool = true;
    [HideInInspector]
    [SerializeField] private bool _ActiveTutorialPanel = true;

    [Header("Панель MyOS")]
    public GameObject _MyOSPanelGO; //Панель My OS

    [Header("Активировать ли панель туториала")]
    [HideInInspector]
    [SerializeField] private byte _activeTutorialPanelStart;

    [Header("Удалять ли сохранения панель")]
    [SerializeField] private GameObject _deleteSavePanel;

    [Header("Панель подтверждения")]
    public GameObject _confirmPanel;

    public GameObject topCompanyPanel;

    public GameObject dlsCompanyPlayerPanel;
    public byte checkActiveDLC;

    [SerializeField] private Button _createLaptopPanelButton;
    [SerializeField] private GameObject _confirmExitCreatePanel;
    [SerializeField] private GameObject _helperConfirmExitObject;

    [SerializeField] private Animation animationSettingsIconMenu;

    public GameObject scrollMenuPanel;

    private void Awake()
    {
        _allOffices.SetActive(true);
        MainPanel.SetActive(false);
        ButtonStartMenu.SetActive(false);
        ButtonSettingMenu.SetActive(false);
        ButtonQuitMenu.SetActive(false);
        textLaptopTycoon.SetActive(false);
        _UpgradePanel.SetActive(false);
        _PausePanel.SetActive(false);
        _NewsPanel.SetActive(false);
        _QuestPanel.SetActive(false);
        _BuyCopmanyPanel.SetActive(false);
        _InformationPanel.SetActive(false);
        CreateLaptopPanel.SetActive(false);
        _MenuPanel.SetActive(false);
        _quitTheGamePanel.SetActive(false);        
        _TutorialPanel.SetActive(false);
        _NameCompanyPanel.SetActive(false);
        _markertingPanel.SetActive(false);
        _SettingPanel.SetActive(false);
        ScrollPanelMarketing.SetActive(true);
        _MenuPanelButtons.SetActive(true);
        _StaffPanel.SetActive(false);
        _MyOSPanelGO.SetActive(false);
        _deleteSavePanel.SetActive(false);
        _confirmPanel.SetActive(false);
        _createLaptop.checkPanelActiveCL = false;
        topCompanyPanel.SetActive(false);
        dlsCompanyPlayerPanel.SetActive(false);
        _confirmExitCreatePanel.SetActive(false);
        scrollMenuPanel.SetActive(false);
        PlayerPrefs.GetInt("TutorialPanel");
    }

    private void Start()
    {
        Time.timeScale = 1;
        Application.targetFrameRate = 60;
        if (MainPanel.activeSelf) { _MenuPanel.SetActive(false); _FirstOffice.SetActive(false); }
    }

    private void Update()
    {
        if (_TutorialPanel.activeInHierarchy)
        {
            ButtonStartMenu.SetActive(false);
            ButtonSettingMenu.SetActive(false);
            ButtonQuitMenu.SetActive(false);
            textLaptopTycoon.SetActive(false);
        }
    }

    public void OpenMyOSButton() //Метод, который открывает панель My OS
    {
        if (_openOS._activeOSUpgrade == 1)
        {
            _MyOSPanelGO.SetActive(true);
            _MenuPanel.SetActive(false);
            _allOffices.SetActive(false);
            scrollMenuPanel.SetActive(false);
        }      
    }

    public void CloseMyOSButton() //Метод, который закрывает панель My OS
    {        
        _MyOSPanelGO.SetActive(false);
        _MenuPanel.SetActive(true);
        _allOffices.SetActive(true);
        scrollMenuPanel.SetActive(false);
    }

    public void OpenTopCompanyButton()
    {
        topCompanyPanel.SetActive(true);
        _MenuPanel.SetActive(false);
        _allOffices.SetActive(false);
        scrollMenuPanel.SetActive(false);
    }

    public void CloseTopCompanyButton()
    {
        topCompanyPanel.SetActive(false);
        _MenuPanel.SetActive(true);
        _allOffices.SetActive(true);
        scrollMenuPanel.SetActive(false);
    }

    public void openScrollMenuButton()
    {
        StartCoroutine(checkMenuScrollActive());
    }

    IEnumerator checkMenuScrollActive()
    {
        while (true)
        {
            if (!scrollMenuPanel.activeSelf)
            {
                scrollMenuPanel.SetActive(true);
                _menuAnimationManager.animatorMenuScrollPanel.SetBool("checkActive", false);
                _menuAnimationManager.animatorMenuScrollPanel.SetBool("checkQuit", false);
                yield break;
            }
            else
            {
                _menuAnimationManager.animatorMenuScrollPanel.SetBool("checkActive", true);
                _menuAnimationManager.animatorMenuScrollPanel.SetBool("checkQuit", true);
                _createLaptop._imageScrollMenuUp.enabled = true;
                _createLaptop._imageScrollMenuDown.enabled = false;
                yield return new WaitForSeconds(0.4f);
                scrollMenuPanel.SetActive(false);
                yield break;
            }
        }
    }

    public void openDLCCompanyButton() { StartCoroutine(checkDLCActive()); }

    IEnumerator checkDLCActive()
    {
        while(true)
        {
            if (!dlsCompanyPlayerPanel.activeSelf)
            {
                dlsCompanyPlayerPanel.SetActive(true);
                _dlcAnimationManager.animatorDLCPanel.SetBool("isOpenDLC", false);
                _dlcAnimationManager.animatorDLCPanel.SetBool("isCloseDLC", false);
                yield break;
            }
            else
            {
                _dlcAnimationManager.animatorDLCPanel.SetBool("isOpenDLC", true);
                _dlcAnimationManager.animatorDLCPanel.SetBool("isCloseDLC", false);
                yield return new WaitForSeconds(1);
                dlsCompanyPlayerPanel.SetActive(false);
                yield break;
            }
        }
    }

    public void BuyCompanyButton()
    {
        _BuyCopmanyPanel.SetActive(true);
        _MenuPanel.SetActive(false);
        _allOffices.SetActive(false);
        _buyCompanyScrollbar.SetActive(true);
        scrollMenuPanel.SetActive(false);
    }

    public void BackBuyCompanyPanel()
    {
        _BuyCopmanyPanel.SetActive(false);
        _MenuPanel.SetActive(true);
        _allOffices.SetActive(true);
        _buyCompanyScrollbar.SetActive(false);
        scrollMenuPanel.SetActive(false);
    }

    public void BackCreateLaptopButton()
    {
        _confirmExitCreatePanel.SetActive(true);
        _helperConfirmExitObject.SetActive(false);
        scrollMenuPanel.SetActive(false);
    }

    public void confirmExitCreatePanelButton()
    {
        CreateLaptopPanel.SetActive(false);
        _createLaptop.keyboardPanelCreateLaptop.SetActive(false);
        _createLaptop.DisplayPanelCreateLaptop.SetActive(false);
        _createLaptop.costPanelCreateLaptop.SetActive(false);
        _createLaptop.makeLaptopPanel.SetActive(false);
        _allOffices.SetActive(true);
        _MenuPanel.SetActive(true);
        _createLaptop.checkPanelActiveCL = false;
        _confirmExitCreatePanel.SetActive(false);
        _helperConfirmExitObject.SetActive(true);
        scrollMenuPanel.SetActive(false);
    }

    public void dontConfirmExitCreatePanelButton()
    {
        _confirmExitCreatePanel.SetActive(false);
        _helperConfirmExitObject.SetActive(true);
        scrollMenuPanel.SetActive(false);
    }

    public void TutorialActiveInGame() //Активировать ли туториал в игре
    {
        _activeTutorialPanelStart = 1;
        PlayerPrefs.SetInt("TutorialPanel", _activeTutorialPanelStart);
        _NameCompanyPanel.SetActive(true);
        _tutorial.activeTutorial = true;
        _allOffices.SetActive(false);
        if (PlayerPrefs.HasKey("NameCompany"))
        {
            _MenuPanel.SetActive(true);
            MainPanel.SetActive(false);
            _allOffices.SetActive(true);
            _NameCompanyPanel.SetActive(false);
        }
        else { _NameCompanyPanel.SetActive(true); _TutorialPanel.SetActive(false); }
        _ActiveTutorialPanel = false;
    }

    public void TutorialNotActiveInGame() //Активировать ли туториал в игре
    {
        _activeTutorialPanelStart = 1;
        PlayerPrefs.SetInt("TutorialPanel", _activeTutorialPanelStart);
        if (PlayerPrefs.HasKey("NameCompany"))
        {
            _MenuPanel.SetActive(true);
            MainPanel.SetActive(false);
            _allOffices.SetActive(true);
            _NameCompanyPanel.SetActive(false);
        }
        else { _NameCompanyPanel.SetActive(true); }
       
        _TutorialPanel.SetActive(false);
        _ActiveTutorialPanel = false;
    }
    public void StartButtonGO()
    {
        _MenuPanel.SetActive(true);
        MainPanel.SetActive(false);
        _allOffices.SetActive(true);
        switch (_officeUpgrade.levelOffice)
        {
            case 1:
                _FirstOffice.SetActive(true);
                break;
            case 2:
                _SecondOffice.SetActive(true);
                break;
            case 3:
                _ThirdOffice.SetActive(true);
                break;
            case 4:
                _FourthOffice.SetActive(true);
                break;
            case 5:
                _FifthOffice.SetActive(true);
                break;
        }

        if (_mainGameMechanics.Money <= 0) _mainGameMechanics.Money = 1000000000;
        PlayerPrefs.SetString("NameCompany", _companyName.NameCompany);     
        if (_tutorial.activeTutorial == true) _TutorialPanel.SetActive(true);
    }

    //Удаление сохранений
    public void DeleteSaveButtonOpenPanel()
    {
        _deleteSavePanel.SetActive(true);
        _SettingPanel.SetActive(false);
        textLaptopTycoon.SetActive(false);
        _MenuPanelButtons.SetActive(false);
    }
    public void DeleteSaveButtonYes()
    {
        PlayerPrefs.DeleteAll();
        _deleteSavePanel.SetActive(false);
        _SettingPanel.SetActive(false);
        textLaptopTycoon.SetActive(true);
        _MenuPanelButtons.SetActive(true);
    }
    public void DeleteSaveButtonNo()
    {
        _deleteSavePanel.SetActive(false);
        _SettingPanel.SetActive(false);
        textLaptopTycoon.SetActive(true);
        _MenuPanelButtons.SetActive(true);
    }

    public void StartButton()
    {
      
        if (_mainGameMechanics.Money < 0) { _mainGameMechanics.Money = 1000000000; }
            
        if (PlayerPrefs.HasKey("TutorialPanel"))
        {
            _MenuPanel.SetActive(true);
            MainPanel.SetActive(false);
            _allOffices.SetActive(true);
            Time.timeScale = 1;
            if (!PlayerPrefs.HasKey("MoneyPlayer")) _mainGameMechanics.Money = 1000000000;
        }
        else _TutorialPanel.SetActive(true);
        switch (_officeUpgrade.levelOffice)
        {
            case 1:
                _FirstOffice.SetActive(true);
                break;
            case 2:
                _SecondOffice.SetActive(true);
                break;
            case 3:
                _ThirdOffice.SetActive(true);
                break;
            case 4:
                _FourthOffice.SetActive(true);
                break;
            case 5:
                _FifthOffice.SetActive(true);
                break;
        }
        _MenuPanelButtons.SetActive(false);
        textLaptopTycoon.SetActive(false);
        _SettingPanel.SetActive(false);
        scrollMenuPanel.SetActive(false);
    }

    public void SettingButton() { StartCoroutine(checkSettingAnim()); animationSettingsIconMenu.Play(); }

    IEnumerator checkSettingAnim()
    {
        while (true)
        {
            if (!_SettingPanel.activeSelf)
            {
                _SettingPanel.SetActive(true);
                _settingMenuManagerAnim._settingAnimator.SetBool("deactiveSettings", false);
                _settingMenuManagerAnim._settingAnimator.SetBool("isCloseSettings", false);
                yield break;
            }
            else
            {
                _settingMenuManagerAnim._settingAnimator.SetBool("deactiveSettings", true);
                _settingMenuManagerAnim._settingAnimator.SetBool("isCloseSettings", false);
                yield return new WaitForSeconds(1);
                _SettingPanel.SetActive(false);
                yield break;
            }
        }
    }

    public void QuitButton()
    {
        MainPanel.SetActive(true);
        _MenuPanel.SetActive(false);
        _NameCompanyPanel.SetActive(false);
        _MenuPanelButtons.SetActive(true);
        ButtonStartMenu.SetActive(true);
        ButtonSettingMenu.SetActive(true);
        ButtonQuitMenu.SetActive(true);
        textLaptopTycoon.SetActive(true);
        _PausePanel.SetActive(false);
        Time.timeScale = 1;
    }

    public void StaffButton()
    {
        _StaffPanel.SetActive(true);
        _MenuPanel.SetActive(false);
        _staffScrollbar.SetActive(true);
        scrollMenuPanel.SetActive(false);
    }
    public void QuitStaffPanelButton()
    {
        _StaffPanel.SetActive(false);
        _MenuPanel.SetActive(true);
        _staffScrollbar.SetActive(false);
        scrollMenuPanel.SetActive(false);
    }

    public void QuestButton()
    {
        _QuestPanel.SetActive(true);
        _allOffices.SetActive(false);
        scrollMenuPanel.SetActive(false);
    }

    public void PauseButton()
    {
        _PausePanel.SetActive(!_PausePanel.activeSelf);
        scrollMenuPanel.SetActive(false);
        _createLaptop._imageScrollMenuUp.enabled = false;
        _createLaptop._imageScrollMenuDown.enabled = false;
        if (_PausePanel.activeSelf) { Time.timeScale = 0; _settingGame.ActiveSound.isOn = false; }
        else { Time.timeScale = 1; _settingGame.ActiveSound.isOn = true; }
    }
  
    
    public void BackMenuQuest()
    {
        _QuestPanel.SetActive(false);
        Time.timeScale = 1;
        _MenuPanel.SetActive(true);
        _allOffices.SetActive(true);
        scrollMenuPanel.SetActive(false);
    }
    public void InformationButton()
    {
        Time.timeScale = 0;
        _InformationPanel.SetActive(true);
        _MenuPanel.SetActive(false);
        _allOffices.SetActive(false);
        scrollMenuPanel.SetActive(false);
    }
    public void BackMenuInformationPanel() //Вернуться обратно в меню из панели информации
    {
        _InformationPanel.SetActive(false);
        _MenuPanel.SetActive(true);
        _allOffices.SetActive(true);
        scrollMenuPanel.SetActive(false);
        Time.timeScale = 1;
    }
    public void UpgradeButton()
    {
        _UpgradePanel.SetActive(true);
        _MenuPanel.SetActive(false);
        _allOffices.SetActive(false);
        _upgradeScrollbar.SetActive(true);
        scrollMenuPanel.SetActive(false);
    }
    public void BackMenuUpgradePanel()
    {
        _UpgradePanel.SetActive(false);
        _MenuPanel.SetActive(true);
        _allOffices.SetActive(true);
        _upgradeScrollbar.SetActive(false);
    }

    public void QuitTheGameButtonMethod() //Ну и сама кнопка выхода Quit
    {
        _quitTheGamePanel.SetActive(true);
        _SettingPanel.SetActive(false);
        ButtonStartMenu.SetActive(false);
        ButtonSettingMenu.SetActive(false);
        ButtonQuitMenu.SetActive(false);
        textLaptopTycoon.SetActive(false);        
        _allOffices.SetActive(false);
        _MenuPanelButtons.SetActive(false);
    }

    public void QuitTheGameButton() { Application.Quit(); } //Кнопка выхода из игры (Да, я точно хочу выйти)

    public void NoQuitTheGameButton() //Кнопка не выхода из игры (Нет, я передумал выходить)
    {
        _quitTheGamePanel.SetActive(false);
        ButtonStartMenu.SetActive(true);
        ButtonSettingMenu.SetActive(true);
        ButtonQuitMenu.SetActive(true);
        _MenuPanelButtons.SetActive(true);
        textLaptopTycoon.SetActive(true);
        _MenuPanelButtons.SetActive(true);
    }

    public void MarketingButton()
    {
        _markertingPanel.SetActive(true);
        _MenuPanel.SetActive(false);
        _allOffices.SetActive(false);
        _confirmPanel.SetActive(false);
        scrollMenuPanel.SetActive(false);
    }

    public void QuitMarketingPanelButton()
    {
        _markertingPanel.SetActive(false);      
        _MenuPanel.SetActive(true);
        _allOffices.SetActive(true);
        scrollMenuPanel.SetActive(false);
    }  

    public void GameoverButton()
    {
        _mainGameMechanics.Money = 1000000000;
        PlayerPrefs.DeleteAll();
        _mainGameMechanics._gameoverPanel.SetActive(false);
        MainPanel.SetActive(true);
        _MenuPanel.SetActive(false);
        _MenuPanelButtons.SetActive(true);
        textLaptopTycoon.SetActive(true);
        ButtonQuitMenu.SetActive(true);
        ButtonSettingMenu.SetActive(true);
        ButtonStartMenu.SetActive(true);
        _gameData.Day = 10;
        _gameData.Month = 1;
        _gameData.Year = 2019;
        _mainGameMechanics.RecearchPoint = 20;
        _mainGameMechanics.Fun = 16;
        scrollMenuPanel.SetActive(false);
        SceneManager.LoadScene(0);
    }

    public void continueGameoverAdButton()
    {
        _mainGameMechanics.Money = 2000000000;
        _mainGameMechanics._gameoverPanel.SetActive(false);
        _MenuPanel.SetActive(true);
        scrollMenuPanel.SetActive(false);
    }
}
