using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeTree : MonoBehaviour
{
    [SerializeField]
    private UpgradeTreeData upgradeTreeData;
    [SerializeField]
    private MainGameMechanics _mainGameMechanics;
    [SerializeField]
    private FunctionPanelButton _functionPanelButton;
    [SerializeField]
    private Crisis _crisis;
    [SerializeField] private CreateLaptop _createLaptop;
    [SerializeField] private Laboratory _laboratory;
    [SerializeField] private MyOSPanel _myOSpanel;

    [Header("Office")]

    [Header("Вывод уровня оффиса в текст")]
    [SerializeField]
    private Text _textLevelOfficeUpgrade;
    public Text _textCostRealtorUpgrade;

    [Header("FACE ID")]

    [Header("Текст Lock/Unlock")]
    [SerializeField] private Text _TextUnlockFaceidUpgrade;
    [SerializeField] private Text _TextUnlockWaterResistantUpgrade;
    [SerializeField] private Text _TextUnlockQuickChargeUpgrade;
    [SerializeField] private Text _TextUnlockWirelessChargerUpgrade;
    [Header("Кнопка открытия Face id")]
    [SerializeField] private Button _OpenFaceIDButton;
    public Color _ColorOpenFaceID;
    [SerializeField] private GameObject _TextFaceIDCost;
    [Header("WaterResistant")]
    [SerializeField] private Button _OpenWaterResistantButton;
    [SerializeField] private GameObject _TextWaterResistantCost;
    [Header("Quick Charge")]
    [SerializeField] private Button _OpenQuickChargeButton;
    [SerializeField] private GameObject _TextQuickChargeCost;
    [Header("Wireless Charger")]
    [SerializeField] private Button _OpenWirelessChargerButton;
    [SerializeField] private GameObject _TextWirelessChargerCost;
    [Header("Screen Diagonal")]
    public GameObject _textScreenDiagonalCost;

    [Header("Текст цены My OS")]
    public Text _CostMyOSUpgrade;
    public Text _TextLevelMyOSUpgrade;
    public Text _textUnlockMyOSUpgrade;
    public byte ActiveOS;

    [Header("Lab")]
    [SerializeField] private GameObject _LabBuyObjects;
    [SerializeField] private Text _LabTextCost;

    void Awake()
    {
        
    }

    void Start()
    {
        TextLevelUpgradeMethod();
        _CostMyOSUpgrade.text = upgradeTreeData.Cost.ToString();
        _TextLevelMyOSUpgrade.text = "Level " + upgradeTreeData.Level.ToString();     
    }

    void Update()
    {
        if (_functionPanelButton._UpgradePanel.activeSelf)
        {
            TextLevelUpgradeMethod();
        }
        _CostMyOSUpgrade.text = upgradeTreeData.Cost.ToString();
        _textCostRealtorUpgrade.text = PlayerPrefs.GetInt("Cost upgrade").ToString();       
    }
  
    public void ScreenDiagonalUpgradeButton()
    {
        if (_mainGameMechanics.RecearchPoint >= upgradeTreeData.Cost)
        {
            if (upgradeTreeData.Level <= 5)
            {
                _mainGameMechanics.RecearchPoint -= (ushort)upgradeTreeData.Cost;
                _createLaptop._MaxDisplayScale++;
                upgradeTreeData.Level++;   
            }
            if (_createLaptop._DisplayScale >= 20)
            {
                _textScreenDiagonalCost.SetActive(false);
            }
        }
    }
    
    public void MyOSUpgradeButton()
    {
        if (_mainGameMechanics.RecearchPoint >= upgradeTreeData.Cost)
        {
            if (ActiveOS == 0)
            {
                ActiveOS += 1;
                PlayerPrefs.SetInt("ActiveOS", ActiveOS);
                _mainGameMechanics.RecearchPoint -= (ushort)upgradeTreeData.Cost;
                _textUnlockMyOSUpgrade.text = "Unlock";
                _TextUnlockWaterResistantUpgrade.color = _ColorOpenFaceID;
                _myOSpanel.ActiveOSPanel.interactable = true;
            }
        }
    }
    void TextLevelUpgradeMethod()
    {
        _textLevelOfficeUpgrade.text = "LVL " + upgradeTreeData.TextLevel;
        upgradeTreeData.TextLevel = upgradeTreeData.Level.ToString();
    }
    IEnumerator CheckLevelOffice()
    {
        while(true)
        {
            if (upgradeTreeData.Level == 1)
            {
                _functionPanelButton._FirstOffice.SetActive(true);
                _functionPanelButton._SecondOffice.SetActive(false);
                _functionPanelButton._ThirdOffice.SetActive(false);
                _mainGameMechanics.MinMoneyRandom = 4000;
                _mainGameMechanics.MaxMoneyRandom = 8000;

                if (_crisis.ActiveCrisis != true)
                {
                    _mainGameMechanics.MinMoneyRandom = 800;
                    _mainGameMechanics.MaxMoneyRandom = 1200;                   
                }
            }

            if (upgradeTreeData.Level == 2)
            {
                _functionPanelButton._SecondOffice.SetActive(true);
                _functionPanelButton._FirstOffice.SetActive(false);
                _functionPanelButton._ThirdOffice.SetActive(false);
                _mainGameMechanics.MinMoneyRandom = 8000;
                _mainGameMechanics.MaxMoneyRandom = 16000;

                if (_crisis.ActiveCrisis != true)
                {
                    _mainGameMechanics.MinMoneyRandom = 1200;
                    _mainGameMechanics.MaxMoneyRandom = 4000;
                }
            }

            if (upgradeTreeData.Level == 3)
            {
                _functionPanelButton._ThirdOffice.SetActive(true);
                _functionPanelButton._SecondOffice.SetActive(false);
                _functionPanelButton._FirstOffice.SetActive(false);
                _mainGameMechanics.MinMoneyRandom = 16000;
                _mainGameMechanics.MaxMoneyRandom = 32000;

                if (_crisis.ActiveCrisis != true)
                {
                    _mainGameMechanics.MinMoneyRandom = 4200;
                    _mainGameMechanics.MaxMoneyRandom = 8000;
                }
            }          
            yield return new WaitForSeconds(310);
        }
    }
    public void DesignMyOSButton() //Design button
    {
        Debug.Log("Design");
        if (_mainGameMechanics.RecearchPoint >= upgradeTreeData.Cost)
        {
            Debug.Log("Прошло");
            _mainGameMechanics.RecearchPoint -= (ushort)upgradeTreeData.Cost;
            upgradeTreeData.Level++;
            _TextLevelMyOSUpgrade.text = "Level " + upgradeTreeData.Level.ToString();
            _CostMyOSUpgrade.text = upgradeTreeData.Cost.ToString();
            _myOSpanel.RatingOS += (ushort)upgradeTreeData.RatingOS;
        }
    }
    public void AnimationMyOSButton() //Animation button
    {
        if (_mainGameMechanics.RecearchPoint >= upgradeTreeData.Cost)
        {
            Debug.Log("Animation");
            _mainGameMechanics.RecearchPoint -= (ushort)upgradeTreeData.Cost;
            upgradeTreeData.Level++;
            _TextLevelMyOSUpgrade.text = "Level " + upgradeTreeData.Level.ToString();
            _CostMyOSUpgrade.text = upgradeTreeData.Cost.ToString();
            _myOSpanel.RatingOS += (ushort)upgradeTreeData.RatingOS;
        }
    }
    public void UsabilityMyOSButton() //Usability button
    {
        if (_mainGameMechanics.RecearchPoint >= upgradeTreeData.Cost)
        {
            Debug.Log("Usability");
            _mainGameMechanics.RecearchPoint -= (ushort)upgradeTreeData.Cost;
            upgradeTreeData.Level++;
            _TextLevelMyOSUpgrade.text = "Level " + upgradeTreeData.Level.ToString();
            _CostMyOSUpgrade.text = upgradeTreeData.Cost.ToString();
            _myOSpanel.RatingOS += (ushort)upgradeTreeData.RatingOS;
        }
    }
    public void WorkSpeedMyOSButton() //Work Speed button
    {
        if (_mainGameMechanics.RecearchPoint >= upgradeTreeData.Cost)
        {
            Debug.Log("Work Speed");
            _mainGameMechanics.RecearchPoint -= (ushort)upgradeTreeData.Cost;
            upgradeTreeData.Level++;
            _TextLevelMyOSUpgrade.text = "Level " + upgradeTreeData.Level.ToString();
            _CostMyOSUpgrade.text = upgradeTreeData.Cost.ToString();
            _myOSpanel.RatingOS += (ushort)upgradeTreeData.RatingOS;
        }
    }
    public void AutonomyMyOSButton()
    {
        if (_mainGameMechanics.RecearchPoint >= upgradeTreeData.Cost)
        {
            Debug.Log("Autonomy");
            _mainGameMechanics.RecearchPoint -= (ushort)upgradeTreeData.Cost;
            upgradeTreeData.Level++;
            _TextLevelMyOSUpgrade.text = "Level " + upgradeTreeData.Level.ToString();
            _CostMyOSUpgrade.text = upgradeTreeData.Cost.ToString();
            _myOSpanel.RatingOS += (ushort)upgradeTreeData.RatingOS;
        }
    }
    public void OptimizationMyOSButton()
    {
        if (_mainGameMechanics.RecearchPoint >= upgradeTreeData.Cost)
        {
            Debug.Log("Optimization");
            _mainGameMechanics.RecearchPoint -= (ushort)upgradeTreeData.Cost;
            upgradeTreeData.Level++;
            _TextLevelMyOSUpgrade.text = "Level " + upgradeTreeData.Level.ToString();
            _CostMyOSUpgrade.text = upgradeTreeData.Cost.ToString();
            _myOSpanel.RatingOS += (ushort)upgradeTreeData.RatingOS;
        }
    }
    public void FunctionalMyOSButton()
    {
        if (_mainGameMechanics.RecearchPoint >= upgradeTreeData.Cost)
        {
            Debug.Log("Functional");
            _mainGameMechanics.RecearchPoint -= (ushort)upgradeTreeData.Cost;
            upgradeTreeData.Level++;
            _TextLevelMyOSUpgrade.text = "Level " + upgradeTreeData.Level.ToString();
            _CostMyOSUpgrade.text = upgradeTreeData.Cost.ToString();
            _myOSpanel.RatingOS += (ushort)upgradeTreeData.RatingOS;
        }
    }
    public void SafetyMyOSButton()
    {
        if (_mainGameMechanics.RecearchPoint >= upgradeTreeData.Cost)
        {
            Debug.Log("Safety");
            _mainGameMechanics.RecearchPoint -= (ushort)upgradeTreeData.Cost;
            upgradeTreeData.Level++;
            _TextLevelMyOSUpgrade.text = "Level " + upgradeTreeData.Level.ToString();
            _CostMyOSUpgrade.text = upgradeTreeData.Cost.ToString();
            _myOSpanel.RatingOS += (ushort)upgradeTreeData.RatingOS;
        }
    }
    public void MultilingualismMyOSButton()
    {
        if (_mainGameMechanics.RecearchPoint >= upgradeTreeData.Cost)
        {
            Debug.Log("Multilingualism");
            _mainGameMechanics.RecearchPoint -= (ushort)upgradeTreeData.Cost;
            upgradeTreeData.Level++;
            _TextLevelMyOSUpgrade.text = "Level " + upgradeTreeData.Level.ToString();
            _CostMyOSUpgrade.text = upgradeTreeData.Cost.ToString();
            _myOSpanel.RatingOS += (ushort)upgradeTreeData.RatingOS;
        }
    }
    public void AIMyOSButton()
    {
        if (_mainGameMechanics.RecearchPoint >= upgradeTreeData.Cost)
        {
            Debug.Log("AI");
            _mainGameMechanics.RecearchPoint -= (ushort)upgradeTreeData.Cost;
            upgradeTreeData.Level++;
            _TextLevelMyOSUpgrade.text = "Level " + upgradeTreeData.Level.ToString();
            _CostMyOSUpgrade.text = upgradeTreeData.Cost.ToString();
            _myOSpanel.RatingOS += (ushort)upgradeTreeData.RatingOS;
        }
    }
    public void AppStoreMyOSButton()
    {
        if (_mainGameMechanics.RecearchPoint >= upgradeTreeData.Cost)
        {
            Debug.Log("App Store");
            _mainGameMechanics.RecearchPoint -= (ushort)upgradeTreeData.Cost;
            upgradeTreeData.Level++;
            _TextLevelMyOSUpgrade.text = "Level " + upgradeTreeData.Level.ToString();
            _CostMyOSUpgrade.text = upgradeTreeData.Cost.ToString();
            _myOSpanel.RatingOS += (ushort)upgradeTreeData.RatingOS;
        }
    }
    
}
