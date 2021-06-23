using UnityEngine;
using UnityEngine.UI;

public class WidthScreenCE : MonoBehaviour
{
    [SerializeField] private WidthLaptopUpgrade _widthLaptop;
    [SerializeField] private MainGameMechanics _mainGameMechanics;
    [SerializeField] private CreateLaptop _createLaptop;
    [SerializeField] private LocalizationManager _localizationManager;
    public byte levelWidthLaptop;
    [SerializeField] private Text _textLevelWidthLaptop;

    [Header("Кнопки")]
    [SerializeField] private Button _plusAngleScreen;
    [SerializeField] private Button _minusAngleScreen;

    void Start() { _textLevelWidthLaptop.text = _localizationManager.translateWidthScreenCreate + " | " + levelWidthLaptop; }

    private void OnEnable() { levelWidthLaptop = 1; }

    void Update()
    {
        _textLevelWidthLaptop.text = _localizationManager.translateWidthScreenCreate + " | " + levelWidthLaptop;

        if (levelWidthLaptop == _widthLaptop.levelWidthLaptop)
        {
            if (_widthLaptop.levelWidthLaptop > levelWidthLaptop) { _minusAngleScreen.interactable = false; _plusAngleScreen.interactable = true; }
            else
            {
                if (levelWidthLaptop != 1) { _minusAngleScreen.interactable = true; _plusAngleScreen.interactable = false; }
                else { _minusAngleScreen.interactable = false; _plusAngleScreen.interactable = false; }
            }
        }

        else if (_widthLaptop.levelWidthLaptop > levelWidthLaptop)
        {
            if (levelWidthLaptop != 1) { _minusAngleScreen.interactable = true; _plusAngleScreen.interactable = true; }
            else { _minusAngleScreen.interactable = false; _plusAngleScreen.interactable = true; }
        }
        if (levelWidthLaptop == 8) { _plusAngleScreen.interactable = false; _minusAngleScreen.interactable = true; }
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
