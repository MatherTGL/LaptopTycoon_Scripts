using UnityEngine;
using UnityEngine.UI;

public class UpgradePanelButtons : MonoBehaviour
{   
    [Header("Панели")]
    [SerializeField] private GameObject _UpgradeButtonExteriorDesignPanel; //Панель внешнего дизайна
    [SerializeField] private GameObject _UpgradeButtonDisplayPanel; //Панель дисплея
    [SerializeField] private GameObject _UpgradeButtonCameraPanel; //Панель камеры
    [SerializeField] private GameObject _UpgradeCPUMemoryPanel; //cpu and memory
    [SerializeField] private GameObject _UpgradeOSMorePanel; //Панель операционной системы и дополнительно
    [SerializeField] private GameObject _UpgradeOtherPanel; //Панель другого
    [SerializeField] private GameObject _UpgradeOfficePanel; //Панель своего оффиса
    [SerializeField] private GameObject _UpgradeMarketingPanel; //Панель маркетинга
    [SerializeField] private GameObject _UpgradeLaboratoryPanel; //Панель лаборатории
    [SerializeField] private GameObject _UpgradeCoolingPanel;
    [SerializeField] private GameObject _UpgradeBatteryPanel;

    [SerializeField] private Image _imageButtonExteriorDesignPanel;
    [SerializeField] private Image _imageButtonDisplayPanel;
    [SerializeField] private Image _imageButtonCameraPanel;
    [SerializeField] private Image _imageButtonCPUMemoryPanel;
    [SerializeField] private Image _imageButtonOSMorePanel;
    [SerializeField] private Image _imageButtonOtherPanel;
    [SerializeField] private Image _imageButtonOfficePanel;
    [SerializeField] private Image _imageButtonMarketingPanel;
    [SerializeField] private Image _imageButtonLaboratoryPanel;
    [SerializeField] private Image _imageButtonCoolingPanel;
    [SerializeField] private Image _imageButtonBatteryPanel;

    [SerializeField] private Color _activeButtonColor;
    [SerializeField] private Color _defaultButtonColor;


    private void OnEnable()
    {
        _UpgradeButtonExteriorDesignPanel.SetActive(true);
        _UpgradeButtonDisplayPanel.SetActive(false);
        _UpgradeButtonCameraPanel.SetActive(false);
        _UpgradeCPUMemoryPanel.SetActive(false);
        _UpgradeOSMorePanel.SetActive(false);
        _UpgradeOtherPanel.SetActive(false);
        _UpgradeOfficePanel.SetActive(false);
        _UpgradeMarketingPanel.SetActive(false);
        _UpgradeLaboratoryPanel.SetActive(false);
        _UpgradeCoolingPanel.SetActive(false);
        _UpgradeBatteryPanel.SetActive(false);
        _imageButtonExteriorDesignPanel.color = _activeButtonColor;
        _imageButtonDisplayPanel.color = _defaultButtonColor;
        _imageButtonCameraPanel.color = _defaultButtonColor;
        _imageButtonCPUMemoryPanel.color = _defaultButtonColor;
        _imageButtonOSMorePanel.color = _defaultButtonColor;
        _imageButtonOtherPanel.color = _defaultButtonColor;
        _imageButtonLaboratoryPanel.color = _defaultButtonColor;
        _imageButtonOfficePanel.color = _defaultButtonColor;
        _imageButtonMarketingPanel.color = _defaultButtonColor;
        _imageButtonCoolingPanel.color = _defaultButtonColor;
        _imageButtonBatteryPanel.color = _defaultButtonColor;
    }

