using System.Collections;
using UnityEngine;

public class checkInfoReleasePanel : MonoBehaviour
{
    [SerializeField] private CreateLaptop _createLaptop;
    [SerializeField] private MainGameMechanics _mainGameMechanics;
    [SerializeField] private FunctionPanelButton _functionPanelButton;
    [SerializeField] private ddrCP _ddrCP;
    [SerializeField] private WaterCooling _waterCooling;
    [SerializeField] private SSDUpgrade _ssdUpgrade;
    [SerializeField] private FaceIDUpgrade _faceIDUpgrade;
    [SerializeField] private WaterResistant _waterResistance;
    [SerializeField] private QuickCharge _quickCharge;
    [SerializeField] private WirelessCharger _wirelessCharger;
    [SerializeField] private videocardData _videocardData;
    [SerializeField] private VideocardManager _videocardManager;
    [SerializeField] private ScreenSolution _screenSolution;

    public byte ramReleaseInfo;
    public byte romReleaseInfo;
    public byte ddrReleaseInfo;
    public ushort ssdGBInfo;
    public bool ssdActiveInfo;
    public bool waterCoolingReleaseInfo;
    public bool waterResistanceReleaseInfo;
    public bool faceIDReleaseInfo;
    public bool quickChargeReleaseInfo;
    public bool wirelessChargerReleaseInfo;
    public ushort displayResolutionReleaseInfo;
    public byte coverageLaptop;

    void Start() { StartCoroutine(checkInfoLaptop()); }

    void OnDisable() { StopCoroutine(checkInfoLaptop()); }

    IEnumerator checkInfoLaptop()
    {
        while(true)
        {
            if (_functionPanelButton.CreateLaptopPanel.activeSelf)
            {
                ramReleaseInfo = (byte)_createLaptop.currentRAMLaptop;
                romReleaseInfo = (byte)_createLaptop.currentROMLaptop;
                ddrReleaseInfo = _ddrCP.levelDDRLaptop;
                displayResolutionReleaseInfo = (ushort)_screenSolution.display;
            }
            yield return new WaitForSeconds(0.2f);
        }
    }
}
