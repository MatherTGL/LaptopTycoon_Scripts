using UnityEngine;
using UnityEngine.UI;

public class PowerSupplyCP : MonoBehaviour
{
    [SerializeField] private MainGameMechanics _mainGameMechanics;
    [SerializeField] private PowerSupply _powerSupply;
    [SerializeField] private CreateLaptop _createLaptop;
    [SerializeField] private LocalizationManager _localizationManager;
    public byte levelPowerSupply;
    [SerializeField] private Text _textLevelPowerSupply;
    [SerializeField] private Text _textPowerSupply;

    [Header("Кнопки")]
    [SerializeField] private Button _plusButtonSupply;
    [SerializeField] private Button _minusButtonSupply;

    private void OnEnable()
    {
        if (_localizationManager._indexLanguage == 1) { _textPowerSupply.text = "Battery Power"; }
        else { _textPowerSupply.text = "Мощность Батареи"; }
    }


    void Update()
    {
        _textLevelPowerSupply.text = levelPowerSupply.ToString();

        if (levelPowerSupply == _powerSupply.levelPowerSupply)
        {
            if (_powerSupply.levelPowerSupply > levelPowerSupply)
            {
                _minusButtonSupply.interactable = false;
                _plusButtonSupply.interactable = true;
            }        
            else
            {
                if (levelPowerSupply != 1) { _minusButtonSupply.interactable = true; _plusButtonSupply.interactable = false; }
                else { _minusButtonSupply.interactable = false; _plusButtonSupply.interactable = false; }
            }
        }

        else if (_powerSupply.levelPowerSupply > levelPowerSupply)
        {
            if (levelPowerSupply != 1) { _minusButtonSupply.interactable = true; _plusButtonSupply.interactable = true; }
            else { _minusButtonSupply.interactable = false; _plusButtonSupply.interactable = true; }
        }
        if (levelPowerSupply == 8) { _plusButtonSupply.interactable = false; _minusButtonSupply.interactable = true; }
    }

    public void plusPowerSupply()
    {
        if (_powerSupply.levelPowerSupply > levelPowerSupply)
        {
            levelPowerSupply++;
            _mainGameMechanics.FullZeroCostLaptop += 5;
            _createLaptop.scoreRatingAverage += 5;
        }
    }

    public void minusPowerSupply()
    {
        if (levelPowerSupply != 1)
        {
            levelPowerSupply--;
            _mainGameMechanics.FullZeroCostLaptop -= 5;
            _createLaptop.scoreRatingAverage -= 5;
        }
    }
}
