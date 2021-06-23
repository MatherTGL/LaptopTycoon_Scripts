using UnityEngine;
using UnityEngine.UI;

public class AirFilter : MonoBehaviour
{
    [SerializeField] private MainGameMechanics _mainGameMechanics;
    [SerializeField] private LocalizationManager _localizationManager;

    [SerializeField] private byte _costAirFilter;
    [SerializeField] private Text _textCostAirFilter;
    public byte levelAirFilter;
    [SerializeField] private Text _textLevelAirFilter;

    void Start() { if (PlayerPrefs.HasKey("levelAirFilter")) { levelAirFilter = (byte)PlayerPrefs.GetInt("levelAirFilter"); } }

    private void Update()
    {
        if (levelAirFilter != 8)
        {
            _textCostAirFilter.text = "RP " + _costAirFilter;
            _textLevelAirFilter.text = _localizationManager.translateMarketingLevel + " " + levelAirFilter;
        }
        else
        {
            _textCostAirFilter.text = "Max";
            _textCostAirFilter.color = new Color(255, 255, 255);
            _textLevelAirFilter.enabled = false;
        }
    }

    public void airFilterButton()
    {
        if (_mainGameMechanics.RecearchPoint >= _costAirFilter)
        {
            if (levelAirFilter != 8)
            {
                _mainGameMechanics.RecearchPoint -= _costAirFilter;
                levelAirFilter++;
                PlayerPrefs.SetInt("levelAirFilter", levelAirFilter);
            }
        }
    }
}
