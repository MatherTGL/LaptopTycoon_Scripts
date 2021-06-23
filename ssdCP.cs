using UnityEngine;
using UnityEngine.UI;

public class ssdCP : MonoBehaviour
{
    [SerializeField] private SSDUpgrade _ssdUpgrade;
    [SerializeField] private MainGameMechanics _mainGameMechanics;
    [SerializeField] private CreateLaptop _createLaptop;

    [SerializeField] private byte _levelSSDMemory;
    [SerializeField] private Text _textSSDMemory;

    [SerializeField] private Image _minusSSD;
    [SerializeField] private Image _plusSSD;

    [SerializeField] private GameObject _ssdPanelMemory;

    private void OnEnable()
    {
        _ssdUpgrade.memorySSD = 128;
        _textSSDMemory.text = _ssdUpgrade.memorySSD + " GB";
        checkTextSSD();
    }

    void checkTextSSD()
    {
        if (_ssdUpgrade.levelSSD == 1) { if (_levelSSDMemory == 1) { _minusSSD.color = _createLaptop.deactiveColor; _plusSSD.color = _createLaptop.deactiveColor; } }
        else
        {
            if (_levelSSDMemory > 1 | _levelSSDMemory < _ssdUpgrade.levelSSD)
            {
                _minusSSD.color = _createLaptop.activeColor;
                _plusSSD.color = _createLaptop.activeColor;
            }
            if (_levelSSDMemory == _ssdUpgrade.levelSSD)
            {
                _minusSSD.color = _createLaptop.activeColor;
                _plusSSD.color = _createLaptop.deactiveColor;
            }
            if (_levelSSDMemory == 1) { _minusSSD.color = _createLaptop.deactiveColor; _plusSSD.color = _createLaptop.activeColor; }
        }
    }

    public void plusSSDMemory()
    {
        if (_ssdUpgrade.levelSSD != 0)
        {
            if (_ssdUpgrade.levelSSD > _levelSSDMemory)
            {
                _levelSSDMemory++;
                _ssdUpgrade.memorySSD *= 2;
                _mainGameMechanics.FullZeroCostLaptop += 10;
                _textSSDMemory.text = _ssdUpgrade.memorySSD + " GB";
                checkTextSSD();
            }
        }
    }

    public void minesSSDMemory()
    {
        if (_ssdUpgrade.levelSSD != 0)
        {
            if (_levelSSDMemory != 1)
            {
                _levelSSDMemory--;
                _ssdUpgrade.memorySSD /= 2;
                _mainGameMechanics.FullZeroCostLaptop -= 10;
                _textSSDMemory.text = _ssdUpgrade.memorySSD + " GB";
                checkTextSSD();
            }
        }      
    }

    public void ssdToggleActive()
    {
        if (_ssdUpgrade.addSSDLaptop.isOn == true) { _ssdPanelMemory.SetActive(true); _mainGameMechanics.FullZeroCostLaptop += 30; }
        if (_ssdUpgrade.addSSDLaptop.isOn == false) { _ssdPanelMemory.SetActive(false); _mainGameMechanics.FullZeroCostLaptop -= 30; }
    }
}
