using UnityEngine;
using UnityEngine.UI;

public class WidthDisplay : MonoBehaviour
{
    [SerializeField] private MainGameMechanics _mainGameMechanics;
    [SerializeField] private LocalizationManager _localizationManager;

    [SerializeField] private byte _costWidthDisplay;
    [SerializeField] private Text _textCostWidthDisplay;
    public byte levelWidthDisplay;
    [SerializeField] private Text _textLevelWidthDisplay;

    void Start()
    {
        if (PlayerPrefs.HasKey("levelWidthDisplay")) { levelWidthDisplay = (byte)PlayerPrefs.GetInt("levelWidthDisplay"); }
        _textLevelWidthDisplay.text = _localizationManager.translateMarketingLevel + " " + levelWidthDisplay;
    }

    void OnEnable()
    {
        if (levelWidthDisplay != 8)
        {
            _textCostWidthDisplay.text = "RP " + _costWidthDisplay;
            _textLevelWidthDisplay.text = _localizationManager.translateMarketingLevel + " " + levelWidthDisplay;
        }
        else
        {
            _textCostWidthDisplay.text = "Max";
            _textCostWidthDisplay.color = new Color(255, 255, 255);
            _textLevelWidthDisplay.enabled = false;
        }
    }


    public void widthDisplayButton()
    {
        if (_mainGameMechanics.RecearchPoint >= _costWidthDisplay)
        {
            if (levelWidthDisplay != 8)
            {
                levelWidthDisplay++;
                _mainGameMechanics.RecearchPoint -= _costWidthDisplay;
                PlayerPrefs.SetInt("levelWidthDisplay", levelWidthDisplay);
            }
        }

        if (levelWidthDisplay != 8)
        {
            _textCostWidthDisplay.text = "RP " + _costWidthDisplay;
            _textLevelWidthDisplay.text = _localizationManager.translateMarketingLevel + " " + levelWidthDisplay;
        }
        else
        {
            _textCostWidthDisplay.text = "Max";
            _textCostWidthDisplay.color = new Color(255, 255, 255);
            _textLevelWidthDisplay.enabled = false;
        }
    }
}
