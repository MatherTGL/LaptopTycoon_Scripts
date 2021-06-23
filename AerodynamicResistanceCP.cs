using UnityEngine;
using UnityEngine.UI;

public class AerodynamicResistanceCP : MonoBehaviour
{
    [SerializeField] private AerodynamicResistance _aerodynamicResistance;
    [SerializeField] private MainGameMechanics _mainGameMechanics;
    [SerializeField] private CreateLaptop _createLaptop;
    [SerializeField] private LocalizationManager _localizationManager;

    public byte levelAerodynamicResistance;
    [SerializeField] private Text _textLevelAerodynamicResistance;

    [Header("Кнопки")]
    [SerializeField] private Image _plusButtonAerodynamicResistance;
    [SerializeField] private Image _minusButtonAerodynamicResistance;

    void Update()
    {
        _textLevelAerodynamicResistance.text = _localizationManager.translateAerodynamicResistancePerformance + " | " + levelAerodynamicResistance;

        if (levelAerodynamicResistance == _aerodynamicResistance.levelAerodynResistant)
        {
            if (_aerodynamicResistance.levelAerodynResistant > levelAerodynamicResistance)
            {
                _minusButtonAerodynamicResistance.color = _createLaptop.deactiveColor;
                _plusButtonAerodynamicResistance.color = _createLaptop.activeColor;
            }
            else
            {
                if (levelAerodynamicResistance != 1)
                {
                    _minusButtonAerodynamicResistance.color = _createLaptop.activeColor;
                    _plusButtonAerodynamicResistance.color = _createLaptop.deactiveColor;
                }
                else
                {
                    _minusButtonAerodynamicResistance.color = _createLaptop.deactiveColor;
                    _plusButtonAerodynamicResistance.color = _createLaptop.deactiveColor;
                }
            }
        }

        else if (_aerodynamicResistance.levelAerodynResistant > levelAerodynamicResistance)
        {
            if (levelAerodynamicResistance != 1)
            {
                _minusButtonAerodynamicResistance.color = _createLaptop.activeColor;
                _plusButtonAerodynamicResistance.color = _createLaptop.activeColor;
            }
            else
            {
                _minusButtonAerodynamicResistance.color = _createLaptop.deactiveColor;
                _plusButtonAerodynamicResistance.color = _createLaptop.activeColor;
            }
        }

        if (levelAerodynamicResistance == 8)
        {
            _minusButtonAerodynamicResistance.color = _createLaptop.deactiveColor;
            _plusButtonAerodynamicResistance.color = _createLaptop.activeColor;
        }
    }

    public void plusAerodynamicResistanceButton()
    {
        if (_aerodynamicResistance.levelAerodynResistant > levelAerodynamicResistance)
        {
            levelAerodynamicResistance++;
            _mainGameMechanics.FullZeroCostLaptop += 5;
            _createLaptop.scoreRatingAverage += 5;
        }
    }

    public void minesAerodynamicResistanceButton()
    {
        if (levelAerodynamicResistance != 1)
        {
            levelAerodynamicResistance--;
            _mainGameMechanics.FullZeroCostLaptop -= 5;
            _createLaptop.scoreRatingAverage -= 5;
        }
    }
}
