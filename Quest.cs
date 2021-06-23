using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Quest : MonoBehaviour
{
    [SerializeField] private MainGameMechanics _mainGameMechanics;
    [SerializeField] private FunctionPanelButton _functionPanelButton;
    [SerializeField] private OfficeUpgrade _officeUpgrade;
    [SerializeField] private LocalizationManager _localizationManager;
    [SerializeField] private pushQuestManager _pushQuestManager;

    [SerializeField] private AudioSource _completedQuestPushAudio;

    [SerializeField] private Color _pushCyrcleColor;
    public Color pushCyrcleDefaultColor;

    [Header("Условие")]
    public string _condition;
    [Header("Условие текст")]
    public Text _textCondition;
    [Header("Сколько надо")]
    public double _must;
    [SerializeField] private Text _textMust;
    [Header("Вознаграждение")]
    public int _reward;
    [Header("Вознаграждение текст")]
    public Text _textReward;
    [Header("Завершено")]
    public bool _completed;
    [SerializeField] private byte _completedSave;
    [Header("RP or Money")]
    public bool _typeReward; //true = RP, false = Money
    [Header("Пустышка для GC")]
    public GameObject _GcObjectQuest;

    [Header("Employees")]
    public byte employeesMust;

    [SerializeField] private UnityEvent OnQuest;

    private void Start()
    {
        if (_condition == "Office")
        {
            if (PlayerPrefs.HasKey("mustQuestOffice"))
            {
                _must = PlayerPrefs.GetInt("mustQuestOffice");
                _reward = PlayerPrefs.GetInt("rewardQuestOffice");
                _completedSave = (byte)PlayerPrefs.GetInt("completedAccumulateOfficeSave");
                if (_officeUpgrade.levelOffice < 5) { _textReward.text = "RP " + _reward.ToString("#.#"); }
                else if (_officeUpgrade.levelOffice >= 5)
                {
                    _textMust.text = _localizationManager.translateOfficeQuest;
                    if (_localizationManager._indexLanguage == 1) { _textReward.text = "Completed"; }
                    else { _textReward.text = "Выполнено"; }
                    _completed = true;
                }
            }
        }
        if (_condition == "Accumulate funs")
        {
            if (PlayerPrefs.HasKey("mustQuestFuns"))
            {
                _must = PlayerPrefs.GetInt("mustQuestFuns");
                _reward = PlayerPrefs.GetInt("rewardQuestFuns");
                _completedSave = (byte)PlayerPrefs.GetInt("completedAccumulateFunSave");
                if (_completed != true) { _textReward.text = "RP " + _reward.ToString("#.#"); }
                else
                {
                    _textMust.text = _localizationManager.translateFanQuest;
                    if (_localizationManager._indexLanguage == 1) { _textReward.text = "Completed"; }
                    else { _textReward.text = "Выполнено"; }
                    _completed = true;
                }
            }
        }
        if (_condition == "Open Present Box")
        {
            if (PlayerPrefs.HasKey("mustQuestPresent"))
            {
                _must = PlayerPrefs.GetInt("mustQuestPresent");
                _reward = PlayerPrefs.GetInt("rewardQuestPresent");
                _completedSave = (byte)PlayerPrefs.GetInt("completedAccumulatePresentSave");

                if (_completedSave == 0)
                {
                    _textMust.text = _localizationManager.translatePresentBox;
                    _textReward.text = "RP " + _reward.ToString("#.#");
                }
                else
                {
                    _textMust.text = _localizationManager.translatePresentBox;
                    if (_localizationManager._indexLanguage == 1) { _textReward.text = "Completed"; }
                    else { _textReward.text = "Выполнено"; }
                    _completed = true;
                }
            }
        }
        if (_condition == "Buy Company")
        {
            if (PlayerPrefs.HasKey("mustQuestCompany"))
            {
                _must = PlayerPrefs.GetInt("mustQuestCompany");
                _reward = PlayerPrefs.GetInt("rewardQuestCompany");
                _completedSave = (byte)PlayerPrefs.GetInt("completedAccumulateCompanySave");

                if (_completedSave == 0)
                {
                    _textMust.text = _localizationManager.translateBuyCompany;
                    _textReward.text = "RP " + _reward.ToString("#.#");
                }
                else
                {
                    _textMust.text = _localizationManager.translateBuyCompany;
                    if (_localizationManager._indexLanguage == 1) { _textReward.text = "Completed"; }
                    else { _textReward.text = "Выполнено"; }
                    _completed = true;
                }
            }
        }
        if (_condition == "Employees")
        {
            if (PlayerPrefs.HasKey("mustQuestEmployees"))
            {
                _must = PlayerPrefs.GetInt("mustQuestEmployees");
                _reward = PlayerPrefs.GetInt("rewardQuestEmployees");
                _completedSave = (byte)PlayerPrefs.GetInt("completedAccumulateEmployeesSave");
                if (_completedSave <= 5)
                {
                    _textMust.text = employeesMust + _localizationManager.translateEmployees;
                    _textReward.text = "RP " + _reward.ToString("#.#");
                }
                else
                {
                    _textMust.text = _localizationManager.translateEmployees;
                    if (_localizationManager._indexLanguage == 1) { _textReward.text = "Completed"; }
                    else { _textReward.text = "Выполнено"; }
                    _completed = true;
                }
            }
        }
        if (_condition == "Crisis")
        {
            if (PlayerPrefs.HasKey("mustQuestCrisis"))
            {
                _must = PlayerPrefs.GetInt("mustQuestCrisis");
                _reward = PlayerPrefs.GetInt("rewardQuestCrisis");
                _completedSave = (byte)PlayerPrefs.GetInt("completedAccumulateCrisisSave");

                if (_completedSave == 0)
                {
                    _textMust.text = _localizationManager.translateSurviveCrisis;
                    _textReward.text = "RP " + _reward.ToString("#.#");
                }
                else
                {
                    _textMust.text = _localizationManager.translateSurviveCrisis;
                    if (_localizationManager._indexLanguage == 1) { _textReward.text = "Completed"; }
                    else { _textReward.text = "Выполнено"; }
                    _completed = true;
                }
            }
        }
    }

    private void Update()
    {
        if (_condition == "Office") 
        { 
            if (_officeUpgrade.levelOffice >= _must) { if (_completed != true) { OnQuest.Invoke(); } }
            _textMust.text = _localizationManager.translateOfficeQuest + _must + _localizationManager.translateOfficeQuestLevel;
        }
        if (_condition == "Accumulate funs")
        {
            if (_mainGameMechanics.Fun >= _must) { if (_reward <= 150) { if (_completed != true) { OnQuest.Invoke(); } } }
            _textMust.text = _must.ToString("#,#") + _localizationManager.translateFanQuest;
        }

        if (_condition == "Employees")
        {
            if (employeesMust >= 24)
            {
                _textMust.text = _localizationManager.translateEmployees;
                if (_localizationManager._indexLanguage == 1) { _textReward.text = "Completed"; }
                else { _textReward.text = "Выполнено"; }
                _completed = true;
            }
            else { _textMust.text = employeesMust + _localizationManager.translateEmployees; }
        }
    }

    public void checkQuest()
    {   
        if (_condition == "Accumulate funs")
        {
            if (_must != 102400000)
            {
                _mainGameMechanics.RecearchPoint += (ushort)_reward;
                _completedSave++;
                _must *= 2;
                _textReward.text = "RP " + _reward;
                _completedQuestPushAudio.Play();
                _pushQuestManager._questImageButton.color = _pushCyrcleColor;
                PlayerPrefs.SetInt("completedAccumulateFunSave", _completedSave);
                PlayerPrefs.SetInt("mustQuestFuns", (int)_must);
                PlayerPrefs.SetInt("rewardQuestFuns", _reward);
                PlayerPrefs.SetString("conditionSaveQuestFuns", _condition);
            }
            else
            {
                _textMust.text = _localizationManager.translateFanQuest;
                _textReward.text = "Completed";
                _completed = true;
            }
        }
        if (_condition == "Office")
        {
            if (_officeUpgrade.levelOffice < 5)
            {
                _mainGameMechanics.RecearchPoint += (ushort)_reward;
                _completedSave++;
                _must += 1;
                _reward += 5;
                _textReward.text = "RP " + _reward.ToString("#.#");
                _completedQuestPushAudio.Play();
                _pushQuestManager._questImageButton.color = _pushCyrcleColor;
                PlayerPrefs.SetInt("completedAccumulateOfficeSave", _completedSave);
                PlayerPrefs.SetInt("mustQuestOffice", (int)_must);
                PlayerPrefs.SetInt("rewardQuestOffice", _reward);
                PlayerPrefs.SetString("conditionSaveQuestOffice", _condition);
            }
            else if (_officeUpgrade.levelOffice >= 5)
            {
                _textMust.text = _localizationManager.translateOfficeQuest;
                if (_localizationManager._indexLanguage == 1) { _textReward.text = "Completed"; }
                else { _textReward.text = "Выполнено"; }
                _completed = true;
            }
        }
        if (_condition == "Open Present Box")
        {
            if (_completedSave != 1)
            {
                _completedSave++;
                _mainGameMechanics.RecearchPoint += (ushort)_reward;
                _textMust.text = _localizationManager.translatePresentBox;
                if (_localizationManager._indexLanguage == 1) { _textReward.text = "Completed"; }
                else { _textReward.text = "Выполнено"; }
                _completed = true;
                _completedQuestPushAudio.Play();
                _pushQuestManager._questImageButton.color = _pushCyrcleColor;
                PlayerPrefs.SetInt("completedAccumulatePresentSave", _completedSave);
                PlayerPrefs.SetInt("mustQuestPresent", (int)_must);
                PlayerPrefs.SetInt("rewardQuestPresent", _reward);
                PlayerPrefs.SetString("conditionSaveQuestPresent", _condition);
            }
        }
        if (_condition == "Buy Company")
        {
            _completedSave++;
            _mainGameMechanics.RecearchPoint += (ushort)_reward;
            _textMust.text = _localizationManager.translateBuyCompany;
            if (_localizationManager._indexLanguage == 1) { _textReward.text = "Completed"; }
            else { _textReward.text = "Выполнено"; }
            _completed = true;
            _completedQuestPushAudio.Play();
            _pushQuestManager._questImageButton.color = _pushCyrcleColor;
            PlayerPrefs.SetInt("completedAccumulateCompanySave", _completedSave);
            PlayerPrefs.SetInt("mustQuestCompany", (int)_must);
            PlayerPrefs.SetInt("rewardQuestCompany", _reward);
            PlayerPrefs.SetString("conditionSaveQuestCompany", _condition);
        }
        if (_condition == "Employees")
        {
            if (employeesMust != 24)
            {
                if (_mainGameMechanics.staffsPlayer >= employeesMust)
                {
                    _completedSave++;
                    _mainGameMechanics.RecearchPoint += (ushort)_reward;
                    _textReward.text = "RP " + _reward;
                    employeesMust += 4;
                    _textMust.text = employeesMust + _localizationManager.translateEmployees;
                    _completedQuestPushAudio.Play();
                    _pushQuestManager._questImageButton.color = _pushCyrcleColor;
                    PlayerPrefs.SetInt("completedAccumulateEmployeesSave", _completedSave);
                    PlayerPrefs.SetInt("mustQuestEmployees", (int)_must);
                    PlayerPrefs.SetInt("rewardQuestEmployees", _reward);
                    PlayerPrefs.SetString("conditionSaveQuestEmployees", _condition);
                }            
            }
        }
        if (_condition == "Crisis")
        {
            _completedSave++;
            _mainGameMechanics.RecearchPoint += (ushort)_reward;
            _textMust.text = _localizationManager.translateSurviveCrisis;
            if (_localizationManager._indexLanguage == 1) { _textReward.text = "Completed"; }
            else { _textReward.text = "Выполнено"; }
            _completed = true;
            _completedQuestPushAudio.Play();
            _pushQuestManager._questImageButton.color = _pushCyrcleColor;
            PlayerPrefs.SetInt("completedAccumulateCrisisSave", _completedSave);
            PlayerPrefs.SetInt("mustQuestCrisis", (int)_must);
            PlayerPrefs.SetInt("rewardQuestCrisis", _reward);
            PlayerPrefs.SetString("conditionSaveQuestCrisis", _condition);
        }
    }
}
