using UnityEngine;
using UnityEngine.UI;

public class WirelessCharger : MonoBehaviour
{
    [SerializeField] private MainGameMechanics _mainGameMechanics;
    [SerializeField] private OpenOS _openOS;
    [SerializeField] private LocalizationManager _localizationManager;

    [SerializeField] private byte _costWirelessCharger;
    [SerializeField] private Text _textCost;
    public byte levelWirelessCharger;
    [SerializeField] private Text _textLevelWirelessCharger;

    [Header("Toggle wirelessCharger")]
    public Toggle addWirelessCharger;

    void Start()
    {
        if(PlayerPrefs.HasKey("levelWirelessCharger"))
        {
            levelWirelessCharger = (byte)PlayerPrefs.GetInt("levelWirelessCharger");
            _textLevelWirelessCharger.enabled = false;
            _textCost.color = _openOS._colorOpenOSUpgrade;
            addWirelessCharger.interactable = true;
        }
    }

    private void Update()
    {
        if (levelWirelessCharger == 1)
        {
            if (_localizationManager._indexLanguage == 1) { _textCost.text = "Unlock"; }
            else if (_localizationManager._indexLanguage == 2) { _textCost.text = "Открыто"; }
            else { _textCost.text = "Öppet"; }
        }
        else 
        {
            if (_localizationManager._indexLanguage == 1) { _textLevelWirelessCharger.text = "Lock"; }
            else if (_localizationManager._indexLanguage == 2) { _textLevelWirelessCharger.text = "Закрыто"; }
            else { _textLevelWirelessCharger.text = "Stängd"; }
        }
    }

    public void wirelessChargerButton()
    {
        if (levelWirelessCharger != 1)
        {
            if (_mainGameMechanics.RecearchPoint >= _costWirelessCharger)
            {
                levelWirelessCharger++;
                _mainGameMechanics.RecearchPoint -= _costWirelessCharger;
                _textLevelWirelessCharger.enabled = false;
                if (_localizationManager._indexLanguage == 1) { _textCost.text = "Unlock"; }
                else if (_localizationManager._indexLanguage == 2) { _textCost.text = "Открыто"; }
                else { _textCost.text = "Öppet"; }
                _textCost.color = _openOS._colorOpenOSUpgrade;
                addWirelessCharger.interactable = true;
                PlayerPrefs.SetInt("levelWirelessCharger", levelWirelessCharger);
            }
        }
    }
}
