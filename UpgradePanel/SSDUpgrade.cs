using UnityEngine;
using UnityEngine.UI;

public class SSDUpgrade : MonoBehaviour
{
    [Header("Доступы")]
    [SerializeField] private MainGameMechanics _mainGameMechanics;
    [SerializeField] private CreateLaptop _createLaptop;
    [SerializeField] private LocalizationManager _localizationManager;

    [Header("Цена SSD")]
    [SerializeField] private byte _costSSD;
    [SerializeField] private Text _textCostSSD;
    public byte levelSSD;
    public ushort memorySSD;
    [SerializeField] private Text _textLevelSSD;

    [Header("Тоггл добавления SSD")]
    public Toggle addSSDLaptop;

    void Start()
    {
        if (PlayerPrefs.HasKey("levelSSD"))
        {
            levelSSD = (byte)PlayerPrefs.GetInt("levelSSD");
            _costSSD = (byte)PlayerPrefs.GetInt("costSSD");
            memorySSD = (ushort)PlayerPrefs.GetInt("memorySSD");
            _textLevelSSD.color = new Color(255, 255, 255);
            addSSDLaptop.isOn = false;
            addSSDLaptop.interactable = true;
            _textCostSSD.text = "RP " + _costSSD;
            _textLevelSSD.text = _localizationManager.translateMarketingLevel + " " + levelSSD;
        }
        else
        {
            _costSSD = 100;
            _textCostSSD.text = "RP " + _costSSD;
            addSSDLaptop.interactable = false;
            addSSDLaptop.isOn = false;
        }
    }

    private void Update()
    {
        if (levelSSD != 0)
        {
            _textCostSSD.text = "RP " + _costSSD;
            if (addSSDLaptop.isOn == true) { _createLaptop.ssdPanelCreate.SetActive(true); }
            else { _createLaptop.ssdPanelCreate.SetActive(false); }

            _textLevelSSD.text = _localizationManager.translateMarketingLevel + " " + levelSSD;
        }
        else { _textLevelSSD.text = "Lock"; _textCostSSD.text = "RP " + _costSSD; }
        if (levelSSD == 1) { _textCostSSD.text = "RP " + _costSSD; _costSSD = 40; memorySSD = 128; }
        if (levelSSD >= 8) { _textCostSSD.text = "Max"; _textCostSSD.color = new Color(255, 255, 255); _textLevelSSD.enabled = false; }
    }

    public void returnDefaultSSD() { _createLaptop.ssdPanelCreate.SetActive(false); memorySSD = 128; }

    public void upgradeSSDButton()
    {
        if (_mainGameMechanics.RecearchPoint >= _costSSD)
        {
            if (levelSSD != 8)
            {
                levelSSD++;
                _costSSD += 5;
                _mainGameMechanics.RecearchPoint -= _costSSD;
                _textLevelSSD.text = _localizationManager.translateMarketingLevel + " " + levelSSD;
                PlayerPrefs.SetInt("levelSSD", levelSSD);
                PlayerPrefs.SetInt("costSSD", _costSSD);
                PlayerPrefs.SetInt("memorySSD", memorySSD);
                _textLevelSSD.color = new Color(255, 255, 255);
                addSSDLaptop.interactable = true;
                memorySSD *= 2;
            }          
        }

        if (levelSSD != 0)
        {
            _textCostSSD.text = "RP " + _costSSD;
            if (addSSDLaptop.isOn == true) { _createLaptop.ssdPanelCreate.SetActive(true); }
            else { _createLaptop.ssdPanelCreate.SetActive(false); }

            _textLevelSSD.text = _localizationManager.translateMarketingLevel + " " + levelSSD;
        }
        if (levelSSD == 1) { _textCostSSD.text = "RP " + _costSSD; _costSSD = 40; memorySSD = 128; }
        if (levelSSD >= 8) { _textCostSSD.text = "Max"; _textCostSSD.color = new Color(255, 255, 255); _textLevelSSD.enabled = false; }
    }
}
