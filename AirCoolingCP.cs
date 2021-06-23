using UnityEngine;
using UnityEngine.UI;

public class AirCoolingCP : MonoBehaviour
{
    [SerializeField] private CoolingLaptopUpgrade _coolingLaptopUpgrade;
    [SerializeField] private MainGameMechanics _mainGameMechanics;
    [SerializeField] private CreateLaptop _createLaptop;
    [SerializeField] private LocalizationManager _localizationManager;

    public byte levelAirCooling;
    [SerializeField] private Text _textLevelAirCooling;

    [Header("Кнопки")]
    [SerializeField] private Image _plusButtonAirCooling;
    [SerializeField] private Image _minusButtonAirCooling;

    void Update()
    {
        _textLevelAirCooling.text = _localizationManager.translateAirCoolingPerformance + " | " + levelAirCooling;

        if (levelAirCooling == _coolingLaptopUpgrade.levelCooling)
        {
            if (_coolingLaptopUpgrade.levelCooling > levelAirCooling)
            {
                _minusButtonAirCooling.color = _createLaptop.deactiveColor;
                _plusButtonAirCooling.color = _createLaptop.activeColor;
            }
            else
            {
                if (levelAirCooling != 1) { _minusButtonAirCooling.color = _createLaptop.activeColor; _plusButtonAirCooling.color = _createLaptop.deactiveColor; }
                else { _minusButtonAirCooling.color = _createLaptop.deactiveColor; _plusButtonAirCooling.color = _createLaptop.deactiveColor; }
            }
        }

        else if (_coolingLaptopUpgrade.levelCooling > levelAirCooling)
        {
            if (levelAirCooling != 1) { _minusButtonAirCooling.color = _createLaptop.activeColor; _plusButtonAirCooling.color = _createLaptop.activeColor; }
            else { _minusButtonAirCooling.color = _createLaptop.deactiveColor; _plusButtonAirCooling.color = _createLaptop.activeColor; }
        }

        if (levelAirCooling == 13)
        {
            _minusButtonAirCooling.color = _createLaptop.activeColor;
            _plusButtonAirCooling.color = _createLaptop.deactiveColor;
        }
    }

    public void plusAirCoolingButton()
    {
        if (_coolingLaptopUpgrade.levelCooling > levelAirCooling)
        {
            levelAirCooling++;
            _mainGameMechanics.FullZeroCostLaptop += 5;
            _createLaptop.scoreRatingAverage += 5;
        }
    }

    public void minesAirCoolingButton()
    {
        if (levelAirCooling != 1)
        {
            levelAirCooling--;
            _mainGameMechanics.FullZeroCostLaptop -= 5;
            _createLaptop.scoreRatingAverage -= 5;
        }
    }
}
