using UnityEngine;
using UnityEngine.UI;

public class QuickCharge : MonoBehaviour
{
    [SerializeField] private MainGameMechanics _mainGameMechanics;
    [SerializeField] private LocalizationManager _localizationManager;
    [SerializeField] private SurprizeChest _surprizeChest;

    [SerializeField] private byte _costQuickCharge;
    [SerializeField] private Text _textCost;
    public byte levelQuickCharge;
    [SerializeField] private Text _textLevelQuickCharge;
    [SerializeField] private Button _quickChargeButtonActive;

    public Toggle addQuickCharge;
    void Start()
    {
        if (PlayerPrefs.HasKey("levelQuickCharge"))
        {
            levelQuickCharge = (byte)PlayerPrefs.GetInt("levelQuickCharge");
            _textLevelQuickCharge.enabled = false;
            _textCost.color = _surprizeChest._moneyColorPrize;
            _quickChargeButtonActive = GetComponent<Button>();
            _quickChargeButtonActive.image.color = new Color(145, 145, 145);
            addQuickCharge.interactable = true;
        }
    }

    void OnEnable()
    {
        if (PlayerPrefs.HasKey("levelQuickCharge"))
        {
            _textCost.color = _surprizeChest._moneyColorPrize;
            _quickChargeButtonActive.image.color = new Color(145, 145, 145);
        }
    }

    private void Update()
    {
        if (levelQuickCharge == 1)
        {
            if (_localizationManager._indexLanguage == 1) { _textCost.text = "Unlock"; }
            else if (_localizationManager._indexLanguage == 2) { _textCost.text = "Открыто"; }
            else { _textCost.text = "Öppet"; }
        }
        else
        {
            if (_localizationManager._indexLanguage == 1) { _textLevelQuickCharge.text = "Lock"; }
            else if (_localizationManager._indexLanguage == 2) { _textLevelQuickCharge.text = "Закрыто"; }        
            else { _textLevelQuickCharge.text = "Stängd"; }
        }
    }

    public void QuickChargerButton()
    {
        if (levelQuickCharge != 1)
        {
            if (_mainGameMechanics.RecearchPoint >= _costQuickCharge)
            {
                levelQuickCharge++;
                _mainGameMechanics.RecearchPoint -= _costQuickCharge;
                _textLevelQuickCharge.enabled = false;
                _textCost.color = _surprizeChest._moneyColorPrize;
                _quickChargeButtonActive.image.color = new Color(145, 145, 145);
                addQuickCharge.interactable = true;
                PlayerPrefs.SetInt("levelQuickCharge", levelQuickCharge);
            }
        }
    }
}