    public void ExteriorDesignButtonMethod()
    {
        _UpgradeButtonExteriorDesignPanel.SetActive(true);
        _UpgradeButtonDisplayPanel.SetActive(false);
        _UpgradeButtonCameraPanel.SetActive(false);
        _UpgradeCPUMemoryPanel.SetActive(false);
        _UpgradeOSMorePanel.SetActive(false);
        _UpgradeOtherPanel.SetActive(false);
        _UpgradeLaboratoryPanel.SetActive(false);
        _UpgradeOfficePanel.SetActive(false);
        _UpgradeMarketingPanel.SetActive(false);
        _UpgradeCoolingPanel.SetActive(false);
        _UpgradeBatteryPanel.SetActive(false);
        _imageButtonExteriorDesignPanel.color = _activeButtonColor;
        _imageButtonDisplayPanel.color = _defaultButtonColor;
        _imageButtonCameraPanel.color = _defaultButtonColor;
        _imageButtonCPUMemoryPanel.color = _defaultButtonColor;
        _imageButtonOSMorePanel.color = _defaultButtonColor;
        _imageButtonOtherPanel.color = _defaultButtonColor;
        _imageButtonLaboratoryPanel.color = _defaultButtonColor;
        _imageButtonOfficePanel.color = _defaultButtonColor;
        _imageButtonMarketingPanel.color = _defaultButtonColor;
        _imageButtonCoolingPanel.color = _defaultButtonColor;
        _imageButtonBatteryPanel.color = _defaultButtonColor;
    }

    public void DesignButtonMethod()
    {
        _UpgradeButtonDisplayPanel.SetActive(false);
        _UpgradeButtonExteriorDesignPanel.SetActive(false);
        _UpgradeButtonCameraPanel.SetActive(false);
        _UpgradeCPUMemoryPanel.SetActive(false);
        _UpgradeOSMorePanel.SetActive(false);
        _UpgradeOtherPanel.SetActive(false);
        _UpgradeLaboratoryPanel.SetActive(false);
        _UpgradeOfficePanel.SetActive(false);
        _UpgradeMarketingPanel.SetActive(false);
        _UpgradeCoolingPanel.SetActive(false);
        _UpgradeBatteryPanel.SetActive(false);
    }

    public void DisplayButtonMethod()
    {
        _UpgradeButtonDisplayPanel.SetActive(true);
        _UpgradeButtonExteriorDesignPanel.SetActive(false);
        _UpgradeButtonCameraPanel.SetActive(false);
        _UpgradeCPUMemoryPanel.SetActive(false);
        _UpgradeOSMorePanel.SetActive(false);
        _UpgradeOtherPanel.SetActive(false);
        _UpgradeLaboratoryPanel.SetActive(false);
        _UpgradeOfficePanel.SetActive(false);
        _UpgradeMarketingPanel.SetActive(false);
        _UpgradeCoolingPanel.SetActive(false);
        _UpgradeBatteryPanel.SetActive(false);
        _imageButtonExteriorDesignPanel.color = _defaultButtonColor;
        _imageButtonDisplayPanel.color = _activeButtonColor;
        _imageButtonCameraPanel.color = _defaultButtonColor;
        _imageButtonCPUMemoryPanel.color = _defaultButtonColor;
        _imageButtonOSMorePanel.color = _defaultButtonColor;
        _imageButtonOtherPanel.color = _defaultButtonColor;
        _imageButtonLaboratoryPanel.color = _defaultButtonColor;
        _imageButtonOfficePanel.color = _defaultButtonColor;
        _imageButtonMarketingPanel.color = _defaultButtonColor;
        _imageButtonCoolingPanel.color = _defaultButtonColor;
        _imageButtonBatteryPanel.color = _defaultButtonColor;
    }

    public void GameraButtonMethod()
    {
        _UpgradeButtonDisplayPanel.SetActive(false);
        _UpgradeButtonExteriorDesignPanel.SetActive(false);
        _UpgradeButtonCameraPanel.SetActive(true);
        _UpgradeCPUMemoryPanel.SetActive(false);
        _UpgradeOSMorePanel.SetActive(false);
        _UpgradeOtherPanel.SetActive(false);
        _UpgradeOfficePanel.SetActive(false);
        _UpgradeLaboratoryPanel.SetActive(false);
        _UpgradeMarketingPanel.SetActive(false);
        _UpgradeCoolingPanel.SetActive(false);
        _UpgradeBatteryPanel.SetActive(false);
        _imageButtonExteriorDesignPanel.color = _defaultButtonColor;
        _imageButtonDisplayPanel.color = _defaultButtonColor;
        _imageButtonCameraPanel.color = _activeButtonColor;
        _imageButtonCPUMemoryPanel.color = _defaultButtonColor;
        _imageButtonOSMorePanel.color = _defaultButtonColor;
        _imageButtonOtherPanel.color = _defaultButtonColor;
        _imageButtonLaboratoryPanel.color = _defaultButtonColor;
        _imageButtonOfficePanel.color = _defaultButtonColor;
        _imageButtonMarketingPanel.color = _defaultButtonColor;
        _imageButtonCoolingPanel.color = _defaultButtonColor;
        _imageButtonBatteryPanel.color = _defaultButtonColor;
    }   

