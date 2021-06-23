using UnityEngine;
using UnityEngine.UI;

public class MarketingSettings : MonoBehaviour
{
    [SerializeField] private MainGameMechanics _mainGameMechanics;
    [SerializeField] private FunctionPanelButton _functionPanelButton;
    [SerializeField] private ConfirmMarketing _confirmMarketing;
    [SerializeField] private CheckSaveMarketing _checkSaveMarketing;
    [SerializeField] private settingsMarketingButton _settingsMarketingButton;
    [SerializeField] private LocalizationManager _localizationManager;

    [Header("Название")]
    public string nameMarketing;
    [Header("Стоимость")]
    public int costMarketing;
    [Header("Стоимость улучшения")]
    public int costUpgradeMarketing;
    [Header("Уровень")]
    public byte levelMarketing;
    [Header("Минимально фанатов")]
    public int minFunMarketing;
    [Header("Максимально фанатов")]
    public int maxFunMarketing;
    [Header("Фанатов прибавится")]
    public int currentFunMarketing;

    [Header("Панель с подтверждением")]
    public GameObject confirmButton;
    public GameObject dontConfirmButton;

    [SerializeField] private Text _nameTextSpec;
    [SerializeField] private Text _costTextSpec;
    public Text levelTextSpec;
    [SerializeField] private Text _minTextFunMarketing;
    [SerializeField] private Text _maxTextFunMarketing;
    public Text textLevelMarketing;
    [SerializeField] private Text _validTextSpec;

    public int defaultMarketingMaxFun;

    void Awake()
    {
        levelMarketing = _checkSaveMarketing.levelMarketingObject;
        textLevelMarketing.text = levelMarketing.ToString();
    }

    private void OnEnable()
    {
        if (maxFunMarketing <= defaultMarketingMaxFun) { defaultMarketingMaxFun = (int)(maxFunMarketing * _settingsMarketingButton.sliderMarketingValid.value / 10f); }            
        else { maxFunMarketing = defaultMarketingMaxFun; }
    }

    private void Update()
    {
        _nameTextSpec.text = nameMarketing;
        _costTextSpec.text = "$" + _settingsMarketingButton.costMarketingValid.ToString("#,#");
        _minTextFunMarketing.text = minFunMarketing.ToString();
        _maxTextFunMarketing.text = defaultMarketingMaxFun.ToString();
        textLevelMarketing.text = _checkSaveMarketing.levelMarketingObject.ToString();
        _validTextSpec.text = _settingsMarketingButton.sliderMarketingValid.value + " " + _localizationManager.translateDaysMarketing;
    }

    public void buyMarketingButton()
    {
        _mainGameMechanics.Money -= _settingsMarketingButton.costMarketingValid; 
        _mainGameMechanics.Fun += Random.Range(minFunMarketing, defaultMarketingMaxFun);
        _mainGameMechanics.validMarketingBuy = (byte)_settingsMarketingButton.sliderMarketingValid.value;       
        _functionPanelButton.ScrollPanelMarketing.SetActive(true);
        confirmButton.SetActive(false);
        dontConfirmButton.SetActive(false);
        _functionPanelButton._confirmPanel.SetActive(false);
        _functionPanelButton.quitMarketingButton.SetActive(true);
    }

    public void dontBuyMarketingButton()
    {
        _functionPanelButton.ScrollPanelMarketing.SetActive(true);
        confirmButton.SetActive(false);
        dontConfirmButton.SetActive(false);
        _functionPanelButton._confirmPanel.SetActive(false);
        _functionPanelButton.quitMarketingButton.SetActive(true);
    }
}
