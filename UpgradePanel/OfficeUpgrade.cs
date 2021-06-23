using UnityEngine;
using UnityEngine.UI;

public class OfficeUpgrade : MonoBehaviour
{
    [Header("Доступы")]
    [SerializeField] private MainGameMechanics _mainGameMechanics;
    [SerializeField] private FunctionPanelButton _functionPanelButton;
    [SerializeField] private LocalizationManager _localizationManager;

    [SerializeField] private string _officeName;
    [SerializeField] private Text _textOfficeName;
    public byte levelOffice;
    [SerializeField] private Text _textLevelOffice;
    [SerializeField] private int _costOffice;
    [SerializeField] private Text _textOfficeCost;

    void Start()
    {
        if (PlayerPrefs.HasKey("officeLevelSave")) levelOffice = (byte)PlayerPrefs.GetInt("officeLevelSave");
        _costOffice = 50000000;
        _textLevelOffice.text = _localizationManager.translateMarketingLevel + " " + levelOffice.ToString();
        _textOfficeCost.text = "$ 50M";
    }

    private void officeClick()
    {
        _mainGameMechanics.Money -= _costOffice;
        levelOffice += 1;
        _mainGameMechanics.maxStaffsPlayer += 4;
        _textLevelOffice.text = _localizationManager.translateMarketingLevel + " " + levelOffice.ToString();
        PlayerPrefs.SetInt("officeLevelSave", levelOffice);
        PlayerPrefs.SetInt("maxStaffs", _mainGameMechanics.maxStaffsPlayer);
    }

    private void Update()
    {
        if (levelOffice >= 5)
        {
            _textLevelOffice.enabled = false;
            _textOfficeCost.text = "Max";
            _textOfficeCost.color = new Color(255, 255, 255);
        }      
    }

    public void OfficeUpgradeButton()
    {
        if (_mainGameMechanics.Money >= _costOffice)
        {
            if (levelOffice <= 5)
            {
                officeClick();
                if (levelOffice == 2) { _functionPanelButton._SecondOffice.SetActive(true); _functionPanelButton._FirstOffice.SetActive(false); }
                else if (levelOffice == 3) { _functionPanelButton._ThirdOffice.SetActive(true); _functionPanelButton._SecondOffice.SetActive(false); }
                else if (levelOffice == 4) { _functionPanelButton._ThirdOffice.SetActive(false); _functionPanelButton._FourthOffice.SetActive(true); }
                else { _functionPanelButton._FourthOffice.SetActive(false); _functionPanelButton._FifthOffice.SetActive(true); }
            }                   
        }
    }
}
