using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;

public class SaveSystem : MonoBehaviour
{
    [SerializeField] private MainGameMechanics _mainGameMechanics;
    [SerializeField] private FunctionPanelButton _functionPanelButton;
    [SerializeField] private LocalizationManager _localizationManager;

    [SerializeField] private GameData _gameData;
    [SerializeField] private CompanyNameInputField _companyName;
    private UpgradeTreeData _upgradeTreeData;
    private UpgradeTree _upgradeTree;
    [SerializeField] private Laboratory _laboratory;
    [SerializeField] private OfficeUpgrade _officeUpgrade;
    [SerializeField] private RealtorUpgrade _realtorUpgrade;
    private MarketingSettings _marketingSettings;
    [SerializeField] private CreateLaptop _createLaptop;
    [SerializeField] private BuyLabUpgrade _buyLabUpgrade;
    [SerializeField] private OpenOS _openOS;

    public GameObject loadingPanelStart;
    [SerializeField] private Text _textLoading;

    private void Awake() { StartCoroutine(loadingSavePlayer()); StartCoroutine(loadingTextAnimation()); }

    private void Update()
    {
        PlayerPrefs.SetFloat("MoneyPlayer", (float)_mainGameMechanics.Money);
        PlayerPrefs.SetFloat("FunPlayer", (float)_mainGameMechanics.Fun);
        PlayerPrefs.SetInt("RecearchPointPlayer", _mainGameMechanics.RecearchPoint);
        PlayerPrefs.SetInt("DateDay", _gameData.Day);
        PlayerPrefs.SetInt("DateMonth", _gameData.Month);
        PlayerPrefs.SetInt("DateYear", (int)_gameData.Year);
        PlayerPrefs.SetInt("Cost upgrade", (int)_upgradeTreeData.Cost);
        PlayerPrefs.SetInt("Level upgrade", _upgradeTreeData.Level);
        PlayerPrefs.SetInt("Realtor company upgrade", _upgradeTreeData.RealtorCompany);
        PlayerPrefs.SetInt("OfficeStaffs upgrade", _upgradeTreeData.OfficeStafs);
    }

    IEnumerator loadingTextAnimation()
    {
        while(true)
        {           
            yield return new WaitForSeconds(0.5f);
            _textLoading.text = _localizationManager.translateLoadingText;
            yield return new WaitForSeconds(0.5f);
            _textLoading.text = _localizationManager.translateLoadingText + ".";
            yield return new WaitForSeconds(0.5f);
            _textLoading.text = _localizationManager.translateLoadingText + "..";
            yield return new WaitForSeconds(0.5f);
            _textLoading.text = _localizationManager.translateLoadingText + "...";
        }
    }