    public void CPUMemoryButtonMethod()
    {
        _UpgradeButtonDisplayPanel.SetActive(false);
        _UpgradeButtonExteriorDesignPanel.SetActive(false);
        _UpgradeButtonCameraPanel.SetActive(false);
        _UpgradeCPUMemoryPanel.SetActive(true);
        _UpgradeOSMorePanel.SetActive(false);
        _UpgradeOtherPanel.SetActive(false);
        _UpgradeOfficePanel.SetActive(false);
        _UpgradeLaboratoryPanel.SetActive(false);
        _UpgradeMarketingPanel.SetActive(false);
        _UpgradeCoolingPanel.SetActive(false);
        _UpgradeBatteryPanel.SetActive(false);
        _imageButtonExteriorDesignPanel.color = _defaultButtonColor;
        _imageButtonDisplayPanel.color = _defaultButtonColor;
        _imageButtonCameraPanel.color = _defaultButtonColor;
        _imageButtonCPUMemoryPanel.color = _activeButtonColor;
        _imageButtonOSMorePanel.color = _defaultButtonColor;
        _imageButtonOtherPanel.color = _defaultButtonColor;
        _imageButtonLaboratoryPanel.color = _defaultButtonColor;
        _imageButtonOfficePanel.color = _defaultButtonColor;
        _imageButtonMarketingPanel.color = _defaultButtonColor;
        _imageButtonCoolingPanel.color = _defaultButtonColor;
        _imageButtonBatteryPanel.color = _defaultButtonColor;
    }

    public void OSMoreButtonMethod()
    {
        _UpgradeButtonDisplayPanel.SetActive(false);
        _UpgradeButtonExteriorDesignPanel.SetActive(false);
        _UpgradeButtonCameraPanel.SetActive(false);
        _UpgradeCPUMemoryPanel.SetActive(false);
        _UpgradeOSMorePanel.SetActive(true);
        _UpgradeOtherPanel.SetActive(false);
        _UpgradeOfficePanel.SetActive(false);
        _UpgradeLaboratoryPanel.SetActive(false);
        _UpgradeMarketingPanel.SetActive(false);
        _UpgradeCoolingPanel.SetActive(false);
        _UpgradeBatteryPanel.SetActive(false);
        _imageButtonExteriorDesignPanel.color = _defaultButtonColor;
        _imageButtonDisplayPanel.color = _defaultButtonColor;
        _imageButtonCameraPanel.color = _defaultButtonColor;
        _imageButtonCPUMemoryPanel.color = _defaultButtonColor;
        _imageButtonOSMorePanel.color = _activeButtonColor;
        _imageButtonOtherPanel.color = _defaultButtonColor;
        _imageButtonLaboratoryPanel.color = _defaultButtonColor;
        _imageButtonOfficePanel.color = _defaultButtonColor;
        _imageButtonMarketingPanel.color = _defaultButtonColor;
        _imageButtonCoolingPanel.color = _defaultButtonColor;
        _imageButtonBatteryPanel.color = _defaultButtonColor;
    }

