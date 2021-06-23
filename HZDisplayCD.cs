using UnityEngine;
using UnityEngine.UI;

public class HZDisplayCD : MonoBehaviour
{
    [SerializeField] private MainGameMechanics _mainGameMechanics;
    [SerializeField] private CreateLaptop _createLaptop;
    [SerializeField] private HZDisplay _hzDisplay;
    [SerializeField] private Button _minusHZButtonDisplay;
    [SerializeField] private Button _plusHZButtonDisplay;
    [SerializeField] private Text _currentHZDisplay;
    [SerializeField] private ushort _currentHZ;
    [SerializeField] private byte _levelCurrentHZ;

    void Update()
    {
        if (_levelCurrentHZ == 1) { _currentHZ = 60; }         
        else if (_levelCurrentHZ == 2) { _currentHZ = 120; }         
        else if (_levelCurrentHZ == 3) { _currentHZ = 144; }            
        else if (_levelCurrentHZ == 4) { _currentHZ = 240; }         
        else { _currentHZ = 300; }
           
        _currentHZDisplay.text = _currentHZ + " HZ";

        if (_levelCurrentHZ == 1)
        {
            if (_hzDisplay.levelHZ == 1)
            {
                _minusHZButtonDisplay.interactable = false;
                _plusHZButtonDisplay.interactable = false;
            }
            else { _minusHZButtonDisplay.interactable = false; _plusHZButtonDisplay.interactable = true; }
        }
        else if (_levelCurrentHZ == 5)
        {
            _minusHZButtonDisplay.interactable = true;
            _plusHZButtonDisplay.interactable = false;
        }
        else
        {
            if (_levelCurrentHZ != _hzDisplay.levelHZ)
            {
                _minusHZButtonDisplay.interactable = true;
                _plusHZButtonDisplay.interactable = true;
            }
            else { _minusHZButtonDisplay.interactable = true; _plusHZButtonDisplay.interactable = false; }
        }
    }

    public void minusButtonHZDisplay()
    {
        if (_hzDisplay.levelHZ != 1)
        {
            if (_levelCurrentHZ != 1)
            {
                _levelCurrentHZ--;
                _mainGameMechanics.FullZeroCostLaptop -= 20;
                _createLaptop.scoreRatingAverage -= 10;
            }
        }
    }

    public void plusButtonHZDisplay()
    {
        if (_levelCurrentHZ < _hzDisplay.levelHZ)
        {
            if (_levelCurrentHZ != 5)
            {
                _levelCurrentHZ++;
                _mainGameMechanics.FullZeroCostLaptop += 20;
                _createLaptop.scoreRatingAverage += 10;
            }          
        }
    }
}
