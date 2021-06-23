using UnityEngine;
using UnityEngine.UI;

public class ReductionEnergyCP : MonoBehaviour
{
    [SerializeField] private MainGameMechanics _mainGameMechanics;
    [SerializeField] private ReductionEnergy _reductionEnergy;
    [SerializeField] private CreateLaptop _createLaptop;
    [SerializeField] private LocalizationManager _localizationManager;
    public byte levelReductionEnergy;
    [SerializeField] private Text _textReductionEnergy;
    [SerializeField] private Text _textLevelReductionEnergy;

    [Header("Кнопки")]
    [SerializeField] private Button _plusButtonEnergy;
    [SerializeField] private Button _minusButtonEnergy;


    void Update()
    {
        if (_localizationManager._indexLanguage == 1) { _textReductionEnergy.text = "Reduction in Energy Consumption"; }
        else { _textReductionEnergy.text = "Снижение Энергопотр."; }
        
        _textLevelReductionEnergy.text = levelReductionEnergy.ToString();

        if (levelReductionEnergy == _reductionEnergy.levelReductionEnergy)
        {
            if (_reductionEnergy.levelReductionEnergy > levelReductionEnergy)
            {
                _minusButtonEnergy.interactable = false;
                _plusButtonEnergy.interactable = true;
            }
            else
            {
                if (levelReductionEnergy != 1) { _minusButtonEnergy.interactable = true; _plusButtonEnergy.interactable = false; }
                else { _minusButtonEnergy.interactable = false; _plusButtonEnergy.interactable = false; }
            }
        }

        else if (_reductionEnergy.levelReductionEnergy > levelReductionEnergy)
        {
            if (levelReductionEnergy != 1) { _minusButtonEnergy.interactable = true; _plusButtonEnergy.interactable = true; }
            else { _minusButtonEnergy.interactable = false; _plusButtonEnergy.interactable = true; }
        }

        if (levelReductionEnergy == 8) { _plusButtonEnergy.interactable = false; _minusButtonEnergy.interactable = true; }
    }

    public void plusReductionEnergy()
    {
        if (_reductionEnergy.levelReductionEnergy > levelReductionEnergy)
        {
            levelReductionEnergy++;
            _mainGameMechanics.FullZeroCostLaptop += 5;
            _createLaptop.scoreRatingAverage += 5;
        }
    }

    public void minusReductionEnergy()
    {
        if (levelReductionEnergy != 1)
        {
            levelReductionEnergy--;
            _mainGameMechanics.FullZeroCostLaptop -= 5;
            _createLaptop.scoreRatingAverage -= 5;
        }
    }
}
