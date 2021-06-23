using UnityEngine;
using UnityEngine.UI;


public class ThicknessCE : MonoBehaviour
{
    [SerializeField] private ThicknessLaptop _thicknessLaptop;
    [SerializeField] private MainGameMechanics _mainGameMechanics;
    [SerializeField] private CreateLaptop _createLaptop;
    [SerializeField] private LocalizationManager _localizationManager;
    public byte levelThicknessLaptop;
    [SerializeField] private Text _textLevelThicknessLaptop;

    [Header("Кнопки")]
    [SerializeField] private Button _plusThicknessLaptop;
    [SerializeField] private Button _minusThicknessLaptop;

    void Start() { _textLevelThicknessLaptop.text = _localizationManager.translateThicknessLaptopCreate + " | " + levelThicknessLaptop; }

    private void OnEnable() { levelThicknessLaptop = 1; }

    void Update()
    {
        _textLevelThicknessLaptop.text = _localizationManager.translateThicknessLaptopCreate + " | " + levelThicknessLaptop;

        if (levelThicknessLaptop == _thicknessLaptop.levelThicknessLaptop)
        {
            if (_thicknessLaptop.levelThicknessLaptop > levelThicknessLaptop)
            {
                _minusThicknessLaptop.interactable = false;
                _plusThicknessLaptop.interactable = true;
            }
            else
            {
                if (levelThicknessLaptop != 1) { _minusThicknessLaptop.interactable = true; _plusThicknessLaptop.interactable = false; }
                else { _minusThicknessLaptop.interactable = false; _plusThicknessLaptop.interactable = false; }
            }
        }

        else if (_thicknessLaptop.levelThicknessLaptop > levelThicknessLaptop)
        {
            if (levelThicknessLaptop != 1) { _minusThicknessLaptop.interactable = true; _plusThicknessLaptop.interactable = true; }
            else { _minusThicknessLaptop.interactable = false; _plusThicknessLaptop.interactable = true; }
        }
        if (levelThicknessLaptop == 8) { _plusThicknessLaptop.interactable = false; _minusThicknessLaptop.interactable = true; }
    }

    public void plusThicknessLaptopButton()
    {
        if (_thicknessLaptop.levelThicknessLaptop > levelThicknessLaptop)
        {
            levelThicknessLaptop++;
            _mainGameMechanics.FullZeroCostLaptop += 5;
            _createLaptop.scoreRatingAverage += 5;
        }
    }

    public void minesThicknessLaptopButton()
    {
        if (levelThicknessLaptop != 1)
        {
            levelThicknessLaptop--;
            _mainGameMechanics.FullZeroCostLaptop -= 5;
            _createLaptop.scoreRatingAverage -= 5;
        }
    }
}
