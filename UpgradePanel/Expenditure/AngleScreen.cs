using UnityEngine;
using UnityEngine.UI;

public class AngleScreen : MonoBehaviour
{
    [SerializeField] private MainGameMechanics _mainGameMechanics;
    [SerializeField] private LocalizationManager _localizationManager;

    [SerializeField] private byte _costAngleScreen;
    [SerializeField] private Text _textCostAngleScreen;
    public byte levelAngleScreen;
    [SerializeField] private Text _textLevelAngleScreen;

    void Start()
    {
        if (PlayerPrefs.HasKey("levelAngleScreen")) { levelAngleScreen = (byte)PlayerPrefs.GetInt("levelAngleScreen"); }
        _textLevelAngleScreen.text = _localizationManager.translateMarketingLevel + " " + levelAngleScreen;
    }

    void OnEnable()
    {
        if (levelAngleScreen != 8)
        {
            _textCostAngleScreen.text = "RP " + _costAngleScreen;
            _textLevelAngleScreen.text = _localizationManager.translateMarketingLevel + " " + levelAngleScreen;
        }
        else
        {
            _textCostAngleScreen.text = "Max";
            _textCostAngleScreen.color = new Color(255, 255, 255);
            _textLevelAngleScreen.enabled = false;
        }
    }

    public void AngleScreenLaptopButton()
    {
        if (_mainGameMechanics.RecearchPoint >= _costAngleScreen)
        {
            if (levelAngleScreen != 8)
            {
                _mainGameMechanics.RecearchPoint -= _costAngleScreen;
                levelAngleScreen++;
                PlayerPrefs.SetInt("levelAngleScreen", levelAngleScreen);
            }
        }

        if (levelAngleScreen != 8)
        {
            _textCostAngleScreen.text = "RP " + _costAngleScreen;
            _textLevelAngleScreen.text = _localizationManager.translateMarketingLevel + " " + levelAngleScreen;
        }
        else
        {
            _textCostAngleScreen.text = "Max";
            _textCostAngleScreen.color = new Color(255, 255, 255);
            _textLevelAngleScreen.enabled = false;
        }
    }
}
