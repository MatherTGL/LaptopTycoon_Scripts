using UnityEngine;
using UnityEngine.UI;

public class AerodynamicResistance : MonoBehaviour
{
    [SerializeField] private MainGameMechanics _mainGameMechanics;
    [SerializeField] private LocalizationManager _localizationManager;

    [SerializeField] private byte _costAerodynResistance;
    [SerializeField] private Text _textCostAerodynResistant;
    public byte levelAerodynResistant;
    [SerializeField] private Text _textLevelAerodynResistant;

    void Start()
    {
        if (PlayerPrefs.HasKey("AerodynamicResistanceLevel")) { levelAerodynResistant = (byte)PlayerPrefs.GetInt("AerodynamicResistanceLevel"); }            
    }

    private void Update()
    {
        if (levelAerodynResistant != 8)
        {
            _textCostAerodynResistant.text = "RP " + _costAerodynResistance;
            _textLevelAerodynResistant.text = _localizationManager.translateMarketingLevel + " " + levelAerodynResistant;
        }
        else
        {
            _textCostAerodynResistant.text = "Max";
            _textCostAerodynResistant.color = new Color(255, 255, 255);
            _textLevelAerodynResistant.enabled = false;
        }
    }

    public void AerodynamicResistanceButton()
    {
        if (_mainGameMechanics.RecearchPoint >= _costAerodynResistance)
        {
            if (levelAerodynResistant != 8)
            {
                _mainGameMechanics.RecearchPoint -= _costAerodynResistance;
                levelAerodynResistant++;
                PlayerPrefs.SetInt("AerodynamicResistanceLevel", levelAerodynResistant);
            }
        }
    }
}
