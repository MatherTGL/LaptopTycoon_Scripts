using UnityEngine;
using UnityEngine.UI;

public class AirFilterCP : MonoBehaviour
{
    [SerializeField] private MainGameMechanics _mainGameMechanics;
    [SerializeField] private CreateLaptop _createLaptop;
    [SerializeField] private AirFilter _airFilter;
    [SerializeField] private LocalizationManager _localizationManager;

    public byte levelAirFilter;
    [SerializeField] private Text _textLevelAirFilter;

    [Header("Кнопки")]
    [SerializeField] private Image _plusButtonAirFilter;
    [SerializeField] private Image _minusButtonAirFilter;

    void Update()
    {
        _textLevelAirFilter.text = _localizationManager.translateAirFilterPerformance + " | " + levelAirFilter;

        if (levelAirFilter == _airFilter.levelAirFilter)
        {
            if (_airFilter.levelAirFilter > levelAirFilter)
            {
                _minusButtonAirFilter.color = _createLaptop.deactiveColor;
                _plusButtonAirFilter.color = _createLaptop.activeColor;
            }
            else
            {
                if (levelAirFilter != 1)
                {
                    _minusButtonAirFilter.color = _createLaptop.activeColor;
                    _plusButtonAirFilter.color = _createLaptop.deactiveColor;
                }
                else { _minusButtonAirFilter.color = _createLaptop.deactiveColor; _plusButtonAirFilter.color = _createLaptop.deactiveColor; }
            }
        }

        else if (_airFilter.levelAirFilter > levelAirFilter)
        {
            if (levelAirFilter != 1)
            {
                _minusButtonAirFilter.color = _createLaptop.activeColor;
                _plusButtonAirFilter.color = _createLaptop.activeColor;
            }
            else { _minusButtonAirFilter.color = _createLaptop.deactiveColor; _plusButtonAirFilter.color = _createLaptop.activeColor; }
        }

        if (levelAirFilter == 7)
        {
            _minusButtonAirFilter.color = _createLaptop.deactiveColor;
            _plusButtonAirFilter.color = _createLaptop.activeColor;
        }
    }

    public void plusAirFilterButton()
    {
        if (_airFilter.levelAirFilter > levelAirFilter)
        {
            levelAirFilter++;
            _mainGameMechanics.FullZeroCostLaptop += 5;
            _createLaptop.scoreRatingAverage += 5;
        }
    }
    public void minesAirFilterButton()
    {
        if (levelAirFilter != 1)
        {
            levelAirFilter--;
            _mainGameMechanics.FullZeroCostLaptop -= 5;
            _createLaptop.scoreRatingAverage -= 5;
        }
    }
}
