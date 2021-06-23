using UnityEngine;
using UnityEngine.UI;

public class MemoryUpgrade : MonoBehaviour
{
    [Header("Доступ к скриптам")]
    [SerializeField] private CreateLaptop _createLaptop;
    [SerializeField] private MainGameMechanics _mainGameMechanics;
    [SerializeField] private LocalizationManager _localizationManager;

    [Header("Название памяти")]
    [SerializeField] private string _nameMemory;
    [Header("Уровень памяти")]
    public byte levelMemory;
    public byte currentLevelMemory;
    [SerializeField] private byte _maxLevelMemory;
    [SerializeField] private Text _levelTextMemory;
    [Header("Цена за улучшение")]
    [SerializeField] private byte _costMemory;
    [SerializeField] private Text _textCostMemory;

    public Text textCurrentRAMLaptop;
    public Text textCurrentROMLaptop;

    [Header("Кнопки ROM")]
    [SerializeField] private Image _plusButtonROM;
    [SerializeField] private Image _minusButtonROM;

    [Header("Кнопки RAM")]
    [SerializeField] private Image _plusButtonRAM;
    [SerializeField] private Image _minusButtonRAM;

    [SerializeField] private Color _deactiveMemory;
    [SerializeField] private Color _activeMemory;

    private void Awake()
    {
        _levelTextMemory.text = _localizationManager.translateMarketingLevel + " " + levelMemory.ToString();
        if (_nameMemory == "ROM")
        {
            if (PlayerPrefs.HasKey("levelROMSave"))
            {
                levelMemory = (byte)PlayerPrefs.GetInt("levelROMSave");
                _createLaptop.maxROMLaptop = (ushort)PlayerPrefs.GetInt("maxROMSave");
            }
        }
        if (_nameMemory == "RAM")
        {
            if (PlayerPrefs.HasKey("levelRAMSave"))
            {
                levelMemory = (byte)PlayerPrefs.GetInt("levelRAMSave");
                _createLaptop.maxRAMLaptop = (short)PlayerPrefs.GetInt("maxRAMSave");
            }
        }
    }

    public void MinusButtonMemoryCheck()
    {
        if (_nameMemory != "") { if (currentLevelMemory != 1) { currentLevelMemory--; _createLaptop.scoreRatingAverage -= 5; } }
    }

    public void PlusButtonMemoryCheck()
    {
        if (_nameMemory != "") { if (levelMemory > currentLevelMemory) { currentLevelMemory++; _createLaptop.scoreRatingAverage += 5; } }
    }

    public void returnDefaultMemory()
    {
        if (_nameMemory != "")
        {
            currentLevelMemory = 1;
            _createLaptop.currentRAMLaptop = 4;
            _createLaptop.currentROMLaptop = 64;
        }
    }

    private void Update()
    {

        _levelTextMemory.text = _localizationManager.translateMarketingLevel + " " + levelMemory.ToString();
        if (_nameMemory != "")
        {
            if (levelMemory >= _maxLevelMemory)
            {
                _levelTextMemory.enabled = false;
                _textCostMemory.text = "Max";
                _textCostMemory.color = new Color(255, 255, 255);
            }

            if (_nameMemory == "ROM")
            {
                if (levelMemory == 1)
                {
                    if (currentLevelMemory == 1) { _minusButtonROM.color = _deactiveMemory; _plusButtonROM.color = _deactiveMemory; }
                }
                else
                {
                    if (currentLevelMemory > 1 | currentLevelMemory < levelMemory) { _minusButtonROM.color = _activeMemory; _plusButtonROM.color = _activeMemory; }
                    if (currentLevelMemory == levelMemory) { _minusButtonROM.color = _activeMemory; _plusButtonROM.color = _deactiveMemory; }
                    if (currentLevelMemory == 1) { _minusButtonROM.color = _deactiveMemory; _plusButtonROM.color = _activeMemory; }
                }               
            }
            if (_nameMemory == "RAM")
            {
                if (levelMemory == 1) { if (currentLevelMemory == 1) { _minusButtonRAM.color = _deactiveMemory; _plusButtonRAM.color = _deactiveMemory; } }
                else
                {
                    if (currentLevelMemory > 1 | currentLevelMemory < levelMemory) { _minusButtonRAM.color = _activeMemory; _plusButtonRAM.color = _activeMemory; }
                    if (currentLevelMemory == levelMemory) { _minusButtonRAM.color = _activeMemory; _plusButtonRAM.color = _deactiveMemory; }
                    if (currentLevelMemory == 1) { _minusButtonRAM.color = _deactiveMemory; _plusButtonRAM.color = _activeMemory; }
                }
            }
        }
    }

    public void upgradeMemory()
    {
        if (_mainGameMechanics.RecearchPoint >= _costMemory)
        {
            if (_nameMemory == "RAM")
            {
                if (levelMemory < _maxLevelMemory)
                {
                    levelMemory++;
                    _mainGameMechanics.RecearchPoint -= _costMemory;
                    _createLaptop.maxRAMLaptop *= 2;
                    _levelTextMemory.text = _localizationManager.translateMarketingLevel + " " + levelMemory.ToString();
                    PlayerPrefs.SetInt("maxRAMSave", _createLaptop.maxRAMLaptop);
                    PlayerPrefs.SetInt("levelRAMSave", levelMemory);
                }
            }
            if (_nameMemory == "ROM")
            {
                if (levelMemory < _maxLevelMemory)
                {
                    levelMemory++;
                    _mainGameMechanics.RecearchPoint -= _costMemory;
                    _createLaptop.maxROMLaptop *= 2;
                    _levelTextMemory.text = _localizationManager.translateMarketingLevel + " " + levelMemory.ToString();
                    PlayerPrefs.SetInt("maxROMSave", _createLaptop.maxROMLaptop);
                    PlayerPrefs.SetInt("levelROMSave", levelMemory);
                }
            }
        }
    }
}
