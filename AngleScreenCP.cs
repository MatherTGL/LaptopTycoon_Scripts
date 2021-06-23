using UnityEngine;
using UnityEngine.UI;

public class AngleScreenCP : MonoBehaviour
{
    [SerializeField] private AngleScreen _AngleScreen;
    [SerializeField] private MainGameMechanics _mainGameMechanics;
    [SerializeField] private LocalizationManager _localizationManager;
    [SerializeField] private CreateLaptop _createLaptop;
    public byte levelAngleScreenPanel;
    [SerializeField] private Text _textLevelAngleScreen;

    [Header("Кнопки")]
    [SerializeField] private Button _plusAngleScreen;
    [SerializeField] private Button _minusAngleScreen;

    void Start() { _textLevelAngleScreen.text = _localizationManager.translateAngleScreenCreate + " | " + levelAngleScreenPanel; }

    private void OnEnable() { levelAngleScreenPanel = 1; }

    void Update()
    {
        _textLevelAngleScreen.text = _localizationManager.translateAngleScreenCreate + " | " + levelAngleScreenPanel;

        if (levelAngleScreenPanel == _AngleScreen.levelAngleScreen)
        {
            if (_AngleScreen.levelAngleScreen > levelAngleScreenPanel) { _minusAngleScreen.interactable = false; _plusAngleScreen.interactable = true; }
            else
            {
                if (levelAngleScreenPanel != 1) { _minusAngleScreen.interactable = true; _plusAngleScreen.interactable = false; }
                else { _minusAngleScreen.interactable = false; _plusAngleScreen.interactable = false; }
            }
        }

        else if (_AngleScreen.levelAngleScreen > levelAngleScreenPanel)
        {
            if (levelAngleScreenPanel != 1) { _minusAngleScreen.interactable = true; _plusAngleScreen.interactable = true; }
            else { _minusAngleScreen.interactable = false; _plusAngleScreen.interactable = true; }
        }

        if (levelAngleScreenPanel == 8) { _plusAngleScreen.interactable = false; _minusAngleScreen.interactable = true; }
    }

    public void plusAngleScreenButton()
    {
        if (_AngleScreen.levelAngleScreen > levelAngleScreenPanel)
        {
            levelAngleScreenPanel++;
            _mainGameMechanics.FullZeroCostLaptop += 5;
            _createLaptop.scoreRatingAverage += 5;
        }          
    }

    public void minesAngleScreenButton()
    {
        if (levelAngleScreenPanel != 1)
        {
            levelAngleScreenPanel--;
            _mainGameMechanics.FullZeroCostLaptop -= 5;
            _createLaptop.scoreRatingAverage -= 5;
        }    
    }
}
