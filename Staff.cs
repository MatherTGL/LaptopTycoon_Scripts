using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;
public class Staff : MonoBehaviour
{
    [Header("Доступ к другим скриптам")]
    [SerializeField] private MainGameMechanics _mainGameMechanics;
    [SerializeField] private FunctionPanelButton _functionPanelButton;
    [SerializeField] private UpgradeTreeData _upgradeTreeData;
    [SerializeField] private LocalizationManager _localizationManager;
    [SerializeField] private Quest _quest;
    [SerializeField] private adsManagerScr _adsManagerScr;

    [Header("Возраст рабочего")]
    [SerializeField] private byte _AgeStaff;
    [SerializeField] private Text _TextAgeStaff;
    [Header("Стоимость рабочего")]
    [SerializeField] private ushort _SalaryStaff;
    [SerializeField] private Text _TextSalaryStaff;
    [Header("Рейтинг рабочего")]
    [SerializeField] private byte _RatingStaff;
    [SerializeField] private Text _TextRatingStaff;
    [Header("Стаж рабочего")]
    [SerializeField] private byte _ExperienceStaff;
    [SerializeField] private Text _TextExperienceStaff;
    [Header("Approve text")]
    [SerializeField] private Text _textApproveStaff;
    [SerializeField] private Button _buttonApproveStaff;
    [SerializeField] private ColorBlock _FullStaffColor, _ApproveStaffColor;

    [SerializeField] private byte _AvatarStaff = 0;
    [Header("Аватарки")]
    [SerializeField] private Image _maleAvatar;
    [SerializeField] private Image _femaleAvatar;

    [SerializeField] private byte _nameStaffs = 64;
    [SerializeField] private Text _textNameStaffs;

    private void nameStaffsSettings()
    {
        switch(_nameStaffs)
        {
            case 1:
                _textNameStaffs.text = "Olivia";
                break;
            case 2:
                _textNameStaffs.text = "Ava";
                break;
            case 3:
                _textNameStaffs.text = "Amelia";
                break;
            case 4:
                _textNameStaffs.text = "Emily";
                break;
            case 5:
                _textNameStaffs.text = "Jessica";
                break;
            case 6:
                _textNameStaffs.text = "Isla";
                break;
            case 7:
                _textNameStaffs.text = "Isabella";
                break;
            case 8:
                _textNameStaffs.text = "Poppy";
                break;
            case 9:
                _textNameStaffs.text = "Mia";
                break;
            case 10:
                _textNameStaffs.text = "Sophie";
                break;
            case 11:
                _textNameStaffs.text = "Lily";
                break;
            case 12:
                _textNameStaffs.text = "Ruby";
                break;
            case 13:
                _textNameStaffs.text = "Evie";
                break;
            case 14:
                _textNameStaffs.text = "Grace";
                break;
            case 15:
                _textNameStaffs.text = "Ella";
                break;
            case 16:
                _textNameStaffs.text = "Sophia";
                break;
            case 17:
                _textNameStaffs.text = "Chloe";
                break;
            case 18:
                _textNameStaffs.text = "Scarlett";
                break;
            case 19:
                _textNameStaffs.text = "Freya";
                break;
            case 20:
                _textNameStaffs.text = "Isabelle";
                break;
            case 21:
                _textNameStaffs.text = "Phoebe";
                break;
            case 22:
                _textNameStaffs.text = "Alice";
                break;
            case 23:
                _textNameStaffs.text = "Ellie";
                break;
            case 24:
                _textNameStaffs.text = "Bethany";
                break;
            case 25:
                _textNameStaffs.text = "Lara Croft";
                break;
            case 26:
                _textNameStaffs.text = "Heidi";
                break;
            case 27:
                _textNameStaffs.text = "Paige";
                break;
            case 28:
                _textNameStaffs.text = "Faith";
                break;
            case 29:
                _textNameStaffs.text = "Rose";
                break;
            case 30:
                _textNameStaffs.text = "Ivy";
                break;
            case 31:
                _textNameStaffs.text = "Florence";
                break;
            case 32:
                _textNameStaffs.text = "Hurriet";
                break;
            case 33:
                _textNameStaffs.text = "Maddison";
                break;
            case 34:
                _textNameStaffs.text = "Zoe";
                break;
            case 35:
                _textNameStaffs.text = "Samuel";
                break;
            case 36:
                _textNameStaffs.text = "Jack";
                break;
            case 37:
                _textNameStaffs.text = "Joseph";
                break;
            case 38:
                _textNameStaffs.text = "Harry";
                break;
            case 39:
                _textNameStaffs.text = "Alfie";
                break;
            case 40:
                _textNameStaffs.text = "Jacob";
                break;
            case 41:
                _textNameStaffs.text = "Thomas Shelby";
                break;
            case 42:
                _textNameStaffs.text = "Charlie";
                break;
            case 43:
                _textNameStaffs.text = "Vaas Montenegro";
                break;
            case 44:
                _textNameStaffs.text = "Oscar";
                break;
            case 45:
                _textNameStaffs.text = "Alisher Nasyrov";
                break;
            case 46:
                _textNameStaffs.text = "William";
                break;
            case 47:
                _textNameStaffs.text = "Danila Leonov";
                break;
            case 48:
                _textNameStaffs.text = "George";
                break;
            case 49:
                _textNameStaffs.text = "Ethan";
                break;
            case 50:
                _textNameStaffs.text = "Noah";
                break;
            case 51:
                _textNameStaffs.text = "Archie";
                break;
            case 52:
                _textNameStaffs.text = "Henry";
                break;
            case 53:
                _textNameStaffs.text = "Leo";
                break;
            case 54:
                _textNameStaffs.text = "Mikhail Uskov";
                break;
            case 55:
                _textNameStaffs.text = "David";
                break;
            case 56:
                _textNameStaffs.text = "Ryan";
                break;
            case 57:
                _textNameStaffs.text = "Denis Panteleev";
                break;
            case 58:
                _textNameStaffs.text = "Connor";
                break;
            case 59:
                _textNameStaffs.text = "Stanley";
                break;
            case 60:
                _textNameStaffs.text = "Austin";
                break;
            case 61:
                _textNameStaffs.text = "Theodore";
                break;
            case 62:
                _textNameStaffs.text = "Owen";
                break;
            case 63:
                _textNameStaffs.text = "Caleb";
                break;
            case 64:
                _textNameStaffs.text = "Albert";
                break;
        }
    }

