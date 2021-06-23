using UnityEngine;
using UnityEngine.UI;

public class WaterCooling : MonoBehaviour
{
    [SerializeField] private MainGameMechanics _mainGameMechanics;
    [SerializeField] private LocalizationManager _localizationManager;

    [SerializeField] private byte _costWaterCooling;
    [SerializeField] private Text _textCostWaterCooling;
    public byte levelWaterCooling;
    [SerializeField] private Text _textLevelWaterCooling;

    public Toggle addWaterCooling;

    void Start()
    {
        if (PlayerPrefs.HasKey("waterCooling"))
        {
            _textCostWaterCooling.color = new Color(255, 255, 255);
            levelWaterCooling = (byte)PlayerPrefs.GetInt("waterCooling");
            addWaterCooling.interactable = true;
        }          
    }
    private void Update()
    {
        if (levelWaterCooling != 0)
        {
            _textCostWaterCooling.text = "RP " + _costWaterCooling;
            _textLevelWaterCooling.text = _localizationManager.translateMarketingLevel + " " + levelWaterCooling;
        }
        if (levelWaterCooling >= 8)
        {
            _textLevelWaterCooling.enabled = false;
            _textCostWaterCooling.text = "Max";
            _textCostWaterCooling.color = new Color(255, 255, 255);
        }
    }

    public void waterCoolingUpgradeButton()
    {
        if (_mainGameMechanics.RecearchPoint >= _costWaterCooling)
        {
            if (levelWaterCooling != 8)
            {
                addWaterCooling.interactable = true;
                _mainGameMechanics.RecearchPoint -= _costWaterCooling;
                levelWaterCooling++;
                PlayerPrefs.SetInt("waterCooling", levelWaterCooling);
            }      
        }
    }
}
