using UnityEngine;
using UnityEngine.UI;

public class WirelessChargerToggleCP : MonoBehaviour
{
    [SerializeField] private MainGameMechanics _mainGameMechanics;
    [SerializeField] private FunctionPanelButton _functionPanelButton;
    [SerializeField] private LocalizationManager _localizationManager;
    [SerializeField] private Toggle _wirelessToggleActive;
    [SerializeField] private Text _textWirelessCharger;

    void OnEnable()
    {
        _wirelessToggleActive.isOn = false;
        if (_localizationManager._indexLanguage == 1) { _textWirelessCharger.text = "Wireless Charger"; }
        else { _textWirelessCharger.text = "Беспроводная Зарядка"; }
    }

    public void wirelessCharger()
    {
        if (_wirelessToggleActive.isOn == true) { _mainGameMechanics.FullZeroCostLaptop += 30; }
        if (_wirelessToggleActive.isOn == false) { _mainGameMechanics.FullZeroCostLaptop -= 30; }
    }
}
