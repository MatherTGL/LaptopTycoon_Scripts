using UnityEngine;
using UnityEngine.UI;

public class CostSliderSettings : MonoBehaviour
{
    [SerializeField] private CreateLaptop _createLaptop;
    [SerializeField] private MainGameMechanics _mainGameMechanics;
    public Slider costSliderLaptop;
    [SerializeField] private Text _textCostLaptop;
    [SerializeField] private Image _imageBackgroundSlider;

    [SerializeField] private Color _firstColor;
    [SerializeField] private Color _secondColor;
    [SerializeField] private Color _thirdColor;
    [SerializeField] private Color _fourthColor;
    [SerializeField] private Color _fivesColor;

    [SerializeField] private ushort _firstColorNumber;
    [SerializeField] private ushort _secondColorNumber;
    [SerializeField] private ushort _thirdColorNumber;
    [SerializeField] private ushort _fourthColorNumber;
    [SerializeField] private ushort _fivesColorNumber;


    void Start()
    {
        costSliderLaptop = GetComponent<Slider>();
    }

    private void OnEnable()
    {
        costSliderLaptop.value = costSliderLaptop.minValue;
        _firstColorNumber = (ushort)(costSliderLaptop.minValue * 1.05f);
        _secondColorNumber = (ushort)(costSliderLaptop.minValue * 1.1f);
        _thirdColorNumber = (ushort)(costSliderLaptop.minValue * 1.15f);
        _fourthColorNumber = (ushort)(costSliderLaptop.minValue * 1.3f);
        _fivesColorNumber = (ushort)(costSliderLaptop.minValue * 1.42f);
    }

    void Update()
    {
        _textCostLaptop.text = _mainGameMechanics.FullZeroCostLaptop + "$ / " + costSliderLaptop.value.ToString("###") + "$";

        if (costSliderLaptop.value <= _firstColorNumber) { _imageBackgroundSlider.color = _firstColor; }
        if (costSliderLaptop.value > _firstColorNumber) { _imageBackgroundSlider.color = _firstColor; }
        if (costSliderLaptop.value > _secondColorNumber) { _imageBackgroundSlider.color = _secondColor; }
        if (costSliderLaptop.value > _thirdColorNumber) { _imageBackgroundSlider.color = _thirdColor; }
        if (costSliderLaptop.value >= _fourthColorNumber) { _imageBackgroundSlider.color = _fourthColor; }
        if (costSliderLaptop.value >= _fivesColorNumber) { _imageBackgroundSlider.color = _fivesColor; }
    }
}