    public void OtherButtonMethod()
    {
        _UpgradeButtonDisplayPanel.SetActive(false);
        _UpgradeButtonExteriorDesignPanel.SetActive(false);
        _UpgradeButtonCameraPanel.SetActive(false);
        _UpgradeCPUMemoryPanel.SetActive(false);
        _UpgradeOSMorePanel.SetActive(false);
        _UpgradeOtherPanel.SetActive(true);
        _UpgradeOfficePanel.SetActive(false);
        _UpgradeLaboratoryPanel.SetActive(false);
        _UpgradeMarketingPanel.SetActive(false);
        _UpgradeCoolingPanel.SetActive(false);
        _UpgradeBatteryPanel.SetActive(false);
        _imageButtonExteriorDesignPanel.color = _defaultButtonColor;
        _imageButtonDisplayPanel.color = _defaultButtonColor;
        _imageButtonCameraPanel.color = _defaultButtonColor;
        _imageButtonCPUMemoryPanel.color = _defaultButtonColor;
        _imageButtonOSMorePanel.color = _defaultButtonColor;
        _imageButtonOtherPanel.color = _activeButtonColor;
        _imageButtonLaboratoryPanel.color = _defaultButtonColor;
        _imageButtonOfficePanel.color = _defaultButtonColor;
        _imageButtonMarketingPanel.color = _defaultButtonColor;
        _imageButtonCoolingPanel.color = _defaultButtonColor;
        _imageButtonBatteryPanel.color = _defaultButtonColor;
    }

    public void OfficeButtonMethod()
    {
        _UpgradeButtonDisplayPanel.SetActive(false);
        _UpgradeButtonExteriorDesignPanel.SetActive(false);
        _UpgradeButtonCameraPanel.SetActive(false);
        _UpgradeCPUMemoryPanel.SetActive(false);
        _UpgradeOSMorePanel.SetActive(false);
        _UpgradeOtherPanel.SetActive(false);
        _UpgradeLaboratoryPanel.SetActive(false);
        _UpgradeOfficePanel.SetActive(true);
        _UpgradeMarketingPanel.SetActive(false);
        _UpgradeCoolingPanel.SetActive(false);
        _UpgradeBatteryPanel.SetActive(false);
        _imageButtonExteriorDesignPanel.color = _defaultButtonColor;
        _imageButtonDisplayPanel.color = _defaultButtonColor;
        _imageButtonCameraPanel.color = _defaultButtonColor;
        _imageButtonCPUMemoryPanel.color = _defaultButtonColor;
        _imageButtonOSMorePanel.color = _defaultButtonColor;
        _imageButtonOtherPanel.color = _defaultButtonColor;
        _imageButtonLaboratoryPanel.color = _defaultButtonColor;
        _imageButtonOfficePanel.color = _activeButtonColor;
        _imageButtonMarketingPanel.color = _defaultButtonColor;
        _imageButtonCoolingPanel.color = _defaultButtonColor;
        _imageButtonBatteryPanel.color = _defaultButtonColor;
    }

    public void MarketingButtonMethod()
    {
        _UpgradeButtonDisplayPanel.SetActive(false);
        _UpgradeButtonExteriorDesignPanel.SetActive(false);
        _UpgradeButtonCameraPanel.SetActive(false);
        _UpgradeCPUMemoryPanel.SetActive(false);
        _UpgradeOSMorePanel.SetActive(false);
        _UpgradeOtherPanel.SetActive(false);
        _UpgradeLaboratoryPanel.SetActive(false);
        _UpgradeOfficePanel.SetActive(false);
        _UpgradeCoolingPanel.SetActive(false);
        _UpgradeMarketingPanel.SetActive(true);
        _UpgradeBatteryPanel.SetActive(false);
        _imageButtonExteriorDesignPanel.color = _defaultButtonColor;
        _imageButtonDisplayPanel.color = _defaultButtonColor;
        _imageButtonCameraPanel.color = _defaultButtonColor;
        _imageButtonCPUMemoryPanel.color = _defaultButtonColor;
        _imageButtonOSMorePanel.color = _defaultButtonColor;
        _imageButtonOtherPanel.color = _defaultButtonColor;
        _imageButtonLaboratoryPanel.color = _defaultButtonColor;
        _imageButtonOfficePanel.color = _defaultButtonColor;
        _imageButtonMarketingPanel.color = _activeButtonColor;
        _imageButtonCoolingPanel.color = _defaultButtonColor;
        _imageButtonBatteryPanel.color = _defaultButtonColor;
    }

