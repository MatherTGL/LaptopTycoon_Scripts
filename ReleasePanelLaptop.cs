using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ReleasePanelLaptop : MonoBehaviour
{
    [SerializeField] private checkInfoReleasePanel _checkInfoReleasePanel;
    [SerializeField] private MainGameMechanics _mainGameMechanics;
    [SerializeField] private CreateLaptop _createLaptop;
    [SerializeField] private videocardData _videocardData;
    [SerializeField] private VideocardManager _videocardManager;
    [SerializeField] private SSDUpgrade _ssdUpgrade;
    [SerializeField] private WaterCooling _waterCooling;
    [SerializeField] private FaceIDUpgrade _faceIDUpgrade;
    [SerializeField] private WaterResistant _waterResistance;
    [SerializeField] private QuickCharge _quickCharge;
    [SerializeField] private WirelessCharger _wirelessCharger;
    [SerializeField] private ScreenCoverageCL _screenCoverageCL;
    [SerializeField] private ScreenSolution _screenSolution;
    [SerializeField] private LocalizationManager _localizationManager;
    [SerializeField] private ddrCP _ddrCP;

    [SerializeField] private Text _textRAMReleasePanel;
    [SerializeField] private Text _textROMReleasePanel;
    [SerializeField] private Text _textDDRReleasePanel;
    public Text _textVideocardReleasePanel;
    [SerializeField] private Text _textSSDReleasePanel;
    [SerializeField] private Text _textWaterCoolingRelease;
    [SerializeField] private Text _textWaterResistanceRelease;
    [SerializeField] private Text _textFaceIDRelease;
    [SerializeField] private Text _textQuickChargeRelease;
    [SerializeField] private Text _textWirelessChargerRelease;

    public string _nameResolution;
    [SerializeField] private Text _textCoverageRelease; 
    [SerializeField] private Text _textCostReleasePanel;
    [SerializeField] private Text _textNameReleasePanel;

    private void Start() { _nameResolution = "FHD"; }

    private void OnEnable() { StartCoroutine(checkTextRelease()); _nameResolution = _screenSolution.displayString; }

    private void OnDisable() { StopCoroutine(checkTextRelease()); }

    IEnumerator checkTextRelease()
    {
        while (true)
        {
            if (_waterCooling.addWaterCooling.isOn == true) { _textWaterCoolingRelease.text = _localizationManager.translateWaterCoolingRelease + "+"; _checkInfoReleasePanel.waterCoolingReleaseInfo = true; }
            else { _textWaterCoolingRelease.text = _localizationManager.translateWaterCoolingRelease + "-"; _checkInfoReleasePanel.waterCoolingReleaseInfo = false; }

            if (_faceIDUpgrade.addFaceID.isOn == true) { _textFaceIDRelease.text = "FaceID: +"; _checkInfoReleasePanel.faceIDReleaseInfo = true; }
            else { _textFaceIDRelease.text = "FaceID: -"; _checkInfoReleasePanel.faceIDReleaseInfo = false; }

            _textRAMReleasePanel.text = "RAM: " + _createLaptop.currentRAMLaptop + " GB";
            _textROMReleasePanel.text = "ROM: " + _createLaptop.currentROMLaptop + " GB";
            _textDDRReleasePanel.text = "DDR: " + _ddrCP.levelDDRLaptop;
            _textCostReleasePanel.text = "$ " + _mainGameMechanics.retailPrice;

            if (_checkInfoReleasePanel.coverageLaptop == 1) { _textCoverageRelease.text = "MATTE"; }
            if (_checkInfoReleasePanel.coverageLaptop == 0) { _textCoverageRelease.text = "GLOSSY"; }
            _textNameReleasePanel.text = _createLaptop.NameLaptop;

            if (_quickCharge.addQuickCharge.isOn == true) { _textQuickChargeRelease.text = _localizationManager.translateQuickChargeRelease + "+"; _checkInfoReleasePanel.quickChargeReleaseInfo = true; }
            else { _textQuickChargeRelease.text = _localizationManager.translateQuickChargeRelease + "-"; _checkInfoReleasePanel.quickChargeReleaseInfo = false; }

            if (_waterResistance.addWaterResistance.isOn == true) { _textWaterResistanceRelease.text = _localizationManager.translateWaterResistanceRelease + "+"; _checkInfoReleasePanel.waterResistanceReleaseInfo = true; }
            else { _textWaterResistanceRelease.text = _localizationManager.translateWaterResistanceRelease + "-"; _checkInfoReleasePanel.waterResistanceReleaseInfo = false; }

            if (_wirelessCharger.addWirelessCharger.isOn == true) { _textWirelessChargerRelease.text = _localizationManager.translateWirelessChargerRelease + "+"; _checkInfoReleasePanel.wirelessChargerReleaseInfo = true; }
            else { _textWirelessChargerRelease.text = _localizationManager.translateWirelessChargerRelease + "-"; _checkInfoReleasePanel.wirelessChargerReleaseInfo = false; }

            if (_ssdUpgrade.addSSDLaptop.isOn == true) { _textSSDReleasePanel.text = "SSD: +"; _checkInfoReleasePanel.ssdActiveInfo = true; }
            else { _textSSDReleasePanel.text = "SSD: -"; _checkInfoReleasePanel.ssdActiveInfo = false; }

            if (_videocardManager.defaultVideocards[0].activeSelf) { _textVideocardReleasePanel.text = _localizationManager.translateVideocardRelease + "RYX 550"; }
            if (_videocardManager.defaultVideocards[1].activeSelf) { _textVideocardReleasePanel.text = _localizationManager.translateVideocardRelease + "MGX 1050"; }
            if (_videocardManager.defaultVideocards[2].activeSelf) { _textVideocardReleasePanel.text = _localizationManager.translateVideocardRelease + "MGX 1050TI"; }
            if (_videocardManager.defaultVideocards[3].activeSelf) { _textVideocardReleasePanel.text = _localizationManager.translateVideocardRelease + "MGX 1650"; }
            if (_videocardManager.defaultVideocards[4].activeSelf) { _textVideocardReleasePanel.text = _localizationManager.translateVideocardRelease + "MGX 1060"; }
            if (_videocardManager.defaultVideocards[5].activeSelf) { _textVideocardReleasePanel.text = _localizationManager.translateVideocardRelease + "MGX 1070TI"; }
            if (_videocardManager.defaultVideocards[6].activeSelf) { _textVideocardReleasePanel.text = _localizationManager.translateVideocardRelease + "RGX 2060"; }
            if (_videocardManager.defaultVideocards[7].activeSelf) { _textVideocardReleasePanel.text = _localizationManager.translateVideocardRelease + "RGX 2060S"; }
            if (_videocardManager.defaultVideocards[8].activeSelf) { _textVideocardReleasePanel.text = _localizationManager.translateVideocardRelease + "RGX 2070"; }
            if (_videocardManager.defaultVideocards[9].activeSelf) { _textVideocardReleasePanel.text = _localizationManager.translateVideocardRelease + "RGX 2070S"; }
            if (_videocardManager.defaultVideocards[10].activeSelf) { _textVideocardReleasePanel.text = _localizationManager.translateVideocardRelease + "RGX 2080TI"; }
            if (_videocardManager.defaultVideocards[11].activeSelf) { _textVideocardReleasePanel.text = _localizationManager.translateVideocardRelease + "RGX 3070"; }
            if (_videocardManager.defaultVideocards[12].activeSelf) { _textVideocardReleasePanel.text = _localizationManager.translateVideocardRelease + "RGX 3070S"; }
            if (_videocardManager.defaultVideocards[13].activeSelf) { _textVideocardReleasePanel.text = _localizationManager.translateVideocardRelease + "RGX 3080"; }
            if (_videocardManager.defaultVideocards[14].activeSelf) { _textVideocardReleasePanel.text = _localizationManager.translateVideocardRelease + "RGX 3080S"; }
            if (_videocardManager.defaultVideocards[15].activeSelf) { _textVideocardReleasePanel.text = _localizationManager.translateVideocardRelease + "RGX 3090"; }
            if (_videocardManager.defaultVideocards[16].activeSelf) { _textVideocardReleasePanel.text = _localizationManager.translateVideocardRelease + "RGX 3090S"; }
            yield break;
        }
    }
}
