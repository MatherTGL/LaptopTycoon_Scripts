using UnityEngine;
using UnityEngine.UI;

public class videocardData : MonoBehaviour
{
    [SerializeField] private MainGameMechanics _mainGameMechanics;
    [SerializeField] private CreateLaptop _createLaptop;
    [SerializeField] private WaterCooling _waterCooling;
    [SerializeField] private CoolingLaptopUpgrade _coolingLaptopUpgrade;
    [SerializeField] private GameObject _defaultVideocardObject;
    [SerializeField] private VideocardManager _videocardManager;
    [SerializeField] private CostSliderSettings _costSliderSettings;
    [SerializeField] private checkFpsTestGames _checkFpsTestGames;

    public string nameVideocard;
    [SerializeField] private byte _memoryVideocard;
    [SerializeField] private byte _defaultMemory;
    [SerializeField] private byte _maxMemoryVideocard;
    [SerializeField] private byte _coresVideocard;
    [SerializeField] private byte _maxCoresVideocard;
    [SerializeField] private byte _defaultCoresVideocard;
    [SerializeField] private Text _textMemoryVideocard;
    [SerializeField] private Text _textCoresVideocard;
    public byte coolingRequired;
    public byte airCoolingLevel;
    public Toggle overclockingToggle;
    public Toggle sliToggle;
    [SerializeField] private Toggle _checkActiveWaterCooling;

    [Header("Баллы мощности")]
    public int performanceVideocard;
    public int powerVideocard;

    [Header("Кнопка продолжить")]
    [SerializeField] private Button _buttonVideocard;

    [Header("Кнопки")]
    [SerializeField] private Button _minusMemoryButton;
    [SerializeField] private Button _plusMemoryButton;

    [SerializeField] private Button _minusCoresButton;
    [SerializeField] private Button _plusCoresButton;

    void Start() { sliToggle.isOn = false; overclockingToggle.isOn = false; }

    private void OnEnable()
    {
        if (nameVideocard == "RX550") { _defaultVideocardObject.SetActive(true); }     
        else { _defaultVideocardObject.SetActive(false); }

        airCoolingLevel = _coolingLaptopUpgrade.levelCooling;

        sliToggle.isOn = false;
        overclockingToggle.isOn = false;
        _coresVideocard = 1;
        _memoryVideocard = _defaultMemory;

        if (_createLaptop.checkActiveWaterCooling == true) { sliToggle.interactable = true; }
        else { sliToggle.interactable = false; }

        if (_coolingLaptopUpgrade.levelCooling >= 3) { overclockingToggle.interactable = true; }
        else { overclockingToggle.interactable = false; }
    }

    public void boxPanelButton()
    {
        if (nameVideocard != "")
        {
            if (airCoolingLevel >= coolingRequired)
            {
                _createLaptop.checkPanelActiveCL = false;
                _costSliderSettings.costSliderLaptop.minValue = _mainGameMechanics.FullZeroCostLaptop + 100;
                _costSliderSettings.costSliderLaptop.maxValue = _costSliderSettings.costSliderLaptop.minValue * 1.5f;
                _createLaptop.videocardLaptopPanel.SetActive(false);
                _createLaptop.costPanelCreateLaptop.SetActive(true);
                _createLaptop.textCreatePanel.text = "COST"; //Меняем текст на Create     
            }
        }
    }

    public void sliToggleButton()
    {
        if (_waterCooling.levelWaterCooling > 0)
        {
            if (_createLaptop.checkActiveWaterCooling == true)
            {
                sliToggle.interactable = true;

                if (sliToggle.isOn == false)
                {
                    _checkFpsTestGames.checkActiveSli = 0;
                    performanceVideocard /= 2;
                    powerVideocard /= 2;
                    _videocardManager.performanceSlider.maxValue /= 2;
                    _mainGameMechanics.FullZeroCostLaptop -= 50;
                }
                if (sliToggle.isOn == true)
                {
                    _checkFpsTestGames.checkActiveSli = 1;
                    performanceVideocard *= 2;
                    powerVideocard *= 2;
                    _videocardManager.performanceSlider.maxValue *= 2;
                    _mainGameMechanics.FullZeroCostLaptop += 50;
                }
            }
            else { sliToggle.interactable = false; }
        }
        else { sliToggle.interactable = false; }
    }

    public void overclockToggleButton()
    {
        if (_coolingLaptopUpgrade.levelCooling >= 3)
        {
            if (overclockingToggle.isOn == false)
            {
                performanceVideocard = (int)(performanceVideocard / 1.1f);
                _mainGameMechanics.FullZeroCostLaptop -= 10;
            }
            if (overclockingToggle.isOn == true)
            {
                performanceVideocard = (int)(performanceVideocard * 1.1f);
                _mainGameMechanics.FullZeroCostLaptop += 10;
            }
        }
    }

    void Update()
    {
        _textCoresVideocard.text = _coresVideocard.ToString();
        _textMemoryVideocard.text = _memoryVideocard + " GB";
        if (nameVideocard != "")
        {
            if (_defaultVideocardObject.activeSelf)
            {
                if (coolingRequired > airCoolingLevel) { _buttonVideocard.interactable = false; }
                else { _buttonVideocard.interactable = true; }              

                _videocardManager.performanceSlider.value = performanceVideocard;
                _videocardManager.powerSlider.value = powerVideocard;
                if (_memoryVideocard == _defaultMemory)
                {
                    if (_memoryVideocard != _maxMemoryVideocard) { _minusMemoryButton.interactable = false; _plusMemoryButton.interactable = true; }
                }
                else if (_memoryVideocard == _maxMemoryVideocard) { _minusMemoryButton.interactable = true; _plusMemoryButton.interactable = false; }
                
                if (_coresVideocard == _defaultCoresVideocard) { _minusCoresButton.interactable = false; _plusCoresButton.interactable = true; }
                else if (_coresVideocard == _maxCoresVideocard) { _minusCoresButton.interactable = true; _plusCoresButton.interactable = false; }
                else { _minusCoresButton.interactable = true; _plusCoresButton.interactable = true; }
            }    
        }       
    }

    public void plusMemoryButton()
    {
        if (_maxMemoryVideocard > _memoryVideocard)
        {
            _memoryVideocard *= 2;
            _mainGameMechanics.FullZeroCostLaptop += 10;
            _createLaptop.scoreRatingAverage += 5;
        }
    }

    public void minusMemoryButton()
    {
        if (_memoryVideocard > _defaultMemory)
        {
            _memoryVideocard /= 2;
            _mainGameMechanics.FullZeroCostLaptop -= 10;
            _createLaptop.scoreRatingAverage -= 5;
        }
    }

    public void plusCoresButton()
    {
        if (_maxCoresVideocard > _coresVideocard)
        {
            performanceVideocard = (int)(performanceVideocard * 1.1f);
            _mainGameMechanics.FullZeroCostLaptop += 20;
            _createLaptop.scoreRatingAverage += 10;
            _coresVideocard += 1;
        }
    }

    public void minusCoresButton()
    {
        if (_coresVideocard > _defaultCoresVideocard)
        {
            performanceVideocard = (int)(performanceVideocard / 1.1f);
            _mainGameMechanics.FullZeroCostLaptop -= 20;
            _createLaptop.scoreRatingAverage -= 10;
            _coresVideocard -= 1;
        }
    }
}
