using UnityEngine;
using UnityEngine.UI;

public class TouchpadStyle : MonoBehaviour
{
    [SerializeField] private MainGameMechanics _mainGameMechanics;
    [SerializeField] private LocalizationManager _localizationManager;

    [SerializeField] private byte _costTouchpad;
    [SerializeField] private Text _textCostTouchpad;
    public byte levelTouchpadStyle;
    [SerializeField] private Text _textLevelTouchpadStyle;

    void Start()
    {
        if (PlayerPrefs.HasKey("levelTouchpadStyle")) { levelTouchpadStyle = (byte)PlayerPrefs.GetInt("levelTouchpadStyle"); }
        _textLevelTouchpadStyle.text = _localizationManager.translateMarketingLevel + " " + levelTouchpadStyle;
    }

    void OnEnable()
    {
        if (levelTouchpadStyle != 8)
        {
            _textLevelTouchpadStyle.text = _localizationManager.translateMarketingLevel + " " + levelTouchpadStyle;
            _textCostTouchpad.text = "RP " + _costTouchpad;
        }
        else
        {
            _textCostTouchpad.text = "Max";
            _textCostTouchpad.color = new Color(255, 255, 255);
            _textLevelTouchpadStyle.enabled = false;
        }
    }

    public void TouchpadLaptopButton()
    {
        if (_mainGameMechanics.RecearchPoint >= _costTouchpad)
        {
            if (levelTouchpadStyle != 8)
            {
                levelTouchpadStyle++;
                _mainGameMechanics.RecearchPoint -= _costTouchpad;
                PlayerPrefs.SetInt("levelTouchpadStyle", levelTouchpadStyle);
            }
        }

        if (levelTouchpadStyle != 8)
        {
            _textLevelTouchpadStyle.text = _localizationManager.translateMarketingLevel + " " + levelTouchpadStyle;
            _textCostTouchpad.text = "RP " + _costTouchpad;
        }
        else
        {
            _textCostTouchpad.text = "Max";
            _textCostTouchpad.color = new Color(255, 255, 255);
            _textLevelTouchpadStyle.enabled = false;
        }
    }
}
