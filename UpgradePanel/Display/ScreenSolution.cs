using UnityEngine;
using UnityEngine.UI;

public class ScreenSolution : MonoBehaviour
{
    [SerializeField] private MainGameMechanics _mainGameMechanics;
    [SerializeField] private LocalizationManager _localizationManager;
    [SerializeField] private CreateLaptop _createLaptop;
    [SerializeField] private FunctionPanelButton _functionPanelButton;
    [SerializeField] private resolutionTextManager _resolutionTextManager;
    [SerializeField] private ReleasePanelLaptop _releasePanelLaptop;

    [SerializeField] private byte _costScreenSolution;
    [SerializeField] private Text _textCostScreenSolution;
    public byte levelScreenSolution;
    [SerializeField] private Text _textLevelScreenSolution;
    public string displayString;
    public byte checkResolution;
    public int costOption; //Цена какой-то опции
    public int display;
    public byte _levelRequired;

    [SerializeField] private Image _leftButtonResolutionImage;
    [SerializeField] private Image _rightButtonResolutionImage;

    public Color _textColor;
    public Text _textColorDeactive;
    public Color deactiveButtonColor;

    void Start()
    {
        if (PlayerPrefs.HasKey("levelScreenSolution")) { levelScreenSolution = (byte)PlayerPrefs.GetInt("levelScreenSolution"); }
        displayString = "FHD";
        checkResolution = 1;
    }

    private void Update()
    {
        if (_functionPanelButton.CreateLaptopPanel.activeSelf) { ConclusionResolutionScreen(); }
        if (checkResolution == 1)
        {
            if (levelScreenSolution == 1) { _rightButtonResolutionImage.color = deactiveButtonColor; _leftButtonResolutionImage.color = deactiveButtonColor; }
            else { _leftButtonResolutionImage.color = deactiveButtonColor; _rightButtonResolutionImage.color = _textColor; }
        }
        else if (checkResolution == 6) { _leftButtonResolutionImage.color = _textColor; _rightButtonResolutionImage.color = deactiveButtonColor; }
        else
        {
            if (checkResolution != levelScreenSolution) { _leftButtonResolutionImage.color = _textColor; _rightButtonResolutionImage.color = _textColor; }
            else { _leftButtonResolutionImage.color = _textColor; _rightButtonResolutionImage.color = deactiveButtonColor; }
        }

        _mainGameMechanics.textCostOption.text = "$ " + _mainGameMechanics.FullZeroCostLaptop;


        if (levelScreenSolution != 8)
        {
            _textCostScreenSolution.text = "RP " + _costScreenSolution;
            _textLevelScreenSolution.text = _localizationManager.translateMarketingLevel + " " + levelScreenSolution;
        }
        else
        {
            _textCostScreenSolution.text = "Max";
            _textCostScreenSolution.color = new Color(255, 255, 255);
            _textLevelScreenSolution.enabled = false;
        }
    }

    public void returnDefaultResolution() { checkResolution = 1; displayString = "FHD"; display = 19201080; _resolutionTextManager.checkResolutionNumber = 1; }

    public void ConclusionResolutionScreen()
    {
        if (checkResolution == 1)
        {
            displayString = "FHD";
            display = 19201080;
            _textColorDeactive.text = "FHD | 1920 x 1080";
            _mainGameMechanics.imageDisplay[0].enabled = true;
            _mainGameMechanics.imageDisplay[1].enabled = false;
            _mainGameMechanics.imageDisplay[2].enabled = false;
            _mainGameMechanics.imageDisplay[3].enabled = false;
            _mainGameMechanics.imageDisplay[4].enabled = false;
            _mainGameMechanics.imageDisplay[5].enabled = false;
        }
        if (checkResolution == 2)
        {
            displayString = "QHD";
            display = 25601440;
            _textColorDeactive.text = "QHD | 2560 x 1440";
            _mainGameMechanics.imageDisplay[0].enabled = false;
            _mainGameMechanics.imageDisplay[1].enabled = true;
            _mainGameMechanics.imageDisplay[2].enabled = false;
            _mainGameMechanics.imageDisplay[3].enabled = false;
            _mainGameMechanics.imageDisplay[4].enabled = false;
            _mainGameMechanics.imageDisplay[5].enabled = false;
        }
        if (checkResolution == 3)
        {
            displayString = "4K";
            display = 38402160;
            _textColorDeactive.text = "4K | 3840 × 2160";
            _mainGameMechanics.imageDisplay[0].enabled = false;
            _mainGameMechanics.imageDisplay[1].enabled = false;
            _mainGameMechanics.imageDisplay[2].enabled = true;
            _mainGameMechanics.imageDisplay[3].enabled = false;
            _mainGameMechanics.imageDisplay[4].enabled = false;
            _mainGameMechanics.imageDisplay[5].enabled = false;
        }
        if (checkResolution == 4)
        {
            displayString = "5K";
            display = 51202880;
            _textColorDeactive.text = "5K | 5120 × 2880";
            _mainGameMechanics.imageDisplay[0].enabled = false;
            _mainGameMechanics.imageDisplay[1].enabled = false;
            _mainGameMechanics.imageDisplay[2].enabled = false;
            _mainGameMechanics.imageDisplay[3].enabled = true;
            _mainGameMechanics.imageDisplay[4].enabled = false;
            _mainGameMechanics.imageDisplay[5].enabled = false;
        }
        if (checkResolution == 5)
        {
            displayString = "8K";
            display = 76804320;
            _textColorDeactive.text = "8K | 7680 × 4320";
            _mainGameMechanics.imageDisplay[0].enabled = false;
            _mainGameMechanics.imageDisplay[1].enabled = false;
            _mainGameMechanics.imageDisplay[2].enabled = false;
            _mainGameMechanics.imageDisplay[3].enabled = false;
            _mainGameMechanics.imageDisplay[4].enabled = true;
            _mainGameMechanics.imageDisplay[5].enabled = false;
        }
        if (checkResolution == 6)
        {
            displayString = "10K";
            display = 102405760;
            _textColorDeactive.text = "10K | 10240 × 5760";
            _mainGameMechanics.imageDisplay[0].enabled = false;
            _mainGameMechanics.imageDisplay[1].enabled = false;
            _mainGameMechanics.imageDisplay[2].enabled = false;
            _mainGameMechanics.imageDisplay[3].enabled = false;
            _mainGameMechanics.imageDisplay[4].enabled = false;
            _mainGameMechanics.imageDisplay[5].enabled = true;
        }
    }

    public void plusScreenResolutionButton()
    {
        if (levelScreenSolution > checkResolution)
        {
            checkResolution++;
            costOption += 30;
            _createLaptop.scoreRatingAverage += 15;
            ConclusionResolutionScreen();
            _resolutionTextManager.checkResolutionNumber++;
        }
    }

    public void minusScreenResolutionButton()
    {
        if (checkResolution != 1)
        {
            checkResolution--;
            costOption -= 30;
            _createLaptop.scoreRatingAverage -= 15;
            ConclusionResolutionScreen();
            _resolutionTextManager.checkResolutionNumber--;
        }
    }

    public void ScreenSolutionButton()
    {
        if (_mainGameMechanics.RecearchPoint >= _costScreenSolution)
        {
            if (levelScreenSolution != 8)
            {
                _mainGameMechanics.RecearchPoint -= _costScreenSolution;
                levelScreenSolution++;
                PlayerPrefs.SetInt("levelScreenSolution", levelScreenSolution);
            }
        }
    }
}
