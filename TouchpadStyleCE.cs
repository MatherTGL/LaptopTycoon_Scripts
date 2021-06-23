using UnityEngine;
using UnityEngine.UI;

public class TouchpadStyleCE : MonoBehaviour
{
    [SerializeField] private TouchpadStyle _touchpadStyle;
    [SerializeField] private MainGameMechanics _mainGameMechanics;
    [SerializeField] private CreateLaptop _createLaptop;
    [SerializeField] private LocalizationManager _localizationManager;
    public byte levelTouchpadStyle;
    [SerializeField] private Text _textLevelToucpadStyle;

    [Header("Кнопки")]
    [SerializeField] private Button _plusToucpadStyle;
    [SerializeField] private Button _minusToucpadStyle;

    void Start() { _textLevelToucpadStyle.text = _localizationManager.translateTouchpadStyleCreate + " | " + levelTouchpadStyle; }

    private void OnEnable() { levelTouchpadStyle = 1; }

    void Update()
    {
        _textLevelToucpadStyle.text = _localizationManager.translateTouchpadStyleCreate + " | " + levelTouchpadStyle;

        if (levelTouchpadStyle == _touchpadStyle.levelTouchpadStyle)
        {
            if (_touchpadStyle.levelTouchpadStyle > levelTouchpadStyle)
            {
                _minusToucpadStyle.interactable = false;
                _plusToucpadStyle.interactable = true;
            }
            else
            {
                if (levelTouchpadStyle != 1) { _minusToucpadStyle.interactable = true; _plusToucpadStyle.interactable = false; }
                else { _minusToucpadStyle.interactable = false; _plusToucpadStyle.interactable = false; }
            }
        }

        else if (_touchpadStyle.levelTouchpadStyle > levelTouchpadStyle)
        {
            if (levelTouchpadStyle != 1) { _minusToucpadStyle.interactable = true; _plusToucpadStyle.interactable = true; }
            else { _minusToucpadStyle.interactable = false; _plusToucpadStyle.interactable = true; }
        }

        if (levelTouchpadStyle == 8) { _plusToucpadStyle.interactable = false; _minusToucpadStyle.interactable = true; }
    }

    public void plusTouchpadStyleButton()
    {
        if (_touchpadStyle.levelTouchpadStyle > levelTouchpadStyle)
        {
            levelTouchpadStyle++;
            _mainGameMechanics.FullZeroCostLaptop += 5;
            _createLaptop.scoreRatingAverage += 5;
        }
    }

    public void minesTouchpadStyleButton()
    {
        if (levelTouchpadStyle != 1)
        {
            levelTouchpadStyle--;
            _mainGameMechanics.FullZeroCostLaptop -= 5;
            _createLaptop.scoreRatingAverage -= 5;
        }          
    }
}