    private void Start()
    {
        CheckRandomSettingStaff();
        _TextSalaryStaff.text = "$" + _SalaryStaff.ToString() + " / D";
        _TextAgeStaff.text = _AgeStaff.ToString() + " years";
        _TextRatingStaff.text = _RatingStaff.ToString() + " / 10";
        _TextExperienceStaff.text = _ExperienceStaff.ToString() + " years";
    }

    void OnEnable()
    {
        updatingTextStaffPanel();
        CheckRandomSettingStaff();
    }

    private void Update() { updatingTextStaffPanel(); }

    private void updatingTextStaffPanel()
    {
        if (_functionPanelButton._StaffPanel.activeSelf)
        {
            if (_mainGameMechanics.staffsPlayer < _mainGameMechanics.maxStaffsPlayer)
            {
                _textApproveStaff.text = _localizationManager.translateApproveStaff;
                _buttonApproveStaff.colors = _ApproveStaffColor;
                nameStaffsSettings();
            }
            else { _textApproveStaff.text = "Max"; _buttonApproveStaff.colors = _FullStaffColor; nameStaffsSettings(); }

            _mainGameMechanics.textStaffsPlayer.text = _mainGameMechanics.staffsPlayer + " / " + _mainGameMechanics.maxStaffsPlayer;
            if (_mainGameMechanics.ExpenditureStaff >= 1) _mainGameMechanics._TextExpenditureStaff.text = "- $" + _mainGameMechanics.ExpenditureStaff.ToString(_mainGameMechanics.NumberFormate);
            else _mainGameMechanics._TextExpenditureStaff.text = "$" + _mainGameMechanics.ExpenditureStaff.ToString();
        }
    }

    private void checkAvatar()
    {
        _AvatarStaff = (byte)Random.Range(1, 3);
        if (_AvatarStaff == 1) { _maleAvatar.enabled = true; _femaleAvatar.enabled = false; _nameStaffs = (byte)Random.Range(32, 64); }
        else if (_AvatarStaff == 2) { _maleAvatar.enabled = false; _femaleAvatar.enabled = true; _nameStaffs = (byte)Random.Range(1, 32); }
    }