    IEnumerator loadingSavePlayer()
    {
        while(true)
        {
            loadingPanelStart.SetActive(true);
            if (PlayerPrefs.HasKey("MoneyPlayer")) _mainGameMechanics.Money = PlayerPrefs.GetFloat("MoneyPlayer");
            if (PlayerPrefs.HasKey("FunPlayer")) _mainGameMechanics.Fun = PlayerPrefs.GetFloat("FunPlayer");
            if (PlayerPrefs.HasKey("NameCompany")) _companyName.NameCompany = PlayerPrefs.GetString("NameCompany");
            if (PlayerPrefs.HasKey("MyCompanys")) _mainGameMechanics.MyCompanys = (byte)PlayerPrefs.GetInt("MyCompanys");
            if (PlayerPrefs.HasKey("ownLaptopCompany")) _createLaptop.ownLaptopCompany = PlayerPrefs.GetInt("ownLaptopCompany");
            else _createLaptop.ownLaptopCompany = 0;
            if (PlayerPrefs.HasKey("maxStaffs")) _mainGameMechanics.maxStaffsPlayer = (byte)PlayerPrefs.GetInt("maxStaffs");
            else _mainGameMechanics.maxStaffsPlayer = 4;
            if (PlayerPrefs.HasKey("levelRealtorSave")) _realtorUpgrade.levelRealtor = (byte)PlayerPrefs.GetInt("levelRealtorSave");
            else _realtorUpgrade.levelRealtor = 1;
            if (PlayerPrefs.HasKey("costRealtorSave")) _realtorUpgrade.costRealtor = (byte)PlayerPrefs.GetInt("costRealtorSave");
            else _realtorUpgrade.costRealtor = 40;
            if (PlayerPrefs.HasKey("ownRealtorSave")) _realtorUpgrade.ownCompany = (byte)PlayerPrefs.GetInt("ownRealtorSave");
            else _realtorUpgrade.ownCompany = 2;
            if (PlayerPrefs.HasKey("officeLevelSave"))
            {
                _officeUpgrade.levelOffice = (byte)PlayerPrefs.GetInt("officeLevelSave");
                if (_officeUpgrade.levelOffice == 2) { _functionPanelButton._FirstOffice.SetActive(false); _functionPanelButton._SecondOffice.SetActive(true); }
                if (_officeUpgrade.levelOffice == 3) { _functionPanelButton._SecondOffice.SetActive(false); _functionPanelButton._ThirdOffice.SetActive(true); }
            }
            if (PlayerPrefs.HasKey("StaffPlayer")) _mainGameMechanics.staffsPlayer = (byte)PlayerPrefs.GetInt("StaffPlayer");
            if (PlayerPrefs.HasKey("ExpenditureStaff")) _mainGameMechanics.ExpenditureStaff = PlayerPrefs.GetInt("ExpenditureStaff");
            if (PlayerPrefs.HasKey("DateDay")) _gameData.Day = (byte)PlayerPrefs.GetInt("DateDay");
            if (PlayerPrefs.HasKey("DateMonth")) _gameData.Month = (byte)PlayerPrefs.GetInt("DateMonth");
            if (PlayerPrefs.HasKey("DateYear")) _gameData.Year = (ushort)PlayerPrefs.GetInt("DateYear");
            if (PlayerPrefs.HasKey("IncomePlayer"))
            {
                _mainGameMechanics._IncomeCumulative = PlayerPrefs.GetInt("IncomePlayer");
                _mainGameMechanics._TextIncomeCumulative.text = "+ $" + _mainGameMechanics._IncomeCumulative.ToString(_mainGameMechanics.NumberFormate) + " / 6M";
            }
            if (PlayerPrefs.HasKey("ExpenditurePlayer"))
            {
                _mainGameMechanics._ExpenditureCumulative = PlayerPrefs.GetInt("ExpenditurePlayer");
                _mainGameMechanics._TextExpenditureCumulative.text = "- " + "$" + _mainGameMechanics._ExpenditureCumulative.ToString(_mainGameMechanics.NumberFormate) + " / 6M";
            }
            if (PlayerPrefs.HasKey("Cost upgrade"))
            {
                _upgradeTreeData.Cost = PlayerPrefs.GetInt("Cost upgrade");
                _upgradeTree._textCostRealtorUpgrade.text = PlayerPrefs.GetInt("Cost upgrade").ToString();
            }
            if (PlayerPrefs.HasKey("Level upgrade")) _upgradeTreeData.Level = PlayerPrefs.GetInt("Level upgrade");
            if (PlayerPrefs.HasKey("Realtor company upgrade")) _upgradeTreeData.RealtorCompany = PlayerPrefs.GetInt("Realtor company upgrade");
            if (PlayerPrefs.HasKey("OfficeStaffs upgrade")) _upgradeTreeData.OfficeStafs = PlayerPrefs.GetInt("OfficeStaffs upgrade");
            if (PlayerPrefs.HasKey("saveLab")) _buyLabUpgrade.saveLabBuy = (byte)PlayerPrefs.GetInt("saveLab");
            if (PlayerPrefs.HasKey("incomeLabSave")) _laboratory.IncomeLaboratoryRP = (byte)PlayerPrefs.GetInt("incomeLabSave");
            if (PlayerPrefs.HasKey("expenditureLabSave")) _laboratory.ExpenditureLaboratory = (uint)PlayerPrefs.GetInt("expenditureLabSave");
            if (PlayerPrefs.HasKey("ActiveOS"))
            {
                _upgradeTree.ActiveOS = (byte)PlayerPrefs.GetInt("ActiveOS");
                _upgradeTree._textUnlockMyOSUpgrade.text = "Unlock";
            }
            Debug.Log("loading open OS");
            if (PlayerPrefs.HasKey("saveOpenOS")) _openOS._activeOSUpgrade = (byte)PlayerPrefs.GetInt("saveOpenOS");
            yield return new WaitForSeconds(6);
            loadingPanelStart.SetActive(false);
            StopCoroutine(loadingTextAnimation());
            _functionPanelButton.MainPanel.SetActive(true);
            _functionPanelButton.ButtonStartMenu.SetActive(true);
            _functionPanelButton.ButtonSettingMenu.SetActive(true);
            _functionPanelButton.ButtonQuitMenu.SetActive(true);
            _functionPanelButton.textLaptopTycoon.SetActive(true);
            _textLoading.text = "";
            yield break;
        }
    }
}
