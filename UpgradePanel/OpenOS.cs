using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class OpenOS : MonoBehaviour
{
    [Header("Доступы")]
    [SerializeField] private MainGameMechanics _mainGameMechanics;
    [SerializeField] private CreateLaptop _createLaptop;
    [SerializeField] private LocalizationManager _localizationManager;

    [Header("Открыто ли OS")]
    public byte _activeOSUpgrade;
    [Header("Цена за OS")]
    [SerializeField] private byte _costOpenOS = 150;
    [Header("Название OS")]
    public string namePlayerOS;
    [Header("текст unlock")]
    [SerializeField] private Text _textLockOS;
    [Header("Текст цены")]
    [SerializeField] private Text _costOSUpgrade;
    [Header("Введите название OS")]
    public GameObject _checkNameOSPanel;
    [Header("Основная OS прокачка")]
    [SerializeField] private GameObject _mainOSUgrade;
    public Color _colorOpenOSUpgrade; //46, 204, 113

    [Header("Панель с настройками ОС")]
    [SerializeField] private GameObject settingsOSPanel;
    [SerializeField] private GameObject upgradeOSPanel;
    [SerializeField] private GameObject buttonsQuitOS;
    [SerializeField] private GameObject buttonsBackOS;

    [Header("Продаётся ли ос")]
    [SerializeField] private bool saleOSPlayer;
    [SerializeField] private byte saveSaleOSPlayer;
    [SerializeField] private GameObject trueSaleOS;
    [SerializeField] private GameObject falseSaleOS;
    [Header("Прибыль")]
    [SerializeField] private Text incomeSaleOS;
    [SerializeField] private Color incomeSaleOSColor;
    [SerializeField] private Color expenditureSaleOSColor;
    [Header("Регулятор стоимости")]
    public Slider sliderCostSaleOS;

    public byte closeNameOSPanel;

    private void Awake()
    {
        if (_localizationManager._indexLanguage == 1) { _textLockOS.text = "Lock"; }
        else if (_localizationManager._indexLanguage == 2) { _textLockOS.text = "Закрыто"; }
        else { _textLockOS.text = "Stängd"; }
        closeNameOSPanel = (byte)PlayerPrefs.GetInt("closeNamePanelOS");
        if (PlayerPrefs.HasKey("saveSaleOS")) { saveSaleOSPlayer = (byte)PlayerPrefs.GetInt("saveSaleOS"); saleOS(); }
        if (PlayerPrefs.HasKey("SliderCostOSMaxValue")) { sliderCostSaleOS.maxValue = PlayerPrefs.GetFloat("SliderCostOSMaxValue"); sliderCostSaleOS.minValue = PlayerPrefs.GetFloat("SliderCostOSMinValue"); }
        if (PlayerPrefs.HasKey("valueOSCost")) sliderCostSaleOS.value = PlayerPrefs.GetFloat("valueOSCost");
        if (_activeOSUpgrade == 1)
        {
            if (_localizationManager._indexLanguage == 1) { _costOSUpgrade.text = "Unlock"; }
            else if (_localizationManager._indexLanguage == 2) { _costOSUpgrade.text = "Открыто"; }
            else { _costOSUpgrade.text = "Öppet"; }
            _costOSUpgrade.enabled = true;
            _costOSUpgrade.color = _colorOpenOSUpgrade;
            _textLockOS.enabled = false;
            if (closeNameOSPanel == 1) { _checkNameOSPanel.SetActive(false); _mainOSUgrade.SetActive(true); }
            else { _checkNameOSPanel.SetActive(true); _mainOSUgrade.SetActive(false); }
            StartCoroutine(incomeSaleOSCoroutine());
        }
    }
    private void Update()
    {
        if (_activeOSUpgrade == 1)
        {
            if (_localizationManager._indexLanguage == 1) { _costOSUpgrade.text = "Unlock"; }
            else if (_localizationManager._indexLanguage == 2) { _costOSUpgrade.text = "Открыто"; }
            else { _costOSUpgrade.text = "Öppet"; }
            PlayerPrefs.SetFloat("valueOSCost", sliderCostSaleOS.value);
        }
        else
        {
            if (_localizationManager._indexLanguage == 1) { _textLockOS.text = "Lock"; }
            else if (_localizationManager._indexLanguage == 2) { _textLockOS.text = "Закрыто"; }
            else { _textLockOS.text = "Stängd"; }
        }
        incomeSaleOS.text = "$" + sliderCostSaleOS.value.ToString("#,K") + " / D";
    }
    private void OnEnable()
    {
        if (_activeOSUpgrade == 1)
        {
            if (_localizationManager._indexLanguage == 1) { _costOSUpgrade.text = "Unlock"; }
            else if (_localizationManager._indexLanguage == 2) { _costOSUpgrade.text = "Открыто"; }
            else { _costOSUpgrade.text = "Öppet"; }
            _costOSUpgrade.enabled = true;
            _costOSUpgrade.color = _colorOpenOSUpgrade;
            _textLockOS.enabled = false;
            if (closeNameOSPanel == 1) { _checkNameOSPanel.SetActive(false); _mainOSUgrade.SetActive(true); }
            else { _checkNameOSPanel.SetActive(true); _mainOSUgrade.SetActive(false); }
        }
    }
    public void saveOSName()
    {
        _checkNameOSPanel.SetActive(false);
        _mainOSUgrade.SetActive(true);
        closeNameOSPanel++;
        PlayerPrefs.SetInt("closeNamePanelOS", closeNameOSPanel);
    }

    IEnumerator incomeSaleOSCoroutine()
    {
        while (true)
        {
            if (saveSaleOSPlayer == 1)
            {
                _mainGameMechanics.Money += sliderCostSaleOS.value;
                yield return new WaitForSeconds(1);
            }
        }
    }

    public void saleOS()
    {
        if (saveSaleOSPlayer == 0) { trueSaleOS.SetActive(true); falseSaleOS.SetActive(false); saveSaleOSPlayer++; saleOSPlayer = true; PlayerPrefs.SetInt("saveSaleOS", saveSaleOSPlayer); incomeSaleOS.color = incomeSaleOSColor; }
        else { trueSaleOS.SetActive(false); falseSaleOS.SetActive(true); saveSaleOSPlayer--; saleOSPlayer = false; PlayerPrefs.SetInt("saveSaleOS", saveSaleOSPlayer); incomeSaleOS.color = expenditureSaleOSColor; }
    }

    public void openOSButton()
    {
        if (_mainGameMechanics.RecearchPoint >= _costOpenOS)
        {
            _activeOSUpgrade = 1;
            _mainGameMechanics.RecearchPoint -= _costOpenOS;
            if (_localizationManager._indexLanguage == 1) { _costOSUpgrade.text = "Unlock"; }
            else if (_localizationManager._indexLanguage == 2) { _costOSUpgrade.text = "Открыто"; }
            else { _costOSUpgrade.text = "Öppet"; }
            _costOSUpgrade.color = _colorOpenOSUpgrade;
            _textLockOS.enabled = false;
            PlayerPrefs.SetInt("saveOpenOS", _activeOSUpgrade);
        }
    }
    public void openSettingsOS()
    {
        settingsOSPanel.SetActive(true);
        upgradeOSPanel.SetActive(false);
        buttonsQuitOS.SetActive(false);
        buttonsBackOS.SetActive(true);
    }

    public void closeSettingsOS()
    {
        settingsOSPanel.SetActive(false);
        upgradeOSPanel.SetActive(true);
        buttonsQuitOS.SetActive(true);
        buttonsBackOS.SetActive(false);
    }
}
