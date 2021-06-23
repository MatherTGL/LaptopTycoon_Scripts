using UnityEngine;
using UnityEngine.UI;

public class CornesLaptopCE : MonoBehaviour
{
    [SerializeField] private CornesLaptop _cornesLaptop;
    [SerializeField] private MainGameMechanics _mainGameMechanics;
    [SerializeField] private CreateLaptop _createLaptop;
    [SerializeField] private LocalizationManager _localizationManager;
    public byte levelCornesLaptop;
    [SerializeField] private Text _textLevelCornesLaptop;

    [Header("Кнопки")]
    [SerializeField] private Button _plusCornesLaptop;
    [SerializeField] private Button _minusCornesLaptop;

    void Start() { _textLevelCornesLaptop.text = _localizationManager.translateCornesLaptopCreate + " | " + levelCornesLaptop; }

    private void OnEnable() { levelCornesLaptop = 1; }

    void Update()
    {
        _textLevelCornesLaptop.text = _localizationManager.translateCornesLaptopCreate + " | " + levelCornesLaptop;

        if (levelCornesLaptop == _cornesLaptop.levelCornes)
        {
            if (_cornesLaptop.levelCornes > levelCornesLaptop) { _minusCornesLaptop.interactable = false; _plusCornesLaptop.interactable = true; }
            else
            {
                if (levelCornesLaptop != 1) { _minusCornesLaptop.interactable = true; _plusCornesLaptop.interactable = false; }
                else { _minusCornesLaptop.interactable = false; _plusCornesLaptop.interactable = false; }
            }
        }

        else if (_cornesLaptop.levelCornes > levelCornesLaptop)
        {
            if (levelCornesLaptop != 1) { _minusCornesLaptop.interactable = true; _plusCornesLaptop.interactable = true; }
            else { _minusCornesLaptop.interactable = false; _plusCornesLaptop.interactable = true; }
        }

        if (levelCornesLaptop == 8) { _plusCornesLaptop.interactable = false; _minusCornesLaptop.interactable = true; }
    }

    public void plusCornesLaptopButton()
    {
        if (_cornesLaptop.levelCornes > levelCornesLaptop)
        {
            levelCornesLaptop++;
            _mainGameMechanics.FullZeroCostLaptop += 5;
            _createLaptop.scoreRatingAverage += 5;
        }          
    }

    public void minesCornesLaptopButton()
    {
        if (levelCornesLaptop != 1)
        {
            levelCornesLaptop--;
            _mainGameMechanics.FullZeroCostLaptop -= 5;
            _createLaptop.scoreRatingAverage -= 5;
        }           
    }
}