    public void BuyStaffButton()
    {
        if (_mainGameMechanics.maxStaffsPlayer > _mainGameMechanics.staffsPlayer)
        {
            if (_mainGameMechanics.Money >= _SalaryStaff)
            {               
                if (_adsManagerScr.checkBuyAd != true)
                {
                    _mainGameMechanics.Money -= _SalaryStaff;
                    _TextSalaryStaff.text = "$" + _SalaryStaff.ToString() + " / D";
                    _mainGameMechanics.ExpenditureStaff += _SalaryStaff;
                    _mainGameMechanics.staffsPlayer++;
                    _TextAgeStaff.text = _AgeStaff.ToString() + " years";
                    _TextRatingStaff.text = _RatingStaff.ToString() + " / 10";
                    _TextExperienceStaff.text = _ExperienceStaff.ToString() + " years";
                    CheckRandomSettingStaff();
                    _quest.checkQuest();
                    PlayerPrefs.SetInt("StaffPlayer", _mainGameMechanics.staffsPlayer);
                    PlayerPrefs.SetInt("ExpenditureStaff", (int)_mainGameMechanics.ExpenditureStaff);
                    updatingTextStaffPanel();
                    if (_mainGameMechanics.staffsPlayer == 3) { if (Advertisement.IsReady()) { Advertisement.Show("video"); } }
                    else if (_mainGameMechanics.staffsPlayer == 7) { if (Advertisement.IsReady()) { Advertisement.Show("video"); } }
                    else if (_mainGameMechanics.staffsPlayer == 11) { if (Advertisement.IsReady()) { Advertisement.Show("video"); } }
                    else if (_mainGameMechanics.staffsPlayer == 15) { if (Advertisement.IsReady()) { Advertisement.Show("video"); } }
                    else if (_mainGameMechanics.staffsPlayer == 19) { if (Advertisement.IsReady()) { Advertisement.Show("video"); } }
                }
                else
                {
                    _mainGameMechanics.Money -= _SalaryStaff;
                    _TextSalaryStaff.text = "$" + _SalaryStaff.ToString() + " / D";
                    _mainGameMechanics.ExpenditureStaff += _SalaryStaff;
                    _mainGameMechanics.staffsPlayer++;
                    _TextAgeStaff.text = _AgeStaff.ToString() + " years";
                    _TextRatingStaff.text = _RatingStaff.ToString() + " / 10";
                    _TextExperienceStaff.text = _ExperienceStaff.ToString() + " years";
                    CheckRandomSettingStaff();
                    _quest.checkQuest();
                    PlayerPrefs.SetInt("StaffPlayer", _mainGameMechanics.staffsPlayer);
                    PlayerPrefs.SetInt("ExpenditureStaff", (int)_mainGameMechanics.ExpenditureStaff);
                    updatingTextStaffPanel();
                }
            }
        }        
    }

    private void CheckRandomSettingStaff()
    {
        _AgeStaff = (byte)Random.Range(18, 40);
        _RatingStaff = (byte)Random.Range(1, 10);
        checkAvatar();

        if (_RatingStaff <= 3) { _SalaryStaff = (ushort)Random.Range(1000, 3000); }
        else if (_RatingStaff <= 6) { _SalaryStaff = (ushort)Random.Range(4000, 10000); }
        else if (_RatingStaff <= 9) { _SalaryStaff = (ushort)Random.Range(10000, 17000); }
        else { _SalaryStaff = (ushort)Random.Range(15000, 20000); }

        if (_AgeStaff <= 18) { _ExperienceStaff = (byte)Random.Range(1, 3); }
        else if (_AgeStaff <= 23) { _ExperienceStaff = (byte)Random.Range(1, 6); }
        else if (_AgeStaff <= 30) { _ExperienceStaff = (byte)Random.Range(1, 15); }
        else if (_AgeStaff <= 40) { _ExperienceStaff = (byte)Random.Range(1, 23); }
        else { _ExperienceStaff = (byte)Random.Range(1, 27); }

        _TextSalaryStaff.text = "$" + _SalaryStaff.ToString() + " / D";
        _TextAgeStaff.text = _AgeStaff.ToString() + " years";
        _TextRatingStaff.text = _RatingStaff.ToString() + " / 10";
        _TextExperienceStaff.text = _ExperienceStaff.ToString() + " years";
        updatingTextStaffPanel();
    }
}
