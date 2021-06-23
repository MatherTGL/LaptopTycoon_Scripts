using UnityEngine;
using UnityEngine.UI;

public class QuickChargeCP : MonoBehaviour
{
    [SerializeField] private MainGameMechanics _mainGameMechanics;
    [SerializeField] private FunctionPanelButton _functionPanelButton;
    [SerializeField] private LocalizationManager _localizationManager;
    [SerializeField] private Toggle _quickChargeToggleActive;
    [SerializeField] private Text _textQuickCharge;

    void OnEnable()
    {
        _quickChargeToggleActive.isOn = false;
        if (_localizationManager._indexLanguage == 1) { _textQuickCharge.text = "Quick Charge"; }
        else { _textQuickCharge.text = "Быстрая Зарядка"; }       
    }

    public void quickCharge()
    {
        if (_quickChargeToggleActive.isOn == true) { _mainGameMechanics.FullZeroCostLaptop += 30; }
        if (_quickChargeToggleActive.isOn == false) { _mainGameMechanics.FullZeroCostLaptop -= 30; }
    }
}
