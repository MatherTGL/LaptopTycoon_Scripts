using UnityEngine;
using UnityEngine.UI;

public class WaterResistant : MonoBehaviour
{
    [SerializeField] private MainGameMechanics _mainGameMechanics;
    [SerializeField] private OpenOS _openOS;
    [SerializeField] private LocalizationManager _localizationManager;

    public byte levelWaterResistance;
    [SerializeField] private byte _costWaterResistance;
    [SerializeField] private Text _textLevelWaterResistance;
    [SerializeField] private Text _textCostWaterResistance;

    public Toggle addWaterResistance;

    void Start()
    {
        if (PlayerPrefs.HasKey("WaterResistanceUnlock"))
        {
            levelWaterResistance = (byte)PlayerPrefs.GetInt("WaterResistanceUnlock");
            addWaterResistance.interactable = true;

            if (levelWaterResistance != 1)
            {
                if (_localizationManager._indexLanguage == 1) { _textLevelWaterResistance.text = "Lock"; }
                else if (_localizationManager._indexLanguage == 2) { _textLevelWaterResistance.text = "Закрыто"; }
                else { _textLevelWaterResistance.text = "Stängd"; }
                _textCostWaterResistance.text = "RP " + _costWaterResistance;
            }
            else
            {
                if (_localizationManager._indexLanguage == 1) { _textCostWaterResistance.text = "Unlock"; }
                else if (_localizationManager._indexLanguage == 2) { _textCostWaterResistance.text = "Открыто"; }
                else { _textCostWaterResistance.text = "Öppet"; }
                _textLevelWaterResistance.enabled = false;
                _textCostWaterResistance.color = _openOS._colorOpenOSUpgrade;
            }
        }        
    }

    private void Update()
    {
        if (levelWaterResistance != 1)
        {
            if (_localizationManager._indexLanguage == 1) { _textLevelWaterResistance.text = "Lock"; }
            else if (_localizationManager._indexLanguage == 2) { _textLevelWaterResistance.text = "Закрыто"; }
            else { _textLevelWaterResistance.text = "Stängd"; }
            _textCostWaterResistance.text = "RP " + _costWaterResistance;
        }
        else
        {
            _textLevelWaterResistance.enabled = false;
            if (_localizationManager._indexLanguage == 1) { _textCostWaterResistance.text = "Unlock"; }
            else if (_localizationManager._indexLanguage == 2) { _textCostWaterResistance.text = "Открыто"; }
            else { _textCostWaterResistance.text = "Öppet"; }
            _textCostWaterResistance.color = _openOS._colorOpenOSUpgrade;
        }
    }

    public void upgradeWaterResistance()
    {
        if (_mainGameMechanics.RecearchPoint >= _costWaterResistance)
        {
            if (levelWaterResistance != 1)
            {
                addWaterResistance.interactable = true;
                _mainGameMechanics.RecearchPoint -= _costWaterResistance;
                levelWaterResistance++;
                PlayerPrefs.SetInt("WaterResistanceUnlock", levelWaterResistance);
            }
        }
    }
}
