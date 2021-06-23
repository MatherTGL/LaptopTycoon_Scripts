using UnityEngine;
using UnityEngine.UI;

public class WidthLaptopCP : MonoBehaviour
{
    [SerializeField] private WidthLaptopUpgrade _widthLaptop;
    [SerializeField] private MainGameMechanics _mainGameMechanics;
    [SerializeField] private CreateLaptop _createLaptop;
    [SerializeField] private LocalizationManager _localizationManager;
    public byte levelWidthLaptop;
    [SerializeField] private Text _textLevelWidthLaptop;

    [Header("Кнопки")]
    [SerializeField] private Button _plusWidthLaptop;
    [SerializeField] private Button _minusWidthLaptop;

    void Start() { _textLevelWidthLaptop.text = _localizationManager.translateWidthLaptopCreate + " | " + levelWidthLaptop; }

    private void OnEnable() { levelWidthLaptop = 1; }

    void Update()
    {
        _textLevelWidthLaptop.text = _localizationManager.translateWidthLaptopCreate + " | " + levelWidthLaptop;

        if (levelWidthLaptop == _widthLaptop.levelWidthLaptop)
        {
            if (_widthLaptop.levelWidthLaptop > levelWidthLaptop) { _minusWidthLaptop.interactable = false; _plusWidthLaptop.interactable = true; }
            else
            {
                if (levelWidthLaptop != 1) { _minusWidthLaptop.interactable = true; _plusWidthLaptop.interactable = false; }
                else { _minusWidthLaptop.interactable = false; _plusWidthLaptop.interactable = false; }
            }
        }

        else if (_widthLaptop.levelWidthLaptop > levelWidthLaptop)
        {
            if (levelWidthLaptop != 1) { _minusWidthLaptop.interactable = true; _plusWidthLaptop.interactable = true; }
            else { _minusWidthLaptop.interactable = false; _plusWidthLaptop.interactable = true; }
        }
        if (levelWidthLaptop == 8) { _plusWidthLaptop.interactable = false; _minusWidthLaptop.interactable = true; }
    }

    public void plusWidthLaptopButton()
    {
        if (_widthLaptop.levelWidthLaptop > levelWidthLaptop)
        {
            levelWidthLaptop++;
            _mainGameMechanics.FullZeroCostLaptop += 5;
            _createLaptop.scoreRatingAverage += 5;
        }
    }

    public void minesWidthLaptopButton()
    {
        if (levelWidthLaptop != 1)
        {
            levelWidthLaptop--;
            _mainGameMechanics.FullZeroCostLaptop -= 5;
            _createLaptop.scoreRatingAverage -= 5;
        }           
    }
}
