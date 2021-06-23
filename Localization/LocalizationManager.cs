using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LocalizationManager : MonoBehaviour
{
    [Header("Индекс языка")]
    public byte _indexLanguage; // 1 - Eng/ 2 - Rus

    [Header("Загрузочный экран")]
    [SerializeField] private Text _loadingText;
    public string translateLoadingText;

    [Header("Главное меню")]
    [SerializeField] private Text _startButtonMenu;
    [SerializeField] private string translateStartButtonMenuText;
    [SerializeField] private Text _settingsButtonMenu;
    [SerializeField] private string translateSettingsButtonMenuText;
    [SerializeField] private Text _quitButtonMenu;
    [SerializeField] private string translateQuitButtonMenuText;

    [Header("Настройки в меню")]
    [SerializeField] private Text _settingsAudioTextMenu;
    [SerializeField] private string translateSettingsTextMenu;

    [Header("Панель перед выходом из игры")]
    [SerializeField] private Text _mainTextQuitGame; //Are you sure you want to ger out?
    [SerializeField] private string translateMainTextQuitPanel;
    [SerializeField] private Text _yesTextQuit;
    [SerializeField] private string translateYesTextQuit;
    [SerializeField] private Text _noTextQuit;
    [SerializeField] private string translateNoTextQuit;

    [Header("Пройти обучение?")]
    [SerializeField] private Text _takeTrainingText;
    [SerializeField] private string translateTakeTraining;
    [SerializeField] private Text _yesTextTraining;
    [SerializeField] private Text _noTextTraining;
    [SerializeField] private Text _warningTakeTrainingText;
    [SerializeField] private string translateWarningTakeTraining;

    [Header("Введите название компании")]
    [SerializeField] private Text _enterTextCompanyName;
    [SerializeField] private string translateEnterCompanyName;
    [SerializeField] private Text _startTextCompanyName;
    [SerializeField] private string translateStartCompanyName;

    [Header("Информация")]
    [SerializeField] private Text _informationText;
    [SerializeField] private string translateInformation;
    [SerializeField] private Text _socialNetworksText;
    [SerializeField] private string translateSocialNetworks;
    [SerializeField] private Text _getFreeMoney;
    [SerializeField] private string translateGetFreeMoney;
    [SerializeField] private Text _getFreeRP;
    [SerializeField] private string translateGetFreeRP;

    [Header("Компании")]
    public Text[] _buyTextCompany;
    [SerializeField] private string translateBuyCompanyButton;
    [SerializeField] private Text[] _purchasedTextCompany;
    [SerializeField] private string translatePurchasedCompany;

    [Header("Сотрдуники")]
    [SerializeField] private Text[] _experienceStaffText;
    [SerializeField] private string translateExperienceStaff;
    [SerializeField] private Text[] _ratingStaffText;
    [SerializeField] private string translateRatingStaff;
    [SerializeField] private Text[] _ageStaffText;
    [SerializeField] private string translateAgeStaff;
    [SerializeField] private Text[] _salaryStaffText;
    [SerializeField] private string translateSalaryStaff;
    [SerializeField] private Text[] _approveStaffText;
    public string translateApproveStaff;

    [Header("Маркетинг")]
    [SerializeField] private Text[] _daysMarketingText;
    public string translateDaysMarketing;
    [SerializeField] private Text[] _marketingTypeText;
    public string[] translateMarketingType;
    [SerializeField] private Text[] _levelMarketingText;
    public string translateMarketingLevel;

    [SerializeField] private Text _textTypeMarketingConfirm;
    [SerializeField] private Text _textLevelMarketingConfirm;
    [SerializeField] private Text _minFansMarketingConfirm;
    [SerializeField] private string translateMinFansMarketingConfirm;
    [SerializeField] private Text _maxFansMarketingConfirm;
    [SerializeField] private string translateMaxFansMarketingConfirm;
    [SerializeField] private Text _daysTextMarketingConfirm;
    [SerializeField] private Text _costTextMarketingConfirm;
    [SerializeField] private string translateCostMarketing;
    [SerializeField] private Text _specificationsTextMarketingConfirm;
    [SerializeField] private string translateSpecificationsConfirm;
    [SerializeField] private Text _confirmBuyAdsMarketing;
    [SerializeField] private string translateConfirmBuyAds;
    [SerializeField] private Text[] _yesTextButtonConfirm;
    [SerializeField] private Text[] _noTextButtonConfirm;


    [Header("Апгрейд панель")]
    [Header("Главная панель")]
    [SerializeField] private Text _textExteriorDesign;
    [SerializeField] private string translateExteriorDesignUpgrade;
    [SerializeField] private Text _textDisplay;
    [SerializeField] private string translateDisplayUpgrade;
    [SerializeField] private Text _textCamera;
    [SerializeField] private string translateCameraUpgrade;
    [SerializeField] private Text _textCPUMemory;
    [SerializeField] private string translateCpuMemoryUpgrade;
    [SerializeField] private Text _textOSMore;
    [SerializeField] private string translateOSMoreUpgrade;
    [SerializeField] private Text _textOther;
    [SerializeField] private string translateOtherUpgrade;
    [SerializeField] private Text _textOffice;
    [SerializeField] private string translateOfficeUpgrade;
    [SerializeField] private Text _textMarketing;
    [SerializeField] private string translateMarketingUpgrade;
    [SerializeField] private Text _textCooling;
    [SerializeField] private string translateCoolingUpgrade;
    [SerializeField] private Text _textBattery;
    [SerializeField] private string translateBatteryUpgrade;
    [SerializeField] private Text _textLaboratory;
    [SerializeField] private string translateLaboratoryUpgrade;

    [Header("Внешний дизайн")]

    [Header("Width Laptop")]
    [SerializeField] private Text _textExteriorWidthLaptop;
    [SerializeField] private Text _textExteriorWidthLaptopLevel;
    [SerializeField] private string translateWidthLaptop;

    [Header("Width Screen")]
    [SerializeField] private Text _textExteriorWidthScreen;
    [SerializeField] private Text _textExteriorWidthScreenLevel;
    [SerializeField] private string translateWidthScreen;

    [Header("Thickness Laptop")]
    [SerializeField] private Text _textExteriorThicknessLaptop;
    [SerializeField] private Text _textExteriorThicknessLevel;
    [SerializeField] private string translateThickness;

    [Header("Touchpad Laptop")]
    [SerializeField] private Text _textExteriorTouchpadLaptop;
    [SerializeField] private Text _textExteriorTouchpadLevel;
    [SerializeField] private string translateTouchpadLevel;

    [Header("Laptop corners")]
    [SerializeField] private Text _textExteriorCornesLaptop;
    [SerializeField] private Text _textExteriorCornesLevel;
    [SerializeField] private string translateLaptopCorners;

    [Header("Angle Screen")]
    [SerializeField] private Text _textExteriorAngleScreen;
    [SerializeField] private Text _textExteriorAngleScreenLevel;
    [SerializeField] private string translateAngleScreen;

    [Header("Дисплей")]
    [Header("Разрешение экрана")]
    [SerializeField] private Text _textDisplayScreenSolution;
    [SerializeField] private Text _textDisplayScreenSolutionLevel;
    [SerializeField] private string translateScreenSolution;
    [Header("Матрица")]
    [SerializeField] private Text _textDisplayScreenMatrix;
    [SerializeField] private Text _textDisplayScreenMatrixLevel;
    [SerializeField] private string translateScreenMatrix;
    [Header("Покрытие")]
    [SerializeField] private Text _textDisplayScreenCoverage;
    [SerializeField] private Text _textDisplayScreenCoverageLevel;
    [SerializeField] private string translateScreenCoverage;
    [Header("HZ")]
    [SerializeField] private Text _textDisplayScreenHZ;
    [SerializeField] private Text _textDisplayScreenHZLevel;
    [SerializeField] private string translateScreenHZ;

    [Header("Камера")]
    [SerializeField] private Text _textCameraFrontalCamera;
    [SerializeField] private string translateCameraFrontalCamera;
    [SerializeField] private Text _textCameraFrontalCameraLevel;

    [Header("Моя ОС")]
    [SerializeField] private Text _textMyOS;
    [SerializeField] private string translateMyOS;

    [Header("Дополнительно")]

    [Header("Риелтор")]
    [SerializeField] private Text _textRealtor;
    [SerializeField] private Text _textRealtorLevel;
    [SerializeField] private string translateRelator;

    [Header("Water Resistant")]
    [SerializeField] private Text _textWaterResistant;
    [SerializeField] private Text _textWaterResistantLevel;
    [SerializeField] private string translateWaterResistant;

    [Header("Офис")]
    [SerializeField] private Text _textOfficeUpgrade;
    [SerializeField] private Text _textOfficeLevel;
    [SerializeField] private string translateOffice;

    [Header("Снижение налогов")]
    [SerializeField] private Text _textTaxReduction;
    [SerializeField] private Text _textTaxReductionLevel;
    [SerializeField] private string translateTaxReduction;

    [Header("Маркетинг")]

    [Header("Радио")]
    [SerializeField] private Text _textRadioMarketing;
    [SerializeField] private Text _textRadioMarketingLevel;
    [SerializeField] private string translateRadioMarketing;

    [Header("ТВ")]
    [SerializeField] private Text _textTVMarketing;
    [SerializeField] private Text _textTVMarketingLevel;
    [SerializeField] private string translateTVMarketing;

    [Header("Journal")]
    [SerializeField] private Text _textJournalMarketing;
    [SerializeField] private Text _textJournalMarketingLevel;
    [SerializeField] private string translateJournalMarketing;

    [Header("Billboard")]
    [SerializeField] private Text _textBillboardMarketing;
    [SerializeField] private Text _textBillboardMarketingLevel;
    [SerializeField] private string translateBillboardMarketing;

    [Header("SMM")]
    [SerializeField] private Text _textSmmMarketing;
    [SerializeField] private Text _textSmmMarketingLevel;
    [SerializeField] private string translateSmmMarketing;

    [Header("E-Mail")]
    [SerializeField] private Text _textEmailMarketing;
    [SerializeField] private Text _textEmailMarketingLevel;
    [SerializeField] private string translateEmailMarketing;


    [Header("Охлаждение")]

    [Header("Air Cooling")]
    [SerializeField] private Text _textAirCooling;
    [SerializeField] private Text _textAirCoolingLevel;
    [SerializeField] private string translateAirCooling;

    [Header("Water Cooling")]
    [SerializeField] private Text _textWaterCooling;
    [SerializeField] private Text _textWaterCoolingLevel;
    [SerializeField] private string translateWaterCooling;

    [Header("Aerodynamic Resistance")]
    [SerializeField] private Text _textAerodynamicResistance;
    [SerializeField] private Text _textAerodynamicResistanceLevel;
    [SerializeField] private string translateAerodynamicResistance;

    [Header("Air Filter")]
    [SerializeField] private Text _textAirFilter;
    [SerializeField] private Text _textAirFilterLevel;
    [SerializeField] private string translateAirFilter;

    [Header("Батарея")]

    [Header("Quick Charge")]
   
    [SerializeField] private Text _textQuickChargeLevel;
    [SerializeField] private string translateQuickCharge;

    [Header("Wireless Charger")]

    [SerializeField] private Text _textWirelessChargerLevel;
    [SerializeField] private string translateWirelessCharger;

    [Header("Reduction Energy")]
    
    [SerializeField] private Text _textReductionEnergyLevel;
    [SerializeField] private string translateReductionEnergy;

    [Header("Power Supply Power")]
    
    [SerializeField] private Text _textPowerSupplyLevel;
    [SerializeField] private string translatePowerSupply;


    [Header("Pause")]
    [SerializeField] private Text _textPause;
    [SerializeField] private string translatePause;
    [SerializeField] private Text _textContinue;
    [SerializeField] private string translateContinue;
    [SerializeField] private Text _textExit;
    [SerializeField] private string translateExit;


    [Header("Create Panel")]

    [Header("First Slide")]
    [SerializeField] private Text _textCreateFirstSlide;
    [SerializeField] private string translateCreateFirstSlide;
    [SerializeField] private Text _textCreateLaptopButton;
    [SerializeField] private string translateCreateLaptopButton;
    [SerializeField] private Text _textNameLaptop;
    [SerializeField] private string translateNameLaptop;


    [Header("Exterior slide")]

    [Header("Angle Screen")]
    [SerializeField] private Text _textAngleScreen;
    public string translateAngleScreenCreate;

    [Header("Width Laptop")]
    [SerializeField] private Text _textWitdhLaptop;
    public string translateWidthLaptopCreate;

    [Header("Width Screen")]
    [SerializeField] private Text _textWidthScreen;
    public string translateWidthScreenCreate;

    [Header("Thickness Laptop")]
    [SerializeField] private Text _textThicknessLaptop;
    public string translateThicknessLaptopCreate;

    [Header("Touchpad Style")]
    [SerializeField] private Text _textTouchpadStyle;
    public string translateTouchpadStyleCreate;

    [Header("Cornes Laptop")]
    [SerializeField] private Text _textCornesLaptop;
    public string translateCornesLaptopCreate;

    [Header("Frontal Camera")]
    [SerializeField] private Text _textFrontalCamera;
    public string translateFrontalCameraCreate;

    [Header("Performance")]

    [Header("Cooling")]
    [SerializeField] private Text _textCoolingNamePerformancePanel;
    [SerializeField] private string translateCoolingNamePerformancePanel;

    [Header("Water Cooling")]
    [SerializeField] private Text _textWaterCoolingPerformance;
    [SerializeField] private string translateWaterCoolingPerformancePanel;

    [Header("Water Resistance")]
    [SerializeField] private Text _textWaterResistancePerformance;
    [SerializeField] private string translateWaterResistancePerformancePanel;

    [Header("Aerodynamic Resistance")]
    [SerializeField] private Text _textAerodynamicResistancePerformance;
    public string translateAerodynamicResistancePerformance;

    [Header("Air Cooling")]
    [SerializeField] private Text _textAirCoolingPerformance;
    public string translateAirCoolingPerformance;

    [Header("Air Filter")]
    [SerializeField] private Text _textAirFilterPerformance;
    public string translateAirFilterPerformance;

    [Header("Memory")]
    [SerializeField] private Text _textMemoryPerformancePanel;
    [SerializeField] private string translateMemoryPerformancePanel;

    [Header("Manufacturer")]
    [SerializeField] private Text _textManufacturerPerformancePanel;
    [SerializeField] private string translateManufacturerPerformancePanel;

    [Header("Battery")]
    [SerializeField] private Text _textBatteryPerformancePanel;
    [SerializeField] private string translateBatteryPerformancePanel;

    [Header("Wireless Charger")]
    [SerializeField] private Text _textWirelessChargerBattery;
    [SerializeField] private string translateWirelessChargerBattery;

    [Header("Quick Charge")]
    [SerializeField] private Text _textQuickChargeBattery;
    [SerializeField] private string translateQuickChargeBattery;

    [Header("Reduction Energy Consumption")]
    [SerializeField] private Text _textReductionEnergyConsumption;
    [SerializeField] private string translateReductionEnergyCons;

    [Header("Power Supply Power")]
    [SerializeField] private Text _textPowerSupplyPower;
    [SerializeField] private string translatePowerSupplyPower;

    [Header("Display")]
    [SerializeField] private Text _textScreenHZ;
    [SerializeField] private string translateScreenHZDisplay;
    [SerializeField] private Text _textScreenResolution;
    [SerializeField] private string translateScreenResolutionDisplay;
    [SerializeField] private Text _textScreenCoverage;
    [SerializeField] private string translateScreenCoverageDisplay;

    [Header("Cost Panel")]
    [SerializeField] private Text _textRulerLaptop;
    [SerializeField] private string translateRulerLaptop;
    [SerializeField] private Text _textLaptopOS;
    [SerializeField] private string translateOSLaptop;
    [SerializeField] private Text _textCostLaptop;
    [SerializeField] private string translateCostLaptop;
    [SerializeField] private Text _textHeadphones;
    [SerializeField] private string translateHeadphones;
    [SerializeField] private Text _textLaptopSleeve;
    [SerializeField] private string translateLaptopSleeve;


    [Header("Release Panel")]
    [SerializeField] private Text _textVideocardRelease;
    public string translateVideocardRelease;

    [SerializeField] private Text _textWaterCoolingRelease;
    public string translateWaterCoolingRelease;

    [SerializeField] private Text _textQuickChargeRelease;
    public string translateQuickChargeRelease;

    [SerializeField] private Text _textWaterResistanceRelease;
    public string translateWaterResistanceRelease;

    [SerializeField] private Text _textWirelessChargerRelease;
    public string translateWirelessChargerRelease;

    [Header("Rating")]
    [SerializeField] private Text _textAverageRating;
    [SerializeField] private string translateAverageRating;

    [Header("Quests")]
    [Header("Fans")]
    [SerializeField] private Text _textFanQuest;
    public string translateFanQuest;
    [Header("Office level")]
    [SerializeField] private Text _textOfficeQuest;
    public string translateOfficeQuest;
    public string translateOfficeQuestLevel;
    [Header("Present Box")]
    [SerializeField] private Text _textPresentBox;
    public string translatePresentBox;
    [Header("Buy Company")]
    [SerializeField] private Text _textBuyCompany;
    public string translateBuyCompany;
    [Header("Employees")]
    [SerializeField] private Text _textEmployeesQuest;
    public string translateEmployees;
    [Header("Survive the Crisis")]
    [SerializeField] private Text _textSurviveCrisisQuest;
    public string translateSurviveCrisis;

    [Header("Quit confirm create panel")]
    [SerializeField] private Text _textConfirmQuitCreatePanel;
    [SerializeField] private string translateConfirmQuitCreatePanel;
    [SerializeField] private Text _textConfirmNo;
    [SerializeField] private string translateConfirmNo;
    [SerializeField] private Text _textConfirmYes;
    [SerializeField] private string translateConfirmYes;

    [Header("OS Panel")]
    [SerializeField] private Text _textEnterOSName;
    [SerializeField] private string translateEnterOSName;

    [SerializeField] private Text _textStartOpenOS;
    [SerializeField] private string translateStartOpenOS;

    [Header("OS Function")]
    [SerializeField] private Text _textOSSecurity;
    [SerializeField] private string translateOSSecurity;

    [SerializeField] private Text _textOSPerformance;
    [SerializeField] private string translateOSPerformance;

    [SerializeField] private Text _textOSAnimation;
    [SerializeField] private string translateOSAnimation;

    [SerializeField] private Text _textOSOptimization;
    [SerializeField] private string translateOSOptimization;

    [SerializeField] private Text _textOSMultitasking;
    [SerializeField] private string translateOSMultitasking;

    [SerializeField] private Text _textOSFunctional;
    [SerializeField] private string translateOSFunctional;

    [SerializeField] private Text _textOSConvenience;
    [SerializeField] private string translateOSConvenience;

    [SerializeField] private Text _textOSAutonomy;
    [SerializeField] private string translateOSAutonomy;


    void Start()
    {
        if (PlayerPrefs.HasKey("indexLanguage")) { _indexLanguage = (byte)PlayerPrefs.GetInt("indexLanguage"); }
        StartCoroutine(checkTranslateIndex());
        StartCoroutine(checkTranslate());
        upgradePanel();
        questPanel();
        createPanel();
        osPanel();
        _startButtonMenu.text = translateStartButtonMenuText;
        _settingsButtonMenu.text = translateSettingsButtonMenuText;
        _quitButtonMenu.text = translateQuitButtonMenuText;
        _settingsAudioTextMenu.text = translateSettingsTextMenu;
        _yesTextQuit.text = translateYesTextQuit;
        _noTextQuit.text = translateNoTextQuit;
        _mainTextQuitGame.text = translateMainTextQuitPanel;
        _yesTextTraining.text = translateYesTextQuit;
        _noTextTraining.text = translateNoTextQuit;
        _takeTrainingText.text = translateTakeTraining;
        _warningTakeTrainingText.text = translateWarningTakeTraining;
        _startTextCompanyName.text = translateStartCompanyName;
        _enterTextCompanyName.text = translateEnterCompanyName;
        _informationText.text = translateInformation;
        _socialNetworksText.text = translateSocialNetworks;
        _getFreeMoney.text = translateGetFreeMoney;
        _getFreeRP.text = translateGetFreeRP;
        _textAverageRating.text = translateAverageRating;
        _textConfirmQuitCreatePanel.text = translateConfirmQuitCreatePanel;
        _textConfirmNo.text = translateConfirmNo;
        _textConfirmYes.text = translateConfirmYes;
        _textEnterOSName.text = translateEnterOSName;
        _textStartOpenOS.text = translateStartOpenOS;      
    }

    private void questPanel()
    {
        _textFanQuest.text = translateFanQuest;
        _textOfficeQuest.text = translateOfficeQuest;
        _textPresentBox.text = translatePresentBox;
        _textBuyCompany.text = translateBuyCompany;
        _textEmployeesQuest.text = translateEmployees;
        _textSurviveCrisisQuest.text = translateSurviveCrisis;
    }

    private void osPanel()
    {
        _textOSSecurity.text = translateOSSecurity;
        _textOSPerformance.text = translateOSPerformance;
        _textOSAnimation.text = translateOSAnimation;
        _textOSOptimization.text = translateOSOptimization;
        _textOSMultitasking.text = translateOSMultitasking;
        _textOSFunctional.text = translateOSConvenience;
        _textOSAutonomy.text = translateOSAutonomy;
        _textOSConvenience.text = translateOSAutonomy;
    }

    private void ReleasePanel()
    {
        _textVideocardRelease.text = translateVideocardRelease;
        _textWaterCoolingRelease.text = translateWaterCoolingRelease;
        _textQuickChargeRelease.text = translateQuickChargeRelease;
        _textWaterResistanceRelease.text = translateWaterResistanceRelease;
        _textWirelessChargerRelease.text = translateWirelessChargerRelease;
    }
    private void createPanel()
    {
        _textCreateFirstSlide.text = translateCreateFirstSlide;
        _textCreateLaptopButton.text = translateCreateLaptopButton;
        _textNameLaptop.text = translateNameLaptop;

        _textAngleScreen.text = translateAngleScreenCreate;
        _textWitdhLaptop.text = translateWidthLaptopCreate;
        _textWidthScreen.text = translateWidthScreenCreate;
        _textThicknessLaptop.text = translateThicknessLaptopCreate;
        _textTouchpadStyle.text = translateTouchpadStyleCreate;
        _textCornesLaptop.text = translateCornesLaptopCreate;
        _textFrontalCamera.text = translateFrontalCameraCreate;

        //cost
        _textRulerLaptop.text = translateRulerLaptop;
        _textLaptopOS.text = translateOSLaptop;
        _textCostLaptop.text = translateCostLaptop;
        _textHeadphones.text = translateHeadphones;
        _textLaptopSleeve.text = translateLaptopSleeve;


        //Cooling
        _textCoolingNamePerformancePanel.text = translateCoolingNamePerformancePanel;
        _textWaterCoolingPerformance.text = translateWaterCoolingPerformancePanel;
        _textWaterResistancePerformance.text = translateWaterResistancePerformancePanel;
        _textAerodynamicResistancePerformance.text = translateAerodynamicResistancePerformance;
        _textAirCoolingPerformance.text = translateAirCoolingPerformance;
        _textAirFilterPerformance.text = translateAirFilterPerformance;

        //Memory
        _textManufacturerPerformancePanel.text = translateManufacturerPerformancePanel;
        _textMemoryPerformancePanel.text = translateMemoryPerformancePanel;

        //Display
        _textScreenHZ.text = translateScreenHZDisplay;
        _textScreenResolution.text = translateScreenResolutionDisplay;
        _textScreenCoverage.text = translateScreenCoverageDisplay;

    }
    private void batteryPerformance()
    {
        //Battery
        _textBatteryPerformancePanel.text = translateBatteryPerformancePanel;
        _textReductionEnergyConsumption.text = translateReductionEnergyCons;
        _textPowerSupplyPower.text = translatePowerSupplyPower;
        _textWirelessChargerBattery.text = translateWirelessChargerBattery;
        _textQuickChargeBattery.text = translateQuickChargeBattery;
    }
    private void buyTextCompanys()
    {
        _buyTextCompany[0].text = translateBuyCompanyButton;
        _buyTextCompany[1].text = translateBuyCompanyButton;
        _buyTextCompany[2].text = translateBuyCompanyButton;
        _buyTextCompany[3].text = translateBuyCompanyButton;
        _buyTextCompany[4].text = translateBuyCompanyButton;
        _buyTextCompany[5].text = translateBuyCompanyButton;

        _purchasedTextCompany[0].text = translatePurchasedCompany;
        _purchasedTextCompany[1].text = translatePurchasedCompany;
        _purchasedTextCompany[2].text = translatePurchasedCompany;
        _purchasedTextCompany[3].text = translatePurchasedCompany;
        _purchasedTextCompany[4].text = translatePurchasedCompany;
        _purchasedTextCompany[5].text = translatePurchasedCompany;
    }
    private void approveStaff()
    {
        _experienceStaffText[0].text = translateExperienceStaff;
        _experienceStaffText[1].text = translateExperienceStaff;
        _experienceStaffText[2].text = translateExperienceStaff;
        _experienceStaffText[3].text = translateExperienceStaff;

        _ratingStaffText[0].text = translateRatingStaff;
        _ratingStaffText[1].text = translateRatingStaff;
        _ratingStaffText[2].text = translateRatingStaff;
        _ratingStaffText[3].text = translateRatingStaff;

        _ageStaffText[0].text = translateAgeStaff;
        _ageStaffText[1].text = translateAgeStaff;
        _ageStaffText[2].text = translateAgeStaff;
        _ageStaffText[3].text = translateAgeStaff;

        _salaryStaffText[0].text = translateSalaryStaff;
        _salaryStaffText[1].text = translateSalaryStaff;
        _salaryStaffText[2].text = translateSalaryStaff;
        _salaryStaffText[3].text = translateSalaryStaff;

        _approveStaffText[0].text = translateApproveStaff;
        _approveStaffText[1].text = translateApproveStaff;
        _approveStaffText[2].text = translateApproveStaff;
        _approveStaffText[3].text = translateApproveStaff;
    }
    private void marketingPanel()
    {
        _marketingTypeText[0].text = translateMarketingType[0];
        _marketingTypeText[1].text = translateMarketingType[1];
        _marketingTypeText[2].text = translateMarketingType[2];
        _marketingTypeText[3].text = translateMarketingType[3];
        _marketingTypeText[4].text = translateMarketingType[4];
        _marketingTypeText[5].text = translateMarketingType[5];

        _levelMarketingText[0].text = translateMarketingLevel;
        _levelMarketingText[1].text = translateMarketingLevel;
        _levelMarketingText[2].text = translateMarketingLevel;
        _levelMarketingText[3].text = translateMarketingLevel;
        _levelMarketingText[4].text = translateMarketingLevel;
        _levelMarketingText[5].text = translateMarketingLevel;

        _textLevelMarketingConfirm.text = translateMarketingLevel;
        _minFansMarketingConfirm.text = translateMinFansMarketingConfirm;
        _maxFansMarketingConfirm.text = translateMaxFansMarketingConfirm;
        _daysTextMarketingConfirm.text = translateDaysMarketing;
        _costTextMarketingConfirm.text = translateCostMarketing;
        _specificationsTextMarketingConfirm.text = translateSpecificationsConfirm;
        _confirmBuyAdsMarketing.text = translateConfirmBuyAds;
        _noTextButtonConfirm[0].text = translateNoTextQuit;
        _noTextButtonConfirm[1].text = translateNoTextQuit;
        _noTextButtonConfirm[2].text = translateNoTextQuit;
        _noTextButtonConfirm[3].text = translateNoTextQuit;
        _noTextButtonConfirm[4].text = translateNoTextQuit;
        _noTextButtonConfirm[5].text = translateNoTextQuit;
    }
    private void upgradePanel()
    {
        _textExteriorDesign.text = translateExteriorDesignUpgrade;
        _textDisplay.text = translateDisplayUpgrade;
        _textCamera.text = translateCameraUpgrade;
        _textCPUMemory.text = translateCpuMemoryUpgrade;
        _textOSMore.text = translateOSMoreUpgrade;
        _textOther.text = translateOtherUpgrade;
        _textOffice.text = translateOfficeUpgrade;
        _textMarketing.text = translateMarketingUpgrade;
        _textCooling.text = translateCoolingUpgrade;
        _textBattery.text = translateBatteryUpgrade;
        _textLaboratory.text = translateLaboratoryUpgrade;

        //Cooling

        //Air Cooling
        _textAirCooling.text = translateAirCooling;
        _textAirCoolingLevel.text = translateMarketingLevel;

        //Water Cooling
        _textWaterCooling.text = translateWaterCooling;
        _textWaterCoolingLevel.text = translateMarketingLevel;

        //Aerodynamic Resistance
        _textAerodynamicResistance.text = translateAerodynamicResistance;
        _textAerodynamicResistanceLevel.text = translateMarketingLevel;

        //Air Filter
        _textAirFilter.text = translateAirFilter;
        _textAirFilterLevel.text = translateMarketingLevel;



        //Radio Marketing Upgrade
        _textRadioMarketing.text = translateRadioMarketing;
        _textRadioMarketingLevel.text = translateMarketingLevel;

        //TV Marketing Upgrade
        _textTVMarketing.text = translateTVMarketing;
        _textTVMarketingLevel.text = translateMarketingLevel;

        //Journal Marketing Upgrade
        _textJournalMarketing.text = translateJournalMarketing;
        _textJournalMarketingLevel.text = translateMarketingLevel;

        //Billboard Marketing Upgrade
        _textBillboardMarketing.text = translateBillboardMarketing;
        _textBillboardMarketingLevel.text = translateMarketingLevel;

        //SMM Marketing Upgrade
        _textSmmMarketing.text = translateSmmMarketing;
        _textSmmMarketingLevel.text = translateMarketingLevel;

        //E-Mail Marketing Upgrade
        _textEmailMarketing.text = translateEmailMarketing;
        _textEmailMarketingLevel.text = translateMarketingLevel;









        //Screen Solution
        _textDisplayScreenSolution.text = translateScreenSolution;
        _textDisplayScreenSolutionLevel.text = translateMarketingLevel;

        //Screen Matrix
        _textDisplayScreenMatrix.text = translateScreenMatrix;
        _textDisplayScreenMatrixLevel.text = translateMarketingLevel;

        //Screen Coverage
        _textDisplayScreenCoverage.text = translateScreenCoverage;
        _textDisplayScreenMatrixLevel.text = translateMarketingLevel;

        //Screen HZ
        _textDisplayScreenHZ.text = translateScreenHZ;
        _textDisplayScreenHZLevel.text = translateMarketingLevel;

        //Width Laptop
        _textExteriorWidthLaptop.text = translateWidthLaptop;
        _textExteriorWidthLaptopLevel.text = translateMarketingLevel;

        //Width Screen
        _textExteriorWidthScreen.text = translateWidthScreen;
        _textExteriorWidthScreenLevel.text = translateMarketingLevel;

        //Thickness Laptop
        _textExteriorThicknessLaptop.text = translateThickness;
        _textExteriorThicknessLevel.text = translateMarketingLevel;

        //Touchpad Laptop
        _textExteriorTouchpadLaptop.text = translateTouchpadLevel;
        _textExteriorTouchpadLevel.text = translateMarketingLevel;

        //Laptop corners
        _textExteriorCornesLaptop.text = translateLaptopCorners;
        _textExteriorCornesLevel.text = translateMarketingLevel;

        //Angle Screen
        _textExteriorAngleScreen.text = translateAngleScreen;
        _textExteriorAngleScreenLevel.text = translateMarketingLevel;

        //Frontal Camera 
        _textCameraFrontalCamera.text = translateCameraFrontalCamera;
        _textCameraFrontalCameraLevel.text = translateMarketingLevel;

        //OS
        _textMyOS.text = translateMyOS;

        //Realtor
        _textRealtor.text = translateRelator;
        _textRealtorLevel.text = translateMarketingLevel;

        //Water Resistant
        _textWaterResistant.text = translateWaterResistant;
        _textWaterResistantLevel.text = translateMarketingLevel;

        //Office
        _textOfficeUpgrade.text = translateOffice;
        _textOfficeLevel.text = translateMarketingLevel;

        //Tax reduction
        _textTaxReduction.text = translateTaxReduction;
        _textTaxReductionLevel.text = translateMarketingLevel;
    }
    private void pausePanel()
    {
        _textPause.text = translatePause;
        _textContinue.text = translateContinue;
        _textExit.text = translateExit;
    }

  

    IEnumerator checkTranslateIndex()
    {
        while(true)
        {
            buyTextCompanys();
            approveStaff();
            marketingPanel();
            pausePanel();
            createPanel();
            batteryPerformance();
            ReleasePanel();
            questPanel();
            osPanel();
            if (_indexLanguage == 1)
            {
                translateLoadingText = "Loading";
                translateStartButtonMenuText = "Start";
                translateSettingsButtonMenuText = "Settings";
                translateQuitButtonMenuText = "Quit";
                translateSettingsTextMenu = "Active Audio";
                translateMainTextQuitPanel = "Are you sure you want to quit the game?";
                translateYesTextQuit = "Yes";
                translateNoTextQuit = "No";
                translateTakeTraining = "Take Training?";
                translateWarningTakeTraining = "We advise you to go through the tutorial if you have not played this game before";
                translateEnterCompanyName = "Enter Company Name";
                translateStartCompanyName = "Start";
                translateInformation = "INFORMATION";
                translateSocialNetworks = "WE ARE IN SOCIAL NETWORKS";
                translateGetFreeMoney = "GET FREE $30 000 000";
                translateGetFreeRP = "GET FREE +20 RP";
                translateBuyCompanyButton = "BUY";
                translatePurchasedCompany = "Purchased by!";
                translateExperienceStaff = "EXPERIENCE";
                translateRatingStaff = "RATING";
                translateAgeStaff = "AGE";
                translateSalaryStaff = "SALARY";
                translateApproveStaff = "Approve";
                translateDaysMarketing = "DAYS";
                translateMarketingLevel = "Level";
                translateMinFansMarketingConfirm = "Min.Fans";
                translateMaxFansMarketingConfirm = "Max.Fans";
                translateCostMarketing = "Cost";
                translateSpecificationsConfirm = "Specifications";
                translateConfirmBuyAds = "Are you sure you want to buy ads?";
                translateExteriorDesignUpgrade = "Exterior Design";
                translateDisplayUpgrade = "Display";
                translateCameraUpgrade = "Camera";
                translateCpuMemoryUpgrade = "CPU & Memory";
                translateOSMoreUpgrade = "OS & More";
                translateOtherUpgrade = "Other";
                translateOfficeUpgrade = "Office";
                translateMarketingUpgrade = "Marketing";
                translateCoolingUpgrade = "Cooling";
                translateBatteryUpgrade = "Battery";
                translateLaboratoryUpgrade = "Laboratory";
                translateWidthLaptop = "Width Laptop";
                translateWidthScreen = "Width Screen";
                translateThickness = "Thickness Laptop";
                translateTouchpadLevel = "Touchpad Style";
                translateLaptopCorners = "Laptop corners";
                translateAngleScreen = "Angle Screen";
                translateScreenSolution = "Screen Solution";
                translateScreenMatrix = "Screen Matrix";
                translateScreenCoverage = "Screen Coverage";
                translateScreenHZ = "Screen HZ";
                translateCameraFrontalCamera = "Frontal Camera";
                translateMyOS = "My OS";
                translateRelator = "Realtor";
                translateWaterResistant = "Water Resistan";
                translateWaterResistancePerformancePanel = "Water Resistant";
                translateOffice = "Office";
                translateTaxReduction = "Tax Reduction";
                translateRadioMarketing = "Radio";
                translateTVMarketing = "TV";
                translateJournalMarketing = "Journal";
                translateBillboardMarketing = "Billboard";
                translateSmmMarketing = "SMM";
                translateEmailMarketing = "E-Mail";
                translateAirCooling = "Air Cooling";
                translateWaterCooling = "Water Cooling";
                translateAerodynamicResistance = "Aerodynamic Resistance";
                translateAirFilter = "Air Filter";
                translateQuickCharge = "Quick Charge";
                translateWirelessCharger = "Wireless Charger";
                translateReductionEnergy = "Reduction in Energy Consumption";
                translatePowerSupply = "Battery Power";
                translatePause = "PAUSE";
                translateContinue = "CONTINUE";
                translateExit = "EXIT";
                translateCreateFirstSlide = "NAME";
                translateCreateLaptopButton = "Create Laptop";
                translateNameLaptop = "Enter Name:";
                translateAngleScreenCreate = "Angle Screen";
                translateWidthLaptopCreate = "Width Laptop";
                translateWidthScreenCreate = "Width Screen";
                translateThicknessLaptopCreate = "Thickness Laptop";
                translateTouchpadStyleCreate = "Touchpad Style";
                translateCornesLaptopCreate = "Laptop cornes";
                translateFrontalCameraCreate = "Frontal Camera";
                translateCoolingNamePerformancePanel = "COOLING";
                translateWaterCoolingPerformancePanel = "Water Cooling";
                translateAerodynamicResistancePerformance = "Aerodynamic Resistance";
                translateAirCoolingPerformance = "Air Cooling";
                translateAirFilterPerformance = "Air Filter";
                translateManufacturerPerformancePanel = "Manufacturer";
                translateMemoryPerformancePanel = "MEMORY";
              


                translateMarketingType[0] = "Radio";
                translateMarketingType[1] = "TV";
                translateMarketingType[2] = "Journal";
                translateMarketingType[3] = "Billboard";
                translateMarketingType[4] = "SMM";
                translateMarketingType[5] = "E-Mail";
            }
            else if (_indexLanguage == 2)
            {
                translateLoadingText = "Загрузка";
                translateStartButtonMenuText = "Начать";
                translateSettingsButtonMenuText = "Настройки";
                translateQuitButtonMenuText = "Выйти";
                translateSettingsTextMenu = "Включить звук";
                translateMainTextQuitPanel = "Вы уверены, что хотите выйти из игры?";
                translateYesTextQuit = "Да";
                translateNoTextQuit = "Нет";
                translateTakeTraining = "Пройти Обучение?";
                translateWarningTakeTraining = "Мы советуем Вам пройти обучение, если вы не играли в эту игру раньше.";
                translateEnterCompanyName = "Введите Название Компании";
                translateStartCompanyName = "Начать";
                translateInformation = "ИНФОМРАЦИЯ";
                translateSocialNetworks = "МЫ В СОЦИАЛЬНЫХ СЕТЯХ";
                translateGetFreeMoney = "БЕСПЛАТНО $30 000 000";
                translateGetFreeRP = "БЕСПЛАТНО +20 RP";
                translateBuyCompanyButton = "Купить";
                translatePurchasedCompany = "Приобретено!";
                translateExperienceStaff = "Опыт";
                translateRatingStaff = "Рейтинг";
                translateAgeStaff = "Возраст";
                translateSalaryStaff = "Зарплата";
                translateApproveStaff = "Нанять";
                translateDaysMarketing = "Дней";
                translateMarketingLevel = "Уровень";
                translateMinFansMarketingConfirm = "Мин. Фанатов";
                translateMaxFansMarketingConfirm = "Макс. Фанатов";
                translateCostMarketing = "Стоимость";
                translateSpecificationsConfirm = "Характеристики";
                translateConfirmBuyAds = "Вы уверены, что хотите купить рекламу?";
                translateExteriorDesignUpgrade = "Внешний Дизайн";
                translateDisplayUpgrade = "Дисплей";
                translateCameraUpgrade = "Камера";
                translateCpuMemoryUpgrade = "CPU & Память";
                translateOSMoreUpgrade = "ОС & Другое";
                translateOtherUpgrade = "Дополнительно";
                translateOfficeUpgrade = "Офис";
                translateMarketingUpgrade = "Маркетинг";
                translateCoolingUpgrade = "Охлаждение";
                translateBatteryUpgrade = "Батарея";
                translateLaboratoryUpgrade = "Лаборатория";
                translateWidthLaptop = "Ширина Ноутбука";
                translateWidthScreen = "Ширина Экрана";
                translateTouchpadLevel = "Стиль Тачпада";
                translateLaptopCorners = "Углы Ноутбука";
                translateAngleScreen = "Углы Экрана";
                translateScreenSolution = "Разрешение Дисплея";
                translateScreenMatrix = "Матрица Дисплея";
                translateScreenCoverage = "Покрытие Дисплея";
                translateScreenHZ = "ГЦ Дисплея";
                translateThickness = "Толщина Ноутбука";
                translateCameraFrontalCamera = "Фронт. Камера";
                translateMyOS = "Моя ОС";
                translateRelator = "Риелтор";
                translateWaterResistant = "Влагозащита";
                translateWaterResistancePerformancePanel = "Влагозащита";
                translateOffice = "Офис";
                translateTaxReduction = "Снижение Налогов";
                translateRadioMarketing = "Радио";
                translateTVMarketing = "ТВ";
                translateJournalMarketing = "Журнал";
                translateBillboardMarketing = "Билборд";
                translateSmmMarketing = "СММ";
                translateEmailMarketing = "E-Mail";
                translateAirCooling = "Воздушное Охлаждение";
                translateWaterCooling = "Водяное Охлаждение";
                translateAerodynamicResistance = "Аэродин. Сопротивление";
                translateAirFilter = "Воздушный Фильтр";
                translateQuickCharge = "Быстрая Зарядка";
                translateWirelessCharger = "Беспроводная Зарядка";
                translateReductionEnergy = "Снижение Энергопотр.";
                translatePowerSupply = "Мощность Батареи";
                translatePause = "ПАУЗА";
                translateContinue = "Продолжить";
                translateExit = "Выйти";
                translateCreateFirstSlide = "Название";
                translateCreateLaptopButton = "Создать Ноутбук";
                translateNameLaptop = "Введите Название";
                translateAngleScreenCreate = "Углы Экрана";
                translateWidthLaptopCreate = "Ширина Ноутбука";
                translateWidthScreenCreate = "Ширина Экрана";
                translateThicknessLaptopCreate = "Толщина Ноутбука";
                translateTouchpadStyleCreate = "Стиль Тачпада";
                translateCornesLaptopCreate = "Углы Ноутбука";
                translateFrontalCameraCreate = "Фронт. Камера";
                translateCoolingNamePerformancePanel = "Охлаждение";
                translateWaterCoolingPerformancePanel = "Водян. Охлажд.";
                translateAerodynamicResistancePerformance = "Аэродин. Сопр.";
                translateAirCoolingPerformance = "Воздуш. Охлажд.";
                translateAirFilterPerformance = "Воздуш. Фильтер";
                translateManufacturerPerformancePanel = "Производитель";
                translateMemoryPerformancePanel = "Память";
               

                translateMarketingType[0] = "Радио";
                translateMarketingType[1] = "ТВ";
                translateMarketingType[2] = "Журнал";
                translateMarketingType[3] = "Билборд";
                translateMarketingType[4] = "СММ";
                translateMarketingType[5] = "E-Mail";
            }
            else
            {
                translateLoadingText = "Läser in";
                translateStartButtonMenuText = "Att börja";
                translateSettingsButtonMenuText = "inställningar";
                translateQuitButtonMenuText = "Gå ut";
                translateSettingsTextMenu = "Slå på ljudet";
                translateMainTextQuitPanel = "Är du säker på att du vill avsluta spelet?";
                translateYesTextQuit = "Ja";
                translateNoTextQuit = "Nej";
                translateTakeTraining = "Ta träningen?";
                translateWarningTakeTraining = "Vi rekommenderar att du slutför självstudien om du inte har spelat det här spelet tidigare.";
                translateEnterCompanyName = "Ange företagsnamn";
                translateStartCompanyName = "Att börja";
                translateInformation = "INFORMATION";
                translateSocialNetworks = "VI ÄR I SOCIALA NÄTVERK";
                translateGetFreeMoney = "ÄR GRATIS $30 000 000";
                translateGetFreeRP = "ÄR GRATIS +20 RP";
                translateBuyCompanyButton = "köpa";
                translatePurchasedCompany = "Köpt!";
                translateExperienceStaff = "Erfarenhet";
                translateRatingStaff = "Betyg";
                translateAgeStaff = "Ålder";
                translateSalaryStaff = "Lön";
                translateApproveStaff = "Att hyra";
                translateDaysMarketing = "Dagar";
                translateMarketingLevel = "Nivå";
                translateMinFansMarketingConfirm = "Min. Fläktar";
                translateMaxFansMarketingConfirm = "Max. Fläktar";
                translateCostMarketing = "Kostnaden";
                translateSpecificationsConfirm = "Specifikationer";
                translateConfirmBuyAds = "Är du säker på att du vill köpa annonser?";
                translateExteriorDesignUpgrade = "Exteriör design";
                translateDisplayUpgrade = "Skärmdisplay";
                translateCameraUpgrade = "Kamera";
                translateCpuMemoryUpgrade = "CPU & Minne";
                translateOSMoreUpgrade = "ОS & Övrig";
                translateOtherUpgrade = "Dessutom";
                translateOfficeUpgrade = "Kontor";
                translateMarketingUpgrade = "Marknadsföring";
                translateCoolingUpgrade = "Kyl";
                translateBatteryUpgrade = "Batteri";
                translateLaboratoryUpgrade = "Laboratorium";
                translateWidthLaptop = "Bärbar datorbredd";
                translateWidthScreen = "Skärmbredd";
                translateTouchpadLevel = "Pekplattans stil";
                translateLaptopCorners = "Anteckningsbokshörn";
                translateAngleScreen = "Skärmhörn";
                translateScreenSolution = "Skärmupplösning";
                translateScreenMatrix = "Visa matris";
                translateScreenCoverage = "Skärmskydd";
                translateScreenHZ = "HZ-skärm";
                translateThickness = "Bärbar datortjocklek";
                translateCameraFrontalCamera = "Främre. Kamera";
                translateMyOS = "Mitt OS";
                translateRelator = "Fastighetsmäklare";
                translateWaterResistant = "Fuktskydd";
                translateWaterResistancePerformancePanel = "Fuktskydd";
                translateOffice = "Kontor";
                translateTaxReduction = "Minska skatter";
                translateRadioMarketing = "Radio";
                translateTVMarketing = "TV";
                translateJournalMarketing = "Tidskrift";
                translateBillboardMarketing = "Anslagstavla";
                translateSmmMarketing = "SMM";
                translateEmailMarketing = "E-Mail";
                translateAirCooling = "Luftkylning";
                translateWaterCooling = "Vattenkylning";
                translateAerodynamicResistance = "Aerodynamiskt motstånd";
                translateAirFilter = "Luftfilter";
                translateQuickCharge = "Snabb laddning";
                translateWirelessCharger = "Trådlös laddare";
                translateReductionEnergy = "Minskad energiförbrukning";
                translatePowerSupply = "Batterikraft";
                translatePause = "PAUS";
                translateContinue = "Fortsätta";
                translateExit = "Gå ut";
                translateCreateFirstSlide = "namn";
                translateCreateLaptopButton = "Skapa bärbar dator";
                translateNameLaptop = "Ange titeln";
                translateAngleScreenCreate = "Skärmhörn";
                translateWidthLaptopCreate = "Bärbar datorbredd";
                translateWidthScreenCreate = "Skärmbredd";
                translateThicknessLaptopCreate = "Bärbar datortjocklek";
                translateTouchpadStyleCreate = "Pekplattans stil";
                translateCornesLaptopCreate = "Anteckningsbokshörn";
                translateFrontalCameraCreate = "Främre. Kamera";
                translateCoolingNamePerformancePanel = "Kyl";
                translateWaterCoolingPerformancePanel = "Vattenkylning";
                translateAerodynamicResistancePerformance = "Aerodynamik";
                translateAirCoolingPerformance = "Luftkylning";
                translateAirFilterPerformance = "Luftfilter";
                translateManufacturerPerformancePanel = "Tillverkare";
                translateMemoryPerformancePanel = "Minne";


                translateMarketingType[0] = "Radio";
                translateMarketingType[1] = "TV";
                translateMarketingType[2] = "Tidskrift";
                translateMarketingType[3] = "Anslagstavla";
                translateMarketingType[4] = "SMM";
                translateMarketingType[5] = "E-Mail";
            }
            yield break;
        }
    }
    IEnumerator checkTranslate()
    {
        while (true)
        {
            batteryPerformance();
            buyTextCompanys();
            approveStaff();
            marketingPanel();
            pausePanel();
            createPanel();
            batteryPerformance();
            ReleasePanel();
           
            osPanel();
            Debug.Log("Start");
            if (_indexLanguage == 1)
            {
                translateWirelessChargerBattery = "Wireless Charger";
                translateQuickChargeBattery = "Quick Charge";
                translateBatteryPerformancePanel = "BATTERY";
                translateReductionEnergyCons = "Reduction in Energy Consumption";
                translatePowerSupplyPower = "Power Supply Capacity";
                translateScreenHZDisplay = "Screen HZ";
                translateScreenResolutionDisplay = "Screen Resolution";
                translateScreenCoverageDisplay = "Screen Coverage";
                translateRulerLaptop = "Ruler Laptop";
                translateOSLaptop = "OS LAPTOP";
                translateCostLaptop = "Cost Laptop";
                translateHeadphones = "Headphones";
                translateLaptopSleeve = "Laptop Sleeve";
                translateVideocardRelease = "Videocard: ";
                translateWaterCoolingRelease = "Water Cooling: ";
                translateQuickChargeRelease = "Quick Charge: ";
                translateWaterResistanceRelease = "Water Resistance: ";
                translateWirelessChargerRelease = "Wireless Charger: ";
                translateAverageRating = "Average Rating";
                translateFanQuest = " Fans";
                translateOfficeQuest = "Office ";
                translateOfficeQuestLevel = " Level";
                translatePresentBox = "Open Present Box";
                translateBuyCompany = "Buy Company";
                translateEmployees = " Employees";
                translateSurviveCrisis = "Survive the Crisis";
                translateConfirmQuitCreatePanel = "Are you sure you want to quit creating a laptop?";
                translateConfirmNo = "NO";
                translateConfirmYes = "YES";
                translateEnterOSName = "ENTER OS NAME";
                translateStartOpenOS = "OPEN";
                translateOSSecurity = "SECURITY";
                translateOSPerformance = "PERFORMANCE";
                translateOSAnimation = "ANIMATION";
                translateOSOptimization = "OPTIMIZATION";
                translateOSMultitasking = "MULTITASKING";
                translateOSFunctional = "FUNCTIONAL";
                translateOSAutonomy = "AUTONOMY";
                translateOSConvenience = "CONVENIENCE";
            }
            else if (_indexLanguage == 2)
            {
                translateWirelessChargerBattery = "Беспроводная Зарядка";
                translateQuickChargeBattery = "Быстрая Зарядка";
                translateBatteryPerformancePanel = "Батарея";
                translateReductionEnergyCons = "Снижение энергопотребления";
                translatePowerSupplyPower = "Мощность БП";
                translateScreenHZDisplay = "Дисплей HZ";
                translateScreenResolutionDisplay = "Разрешение Экрана";
                translateScreenCoverageDisplay = "Покрытие Дисплея";
                translateRulerLaptop = "Линейка Ноутбука";
                translateOSLaptop = "ОС Ноутбука";
                translateCostLaptop = "Цена Ноутбука";
                translateHeadphones = "Наушники";
                translateLaptopSleeve = "Чехол";
                translateVideocardRelease = "Видеокарта: ";
                translateWaterCoolingRelease = "Водян. Охлаждение: ";
                translateQuickChargeRelease = "Быстрая Зарядка: ";
                translateWaterResistanceRelease = "Водонепроницаемость: ";
                translateWirelessChargerRelease = "Беспр. Зарядка: ";
                translateAverageRating = "Средний Рейтинг";
                translateFanQuest = " Фанатов";
                translateOfficeQuest = "Офис ";
                translateOfficeQuestLevel = " Уровня";
                translatePresentBox = "Открыть Подарок";
                translateBuyCompany = "Купить Компанию";
                translateEmployees = " Сотрудников";
                translateSurviveCrisis = "Пережить Кризис";
                translateConfirmQuitCreatePanel = "Выйти из панели создания ноутбука?";
                translateConfirmNo = "Нет";
                translateConfirmYes = "Да";
                translateEnterOSName = "Введите Название ОС";
                translateStartOpenOS = "Открыть";
                translateOSSecurity = "Безопасность";
                translateOSPerformance = "Производ-сть";
                translateOSAnimation = "Анимации";
                translateOSOptimization = "Оптимизация";
                translateOSMultitasking = "Многозадачность";
                translateOSFunctional = "Функционал";
                translateOSAutonomy = "Автономность";
                translateOSConvenience = "Удобство";
            }
            else
            {
                translateWirelessChargerBattery = "Trådlös laddare";
                translateQuickChargeBattery = "Snabb laddning";
                translateBatteryPerformancePanel = "Batteri";
                translateReductionEnergyCons = "Minskad energiförbrukning";
                translatePowerSupplyPower = "Strömförsörjning Ström";
                translateScreenHZDisplay = "HZ-skärm";
                translateScreenResolutionDisplay = "Skärmupplösning";
                translateScreenCoverageDisplay = "Skärmskydd";
                translateRulerLaptop = "Laptop linjal";
                translateOSLaptop = "Laptop OS";
                translateCostLaptop = "Kostnaden";
                translateHeadphones = "Hörlurar";
                translateLaptopSleeve = "Fall";
                translateVideocardRelease = "Grafikkort: ";
                translateWaterCoolingRelease = "Vattenkylning: ";
                translateQuickChargeRelease = "Snabb laddning: ";
                translateWaterResistanceRelease = "Vattentålighet: ";
                translateWirelessChargerRelease = "Trådlös laddare: ";
                translateAverageRating = "Genomsnittligt betyg";
                translateFanQuest = " Fläktar";
                translateOfficeQuest = "Kontor ";
                translateOfficeQuestLevel = " Nivå";
                translatePresentBox = "Öppen gåva";
                translateBuyCompany = "Köp företag";
                translateEmployees = " Anställda";
                translateSurviveCrisis = "Överleva krisen";
                translateConfirmQuitCreatePanel = "Avsluta panelen för att skapa en bärbar dator?";
                translateConfirmNo = "Nej";
                translateConfirmYes = "Ja";
                translateEnterOSName = "Ange OS-namn";
                translateStartOpenOS = "Öppet";
                translateOSSecurity = "Säkerhet";
                translateOSPerformance = "Prestanda";
                translateOSAnimation = "Animationer";
                translateOSOptimization = "Optimering";
                translateOSMultitasking = "Göra flera saker samtidigt";
                translateOSFunctional = "Funktionell";
                translateOSAutonomy = "Autonomi";
                translateOSConvenience = "bekvämlighet";
            }
            yield break;
        }
    }

    public void activeRusTranslate()
    {
        _indexLanguage = 2;
        PlayerPrefs.SetInt("indexLanguage", _indexLanguage);
        SceneManager.LoadScene(0);
        translateLoadingText = "Загрузка";
    }
    public void activeEngTranslate()
    {
        _indexLanguage = 1;
        PlayerPrefs.SetInt("indexLanguage", _indexLanguage);
        SceneManager.LoadScene(0);
        translateLoadingText = "Loading";
    }

    public void activeSWETranslate()
    {
        _indexLanguage = 3;
        PlayerPrefs.SetInt("indexLanguage", _indexLanguage);
        SceneManager.LoadScene(0);
        translateLoadingText = "Läser in";
    }
}
