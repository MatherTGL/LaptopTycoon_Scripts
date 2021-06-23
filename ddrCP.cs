using UnityEngine;
using UnityEngine.UI;

public class ddrCP : MonoBehaviour
{
    [SerializeField] private MainGameMechanics _mainGameMechanics;
    [SerializeField] private DDRUpgrade _ddrUpgrade;
    [SerializeField] private CreateLaptop _createLaptop;

    public byte levelDDRLaptop;
    [SerializeField] private Text _textLevelDDRLaptop;

    [Header("Кнопки")]
    [SerializeField] private Image _plusButtonDDR;
    [SerializeField] private Image _minusButtonDDR;

    void Update()
    {
        _textLevelDDRLaptop.text = "DDR " + levelDDRLaptop;
        checkButtonActived();
    }

    private void checkButtonActived()
    {
        if (levelDDRLaptop < _ddrUpgrade.levelDDR)
        {
            if (levelDDRLaptop == 2) { _minusButtonDDR.color = _createLaptop.deactiveColor; _plusButtonDDR.color = _createLaptop.activeColor; }
            if (levelDDRLaptop != 2) { _minusButtonDDR.color = _createLaptop.activeColor; _plusButtonDDR.color = _createLaptop.activeColor; }
        }

        if (levelDDRLaptop >= _ddrUpgrade.levelDDR)
        {
            if (levelDDRLaptop > _ddrUpgrade.levelDDR) { _minusButtonDDR.color = _createLaptop.activeColor; _plusButtonDDR.color = _createLaptop.deactiveColor; }

            if (levelDDRLaptop == _ddrUpgrade.levelDDR) { _minusButtonDDR.color = _createLaptop.activeColor; _plusButtonDDR.color = _createLaptop.activeColor; }

            if (levelDDRLaptop == 2)
            {
                if (_ddrUpgrade.levelDDR == 1) { _minusButtonDDR.color = _createLaptop.deactiveColor; _plusButtonDDR.color = _createLaptop.deactiveColor; }
                else { _minusButtonDDR.color = _createLaptop.deactiveColor; _plusButtonDDR.color = _createLaptop.activeColor; }
            }
        }
    }

    public void plusDDRButton()
    {
        if (_ddrUpgrade.levelDDR >= levelDDRLaptop)
        {
            levelDDRLaptop++;
            _mainGameMechanics.FullZeroCostLaptop += 15;
            _createLaptop.scoreRatingAverage += 5;
        }
    }

    public void minusDDRButton()
    {
        if (levelDDRLaptop != 2)
        {
            levelDDRLaptop--;
            _mainGameMechanics.FullZeroCostLaptop -= 15;
            _createLaptop.scoreRatingAverage -= 5;
        }
    }
}