    public void LaboratoryButtonMethod()
    {
        _UpgradeButtonDisplayPanel.SetActive(false);
        _UpgradeButtonExteriorDesignPanel.SetActive(false);
        _UpgradeButtonCameraPanel.SetActive(false);
        _UpgradeCPUMemoryPanel.SetActive(false);
        _UpgradeOSMorePanel.SetActive(false);
        _UpgradeOtherPanel.SetActive(false);
        _UpgradeOfficePanel.SetActive(false);
        _UpgradeMarketingPanel.SetActive(false);
        _UpgradeCoolingPanel.SetActive(false);
        _UpgradeLaboratoryPanel.SetActive(true);
        _UpgradeBatteryPanel.SetActive(false);
        _imageButtonExteriorDesignPanel.color = _defaultButtonColor;
        _imageButtonDisplayPanel.color = _defaultButtonColor;
        _imageButtonCameraPanel.color = _defaultButtonColor;
        _imageButtonCPUMemoryPanel.color = _defaultButtonColor;
        _imageButtonOSMorePanel.color = _defaultButtonColor;
        _imageButtonOtherPanel.color = _defaultButtonColor;
        _imageButtonLaboratoryPanel.color = _activeButtonColor;
        _imageButtonOfficePanel.color = _defaultButtonColor;
        _imageButtonMarketingPanel.color = _defaultButtonColor;
        _imageButtonCoolingPanel.color = _defaultButtonColor;
        _imageButtonBatteryPanel.color = _defaultButtonColor;
    }

    public void CoolingButtonMethod()
    {
        _UpgradeButtonDisplayPanel.SetActive(false);
        _UpgradeButtonExteriorDesignPanel.SetActive(false);
        _UpgradeButtonCameraPanel.SetActive(false);
        _UpgradeCPUMemoryPanel.SetActive(false);
        _UpgradeOSMorePanel.SetActive(false);
        _UpgradeOtherPanel.SetActive(false);
        _UpgradeOfficePanel.SetActive(false);
        _UpgradeMarketingPanel.SetActive(false);
        _UpgradeLaboratoryPanel.SetActive(false);
        _UpgradeCoolingPanel.SetActive(true);
        _UpgradeBatteryPanel.SetActive(false);
        _imageButtonExteriorDesignPanel.color = _defaultButtonColor;
        _imageButtonDisplayPanel.color = _defaultButtonColor;
        _imageButtonCameraPanel.color = _defaultButtonColor;
        _imageButtonCPUMemoryPanel.color = _defaultButtonColor;
        _imageButtonOSMorePanel.color = _defaultButtonColor;
        _imageButtonOtherPanel.color = _defaultButtonColor;
        _imageButtonLaboratoryPanel.color = _defaultButtonColor;
        _imageButtonOfficePanel.color = _defaultButtonColor;
        _imageButtonMarketingPanel.color = _defaultButtonColor;
        _imageButtonCoolingPanel.color = _activeButtonColor;
        _imageButtonBatteryPanel.color = _defaultButtonColor;
    }

    public void BatteryButtonMethod()
    {
        _UpgradeButtonDisplayPanel.SetActive(false);
        _UpgradeButtonExteriorDesignPanel.SetActive(false);
        _UpgradeButtonCameraPanel.SetActive(false);
        _UpgradeCPUMemoryPanel.SetActive(false);
        _UpgradeOSMorePanel.SetActive(false);
        _UpgradeOtherPanel.SetActive(false);
        _UpgradeOfficePanel.SetActive(false);
        _UpgradeMarketingPanel.SetActive(false);
        _UpgradeLaboratoryPanel.SetActive(false);
        _UpgradeCoolingPanel.SetActive(false);
        _UpgradeBatteryPanel.SetActive(true);
        _imageButtonExteriorDesignPanel.color = _defaultButtonColor;
        _imageButtonDisplayPanel.color = _defaultButtonColor;
        _imageButtonCameraPanel.color = _defaultButtonColor;
        _imageButtonCPUMemoryPanel.color = _defaultButtonColor;
        _imageButtonOSMorePanel.color = _defaultButtonColor;
        _imageButtonOtherPanel.color = _defaultButtonColor;
        _imageButtonLaboratoryPanel.color = _defaultButtonColor;
        _imageButtonOfficePanel.color = _defaultButtonColor;
        _imageButtonMarketingPanel.color = _defaultButtonColor;
        _imageButtonCoolingPanel.color = _defaultButtonColor;
        _imageButtonBatteryPanel.color = _activeButtonColor;
    }
}
