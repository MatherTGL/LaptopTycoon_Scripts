using UnityEngine;
using UnityEngine.UI;

public class settingsMarketingButton : MonoBehaviour
{
    [Header("Доступ к скриптам")]
    [SerializeField] private MarketingSettings _marketingSettings;
    [SerializeField] private LocalizationManager _localizationManager;

    public GameObject settingsMarketing;
    public GameObject buyMarketingPanel;
    [SerializeField] private bool _checkActiveSettingsMarketing;
    public Slider sliderMarketingValid;
    [SerializeField] private Text _textValidMarketing;
    [SerializeField] private Text _textCostMarketing;
    public double costMarketingValid;

    void Start()
    {
        settingsMarketing.SetActive(false);
        buyMarketingPanel.SetActive(true);
        _checkActiveSettingsMarketing = false;
        sliderMarketingValid.minValue = 10;
        sliderMarketingValid.maxValue = 30;
        sliderMarketingValid.value = sliderMarketingValid.minValue;
    }

    private void OnEnable()
    {
        settingsMarketing.SetActive(false);
        _checkActiveSettingsMarketing = false;
        buyMarketingPanel.SetActive(true);
    }

    void Update()
    {
        _textValidMarketing.text = sliderMarketingValid.value + " " +_localizationManager.translateDaysMarketing;
        _textCostMarketing.text = "$" + costMarketingValid.ToString("#,#");
        costMarketingValid = (double)(_marketingSettings.costMarketing + (_marketingSettings.costMarketing * sliderMarketingValid.value / 50));
    }

    public void settingsMarketingButtonMethod()
    {
        if (_checkActiveSettingsMarketing == false)
        {
            settingsMarketing.SetActive(true);
            buyMarketingPanel.SetActive(false);
            _checkActiveSettingsMarketing = true;
        }
        else
        {
            settingsMarketing.SetActive(false);
            buyMarketingPanel.SetActive(true);
            _checkActiveSettingsMarketing = false;
        }   
    }
}
