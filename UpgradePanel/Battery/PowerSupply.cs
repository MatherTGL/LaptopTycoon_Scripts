using UnityEngine;
using UnityEngine.UI;

public class PowerSupply : MonoBehaviour
{
    [SerializeField] private MainGameMechanics _mainGameMechanics;
    [SerializeField] private LocalizationManager _localizationManager;

    [SerializeField] private byte _costPowerSupply;
    [SerializeField] private Text _textCostPowerSupply;
    public byte levelPowerSupply;
    [SerializeField] private Text _textLevelPowerSupply;

    void Start()
    {
        if (PlayerPrefs.HasKey("levelPowerSupply")) { levelPowerSupply = (byte)PlayerPrefs.GetInt("levelPowerSupply"); }          
    }

    private void Update()
    {
        if (levelPowerSupply != 8)
        {
            _textCostPowerSupply.text = "RP " + _costPowerSupply;
            _textLevelPowerSupply.text = _localizationManager.translateMarketingLevel + " " + levelPowerSupply;
        }
        else
        {
            _textLevelPowerSupply.enabled = false;
            _textCostPowerSupply.text = "Max";
            _textCostPowerSupply.color = new Color(255, 255, 255);
        }
    }

    public void PowerSupplyButton()
    {
        if (_mainGameMechanics.RecearchPoint >= _costPowerSupply)
        {
            if (levelPowerSupply != 8)
            {
                _mainGameMechanics.RecearchPoint -= _costPowerSupply;
                levelPowerSupply++;
                PlayerPrefs.SetInt("levelPowerSupply", levelPowerSupply);
            }
        }
    }
}
