using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CreateLaptop : MonoBehaviour
{
    //Доступы к разным скриптам
    [SerializeField] private FunctionPanelButton _functionPanelButton;
    [SerializeField] private MainGameMechanics _mainGameMechanics;
    private UpgradeTreeData _upgradeTreeData;
    private UpgradeTree _upgradeTree;
    [SerializeField] private RatingCreate _ratingCreate;
    private RatingGenerateText _ratingGenerateText;
    private makeLaptopPercent _makeLaptopPercent;
    [SerializeField] private GameData _gameData;
    [SerializeField] private SSDUpgrade _ssdUpgrade;
    [SerializeField] private WirelessCharger _wirelessCharger;
    [SerializeField] private QuickCharge _quickCharge;
    [SerializeField] private WaterCooling _waterCooling;
    [SerializeField] private FaceIDUpgrade _faceID;
    [SerializeField] private CostSliderSettings _costSliderSettings;
    [SerializeField] private CoolingLaptopUpgrade _coolingLaptopUpgrade;
    private videocardData _videocardData;
    [SerializeField] private VideocardManager _videocardManager;
    private MemoryUpgrade _memoryUpgrade;
    [SerializeField] private ReleasePanelLaptop _releaseLaptop;
    [SerializeField] private CreatingAverageRating _creatingAverageRating;
    [SerializeField] private BuyCompany _buyCompany;
    [SerializeField] private SurprizeChest _surprizeChest;
    [SerializeField] private LocalizationManager _localizationManager;
    [SerializeField] private ddrCP _ddrCP;
    [SerializeField] private adsManagerScr _adsManager;
    [SerializeField] private ScreenSolution _screenSolution;

    public ushort scoreRatingAverage;

    //Сколько минимально/максимально прибавляется после выпуска ноутбука
    public int MinPlusMoneyCreateLaptop; //Минимально
    public int MaxPlusMoneyCreateLaptop; //Максимально

    [Header("Текст в углу Create panel")]
    public Text textCreatePanel; //Текст в углу, где написано create/display и т.д

    [Header("Название ноутбука")]
    public string NameLaptop; //Название ноутбука

    [Header("Ввод названия ноутбука")]
    [SerializeField] private InputField _inputFieldNameCompany; //Ввод названия ноутбука

    public GameObject _MainCreatePanel; //Вторая панель в панели создания ноутбука
    public GameObject _LaptopPanelCreate; //Первая панель в панели создания ноутбука
    public GameObject DisplayPanelCreateLaptop; //Панель дисплей в панели создания ноутбука
    public GameObject keyboardPanelCreateLaptop; //Панель клавы в панели создания ноутбука
    public GameObject ExteriorDesignCreateLaptop;
    public GameObject costPanelCreateLaptop; //Панель с ценой ноутбука
    public GameObject _ratingPanelCreateLaptop; //Панель с рейтингом
    public GameObject makeLaptopPanel; //панель с выбором копий
    public Image makeImageLaptopPanel;
    public GameObject videocardLaptopPanel;
    public GameObject newsLaptopPanel;
    public GameObject gamesTestLaptopPanel;

    [Header("Диагональ дисплея")]
    public int _DisplayScale; //Диагональ дисплея
    [Header("Пустышка для первого слайда")]
    [SerializeField] private GameObject _FirstSlide; //Первая панель с вводом названия ноутбука
    [Header("Рейтинг")]
    public int _Rating; //Рейтинг ноутбука
    [Header("Процент создания ноутбука")]
    public int PercentCreateLaptop; //Насколько процентов готов ноутбук
    public Text TextPercentCreateLaptop; //Вывод процентов в текст готовности ноутбука
    [Header("Кнопка создания ноутбука")]
    [SerializeField] private GameObject _ButtonCreateLaptopNextGM; //Кнопка "продолжить" после написания имени ноутбуку
    [Header("Дисплей")]
    public int _MaxDisplayScale; //Какой максимально вкаченный размер дисплея
    [Header("Сколько ноутбуков у компании")]
    public int ownLaptopCompany;

    [Header("Линейка ноутбука")]
    [SerializeField] private int _RulerLaptopClass; //Номер линейки
    [SerializeField] private string _RulerLaptopClassString; //Строчный номер линейки

    [Header("Кнопки выхода")]
    public GameObject quitCreatePanel; //Кнопка выхода из SecondPanel 
    [SerializeField] private GameObject _backCreatePanelDisplay; //Вернуться назад из панели дисплея
    [SerializeField] private GameObject _backCreatePanelCost; //Вернуться назад из панели цены
    [SerializeField] private GameObject _backCreatePanelKeyboard; //Вернуться  назад из панели клавиатуры
    [SerializeField] private GameObject _backCreatePanelExterior;

    [Header("Display")]
    [SerializeField] private GameObject _screenResolutionPanel; //Панель с выбором разрешения дисплея
    [SerializeField] private GameObject _screenCoveragePanel; //Панель с выбором материала дисплея

    [Header("Performance")]
    public GameObject ssdPanelCreate;
    public byte deactivePanelMakeLaptop = 0;

    [Header("ScreenCoverageCS.cs")]
    public byte _coverageSave; //Какое покрытие выбрал игрок

    [Header("Максимальная конфигурация")]
    [Header("Максимально памяти")]
    public ushort maxROMLaptop;
    [Header("Максимально ОЗУ")]
    public short maxRAMLaptop;
    [Header("Памяти ROM сейчас")]
    public ushort currentROMLaptop;
    [Header("Памяти RAM сейчас")]
    public short currentRAMLaptop;

    [Header("RGB toggle")]
    public Toggle RGBToggleLaptop;

    [Header("Мегапикселей у фронталки")]
    public byte MPRearCam;

    [Header("Смотрит активна ли панель сейчас")]
    public bool checkPanelActiveCL;

    [Header("Управлятор performance panel")]
    [SerializeField] private GameObject _batteryPerformancePanel;
    [SerializeField] private GameObject _coolingPerformancePanel;
    [SerializeField] private GameObject _memoryPerformancePanel;

    [SerializeField] private GameObject _cameraExteriorPanel;
    [SerializeField] private GameObject _exteriorExteriorPanel;

    [Header("Панель информации ноутбука")]
    public GameObject createInfoLaptopPanel;
    public bool checkCancelButtonInfo;
    [SerializeField] private Text _nameInfoCreateLaptop;
    [SerializeField] private Text _costInfoCreateLaptop;
    [SerializeField] private byte _percentCreateLaptopPanel;
    [SerializeField] private Text _percentInfoCreateLaptop;

    [Header("Панель релиза")]
    public GameObject _releasePanelLaptop;

    public bool checkActiveWaterCooling;

    public Color deactiveColor;
    public Color activeColor;

    [Header("Performance Buttons")]
    [SerializeField] private Image _performanceCoolingButton;
    [SerializeField] private Image _performanceMemoryButton;
    [SerializeField] private Image _performanceBatteryButton;

    [Header("Display Buttons")]
    [SerializeField] private Image _displayResolutionButton;
    [SerializeField] private Image _displayCoverageButton;

    [Header("Exterior Design")]
    [SerializeField] private Image _exteriorButton;
    [SerializeField] private Image _cameraButton;

    [SerializeField] private Slider _percentCreateSlider;
    public Image _imageScrollMenuUp;
    public Image _imageScrollMenuDown;

    void Awake()
    {
        StartCoroutine(CheckActivePanels()); //Корутина на проверку работы только одной панели, а не двух одновременно в панели display
        _FirstSlide.SetActive(true); //Первая панель с выбором названия для ноутбука

        PercentCreateLaptop = 0; //Готовность разработки ноутбука 
        TextPercentCreateLaptop.text = PercentCreateLaptop.ToString() + "%"; //Вывод готовности в % в текст
        TextPercentCreateLaptop.enabled = false; //Отключение текста 
        _ButtonCreateLaptopNextGM.SetActive(true); //Кнопка "продолжить" в первой панели Create Laptop после написания имени
        _LaptopPanelCreate.SetActive(false); //Панель с вводом названия ноутбуку
        DisplayPanelCreateLaptop.SetActive(false); //Панель с настройками для дисплея
        keyboardPanelCreateLaptop.SetActive(false); //Панель с настройками для клавиатуры
        ExteriorDesignCreateLaptop.SetActive(false);
        costPanelCreateLaptop.SetActive(false); //Панель с настройками цены
        textCreatePanel.text = "CREATE"; //Текст сверху в панели Create Laptop 
        quitCreatePanel.SetActive(true); //Кнопка выхода из панели
        _backCreatePanelDisplay.SetActive(false); //Кнопка возвращения назад из панели дисплея
        _screenResolutionPanel.SetActive(false); //Панель с выбором разрешения выключается
        _screenCoveragePanel.SetActive(false); //Панель с выбором типа покрытия дисплея выключается
        _imageScrollMenuUp.enabled = true;
        _imageScrollMenuDown.enabled = false;
        currentRAMLaptop = 4;
        currentROMLaptop = 64;
    }

    private void OnEnable()
    {
        _batteryPerformancePanel.SetActive(false);
        _coolingPerformancePanel.SetActive(false);
        _memoryPerformancePanel.SetActive(true);
        _exteriorExteriorPanel.SetActive(false);
    }

    void Start()
    {
        _backCreatePanelDisplay.SetActive(false);
        _backCreatePanelCost.SetActive(false);
        _backCreatePanelKeyboard.SetActive(false);
        _backCreatePanelExterior.SetActive(false);
        videocardLaptopPanel.SetActive(false);
        createInfoLaptopPanel.SetActive(false);
    }

    void Update()
    {
        if (_functionPanelButton.scrollMenuPanel.activeSelf == true) { _imageScrollMenuUp.enabled = false; _imageScrollMenuDown.enabled = true; }
        else { _imageScrollMenuUp.enabled = true; _imageScrollMenuDown.enabled = false; }

        if (_waterCooling.levelWaterCooling >= 1)
        {
            if (_waterCooling.addWaterCooling.isOn == true) { checkActiveWaterCooling = true; }
            else { checkActiveWaterCooling = false; }
        }
        else { checkActiveWaterCooling = false; }

        TextPercentCreateLaptop.text = PercentCreateLaptop.ToString() + "%"; //Вывод готовности в % в текст
        if (TextPercentCreateLaptop.enabled == false) StopCoroutine(CheckRatingLaptop()); //Если текст не активен, то корутина проверки рейтинга выключается  
    }

    public void performancePanelBattery()
    {
        _batteryPerformancePanel.SetActive(true);
        _coolingPerformancePanel.SetActive(false);
        _memoryPerformancePanel.SetActive(false);
        _performanceCoolingButton.color = activeColor;
        _performanceBatteryButton.color = _surprizeChest._moneyColorPrize;
        _performanceMemoryButton.color = activeColor;
    }
    public void performancePanelCooling()
    {
        _batteryPerformancePanel.SetActive(false);
        _coolingPerformancePanel.SetActive(true);
        _memoryPerformancePanel.SetActive(false);
        _performanceCoolingButton.color = _surprizeChest._moneyColorPrize;
        _performanceBatteryButton.color = activeColor;
        _performanceMemoryButton.color = activeColor;
    }
    public void performancePanelMemory()
    {
        _batteryPerformancePanel.SetActive(false);
        _coolingPerformancePanel.SetActive(false);
        _memoryPerformancePanel.SetActive(true);
        _performanceCoolingButton.color = activeColor;
        _performanceBatteryButton.color = activeColor;
        _performanceMemoryButton.color = _surprizeChest._moneyColorPrize;
    }

    public void InputFieldNameCompany() { NameLaptop = _inputFieldNameCompany.text; }  //Input field с выводом переменной имени в текст

    public void CreateLaptopButtonMain() { if (NameLaptop != "") { _MainCreatePanel.SetActive(true); _LaptopPanelCreate.SetActive(false); } }  //Кнопка продолжить в панели имени ноутбука

    public void DisplayPanelButtonCL() //Кнопка входа в панель display
    {
        DisplayPanelCreateLaptop.SetActive(true); //Активируем саму панель
        _MainCreatePanel.SetActive(false); //Выключаем основную панель CreateLaptop
        _backCreatePanelDisplay.SetActive(true); //активируем кнопку возвращения назад 
        quitCreatePanel.SetActive(false); //Кнопку выхода из всей панели выключаем
        textCreatePanel.text = "DISPLAY"; //Меняем текст на display  
        _screenResolutionPanel.SetActive(false); //Активация панели с выбором разрешения дисплея
        _screenCoveragePanel.SetActive(true); //Деактивация панели с выбором покрытия дисплея
        _displayResolutionButton.color = activeColor;
        _displayCoverageButton.color = _surprizeChest._moneyColorPrize;
    }
    public void BackCreateDisplayButton() //Вернуться обратно из панели display
    {
        _backCreatePanelDisplay.SetActive(false); //Выключаем кнопку возвращения назад в панели display
        DisplayPanelCreateLaptop.SetActive(false); //Деактивируем панель display
        _MainCreatePanel.SetActive(true); //Активируем основную панель 
        quitCreatePanel.SetActive(true); //Активируем кнопку выхода из панели
        textCreatePanel.text = "CREATE"; //Меняем текст обратно на Create
    }
    public void KeyboardPanelButtonCL() //Кнопка входа в панель keyboard
    {
        keyboardPanelCreateLaptop.SetActive(true); //Активируем саму панель
        _MainCreatePanel.SetActive(false); //Выключаем основную панель CreateLaptop
        _backCreatePanelKeyboard.SetActive(true);
        quitCreatePanel.SetActive(false); //Активируем кнопку выхода из панели
        textCreatePanel.text = "PERFORMANCE"; //Меняем текст на keyboard     
        _coolingPerformancePanel.SetActive(true);
        _memoryPerformancePanel.SetActive(false);
        _batteryPerformancePanel.SetActive(false);
        _performanceCoolingButton.color = _surprizeChest._moneyColorPrize;
        _performanceBatteryButton.color = activeColor;
        _performanceMemoryButton.color = activeColor;
    }
    public void BackKeyboardButton() //Вернуться обратно из панели keyboard
    {
        keyboardPanelCreateLaptop.SetActive(false); //Деактивируем панель keyboard
        _MainCreatePanel.SetActive(true); //Активируем основную панель 
        quitCreatePanel.SetActive(true); //Активируем кнопку выхода из панели
        _backCreatePanelKeyboard.SetActive(false);
        textCreatePanel.text = "CREATE"; //Меняем текст на Create
    }
    public void ExteriorDesignButton()
    {
        ExteriorDesignCreateLaptop.SetActive(true);
        _exteriorExteriorPanel.SetActive(true);
        _cameraExteriorPanel.SetActive(false);
        _MainCreatePanel.SetActive(false); //Выключаем основную панель CreateLaptop
        _backCreatePanelExterior.SetActive(true);
        quitCreatePanel.SetActive(false); //Активируем кнопку выхода из панели
        textCreatePanel.text = "Exterior Design"; //Меняем текст на Create    
        _cameraExteriorPanel.SetActive(false);
        _exteriorExteriorPanel.SetActive(true);
        _exteriorButton.color = _surprizeChest._moneyColorPrize;
        _cameraButton.color = activeColor;
    }
    public void backExteriorDesignButton()
    {
        ExteriorDesignCreateLaptop.SetActive(false);
        _MainCreatePanel.SetActive(true); //Выключаем основную панель CreateLaptop
        _backCreatePanelExterior.SetActive(false);
        quitCreatePanel.SetActive(true); //Активируем кнопку выхода из панели
        textCreatePanel.text = "CREATE"; //Меняем текст на Create
    }
    public void cameraExteriorPanelButton()
    {
        _cameraExteriorPanel.SetActive(true);
        _exteriorExteriorPanel.SetActive(false);
        _exteriorButton.color = activeColor;
        _cameraButton.color = _surprizeChest._moneyColorPrize;
    }
    public void exteriorPanelButton()
    {
        _cameraExteriorPanel.SetActive(false);
        _exteriorExteriorPanel.SetActive(true);
        _exteriorButton.color = _surprizeChest._moneyColorPrize;
        _cameraButton.color = activeColor;
    }

    public void ScreenResolutionButton() //Кнопка с выбором разрешения ноутбука
    {
        _screenResolutionPanel.SetActive(true); //Активация панели с выбором разрешения дисплея
        _screenCoveragePanel.SetActive(false); //Деактивация панели с выбором покрытия дисплея
        _displayResolutionButton.color = _surprizeChest._moneyColorPrize;
        _displayCoverageButton.color = activeColor;
    }
    public void ScreenCoverageButton() //Кнопка с выбором покрытия дисплея ноутбука
    {
        _screenCoveragePanel.SetActive(true); //Активация панели с выбором покрытия дисплея
        _screenResolutionPanel.SetActive(false); //Деактивация панели с выбором разрешения дисплея
        _displayResolutionButton.color = activeColor;
        _displayCoverageButton.color = _surprizeChest._moneyColorPrize;
    }   

    public void checkTextLaptopCreate()
    {
        if (_mainGameMechanics.staffsPlayer != 0)
        {
            if (!createInfoLaptopPanel.activeSelf)
            {
                textCreatePanel.text = "CREATE";
                _functionPanelButton._MenuPanel.SetActive(false);
                checkPanelActiveCL = true;
                _functionPanelButton.CreateLaptopPanel.SetActive(true);
                _MainCreatePanel.SetActive(false);
                _LaptopPanelCreate.SetActive(true);
                _functionPanelButton._allOffices.SetActive(false);
                _mainGameMechanics.textCostOption.enabled = true;
                NameLaptop = ""; //Название ноутбука становится пустым
                quitCreatePanel.SetActive(true);
                _ssdUpgrade.addSSDLaptop.isOn = false;
                RGBToggleLaptop.isOn = false;
                videocardLaptopPanel.SetActive(false);
                _screenSolution.checkResolution = 1;
                makeLaptopPanel.SetActive(false);
                _quickCharge.addQuickCharge.isOn = false;
                _waterCooling.addWaterCooling.isOn = false;
                _faceID.addFaceID.isOn = false;
                checkHelpTextLaptopCreate();
                _mainGameMechanics.FullZeroCostLaptop = 365;
                _memoryUpgrade.currentLevelMemory = 1;
            }
        }       
    }

    public void checkHelpTextLaptopCreate() { _ddrCP.levelDDRLaptop = 2; currentRAMLaptop = 4; currentROMLaptop = 64; }

    public void CreateButtonLaptop() //Кнопка для создания ноута после всех настроек
    {
        if (ownLaptopCompany == 0) _Rating = Random.Range(6, 8);
        else
        {
            if (scoreRatingAverage < _creatingAverageRating.scoresYearAverageRating) { _Rating = Random.Range(1, 5); }
            else if (scoreRatingAverage == _creatingAverageRating.scoresYearAverageRating)
            {
                if (_costSliderSettings.costSliderLaptop.value == _costSliderSettings.costSliderLaptop.maxValue) { _Rating = Random.Range(2, 4); }
                else { _Rating = Random.Range(4, 6); }
            }
            else if (scoreRatingAverage > _creatingAverageRating.scoresYearAverageRating)
            {
                if (_costSliderSettings.costSliderLaptop.value == _costSliderSettings.costSliderLaptop.maxValue) {  _Rating = Random.Range(3, 6); }                
                else { _Rating = Random.Range(5, 10); }
            }
        }
 
        costPanelCreateLaptop.SetActive(false); //Выключаем панель с настройкой цены
        makeLaptopPanel.SetActive(true);
        makeImageLaptopPanel.enabled = true;
        _mainGameMechanics.textCostOption.enabled = false;
        textCreatePanel.text = "MAKE LAPTOP"; //Меняем текст на Create
    }
    public void videocardLaptopCreatePanel() //Панель с настройкой цены
    {
        _MainCreatePanel.SetActive(false); //Деактивируем основную панель
        videocardLaptopPanel.SetActive(true);
        textCreatePanel.text = "VIDEO CARD"; //Меняем текст на Create
    }

    public void BackCostLaptopCreatePanel() //Вернуться обратно к основной панели
    {
        _MainCreatePanel.SetActive(true); //Активируем основную панель
        costPanelCreateLaptop.SetActive(false); //Деактивируем панель с настройкой цены
    }
    public void plusRAMCurrentLaptop()
    {
        if (currentRAMLaptop < maxRAMLaptop) { currentRAMLaptop *= 2; _mainGameMechanics.FullZeroCostLaptop += 20; }
    }
    public void plusROMCurrentLaptop()
    {
        if (currentROMLaptop < maxROMLaptop) { currentROMLaptop *= 2; _mainGameMechanics.FullZeroCostLaptop += 20; }
    }
    public void minesRAMCurrentLaptop()
    {
        if (currentRAMLaptop > 4) { currentRAMLaptop /= 2; _mainGameMechanics.FullZeroCostLaptop -= 20; }
    }
    public void minesROMCurrentLaptop()
    {
        if (currentROMLaptop > 64) { currentROMLaptop /= 2; _mainGameMechanics.FullZeroCostLaptop -= 20; }
    }

    public IEnumerator CheckRatingLaptop() //Корутина проверки рейтинга ноутбука
    {
        while(true)
        {
            textCreatePanel.text = "CREATING..."; //Меняем текст на Create
            if (PercentCreateLaptop < 99)
            {
                PercentCreateLaptop += 1;  //Если процент меньше или равен 99, то мы прибавляем ещё 1 к переменной процента
                TextPercentCreateLaptop.text = PercentCreateLaptop.ToString() + "%"; //Текст процентов выводит переменную процента готовности ноутбука          
                quitCreatePanel.SetActive(false);
                _ratingCreate.AverageRating = _Rating * 9 / 8.6f;
            } 
            else { quitCreatePanel.SetActive(true); }
               
            yield return new WaitForSeconds(0.1f);
            if (PercentCreateLaptop >= 99) //Если процент больше или равен 99
            {
                _functionPanelButton._MenuPanel.SetActive(true);
                _functionPanelButton._allOffices.SetActive(true);
                _functionPanelButton.CreateLaptopPanel.SetActive(false); //Панель создания ноутбука выключается
                _functionPanelButton.scrollMenuPanel.SetActive(false);
                StartCoroutine(secondPercentCreate());
                PercentCreateLaptop = 0; //Процент создания ноутбука равняется 0
                TextPercentCreateLaptop.enabled = false; //Текст процентов выключается
                PlayerPrefs.SetInt("DayNews", _gameData.Day);
                PlayerPrefs.SetInt("MonthNews", _gameData.Month);
                PlayerPrefs.SetInt("YearNews", (int)_gameData.Year);
                deactivePanelMakeLaptop = 0;
                ownLaptopCompany++;
                _percentCreateSlider.enabled = true;
                yield break;
            }          
        }
    }

    public void cancelReleaseButtonLaptop()
    {
        _ratingCreate.AverageRating = 0;
        _percentCreateLaptopPanel = 0;
        _mainGameMechanics.Money -= _mainGameMechanics.Money * 0.05;
        _mainGameMechanics.FullZeroCostLaptop = 365;
        _releasePanelLaptop.SetActive(false);
        _functionPanelButton._MenuPanel.SetActive(true);
        ownLaptopCompany--;
        _adsManager.freeRPCreatingPanelButton.SetActive(false);
        _functionPanelButton.scrollMenuPanel.SetActive(false);
        _percentCreateSlider.enabled = false;
    }

    public void releaseButtonLaptop()
    {
        _releasePanelLaptop.SetActive(false);
        _functionPanelButton._MenuPanel.SetActive(true);
        _ratingPanelCreateLaptop.SetActive(true);
        _adsManager.freeRPCreatingPanelButton.SetActive(false);
        _functionPanelButton.scrollMenuPanel.SetActive(false);
        _percentCreateSlider.enabled = false;
    }

    IEnumerator secondPercentCreate()
    {
        while(true)
        {
            if (!_ratingPanelCreateLaptop.activeSelf)
            {
                _percentInfoCreateLaptop.text = _percentCreateLaptopPanel + " %"; 
                _percentCreateSlider.value = _percentCreateLaptopPanel;
                _nameInfoCreateLaptop.text = NameLaptop;
                if (_percentCreateLaptopPanel <= 99) { createInfoLaptopPanel.SetActive(true); _percentCreateLaptopPanel++; }

                if (_percentCreateLaptopPanel >= 99) //Если процент больше или равен 99
                {
                    if (_functionPanelButton._MenuPanel.activeSelf)
                    {
                        _releasePanelLaptop.SetActive(true);
                        _functionPanelButton._MenuPanel.SetActive(false);
                        createInfoLaptopPanel.SetActive(false);
                        _percentCreateLaptopPanel = 0;
                        _percentCreateSlider.enabled = false;
                        yield break;
                    }
                }
            }
            yield return new WaitForSeconds(0.35f);
        }
    }

    IEnumerator CheckActivePanels() //Проверка на работу только одной панели, а не двух одновременно
    {
        while(true)
        {
            if (_screenResolutionPanel.activeSelf) _screenCoveragePanel.SetActive(false); //Если панель разрешений активна, то деактивируем панель с выбором покрытия
            else _screenCoveragePanel.SetActive(true); //Иначе активируем её
            yield return new WaitForSeconds(0.4f);
        }
    }
}
