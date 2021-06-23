using UnityEngine;
using UnityEngine.UI;

public class taxReduction : MonoBehaviour
{
    [Header("Доступ к скриптам")]
    [SerializeField] private CreateLaptop _createLaptop;
    [SerializeField] private MainGameMechanics _mainGameMechanics;
    [SerializeField] private LocalizationManager _localizationManager;

    [SerializeField] private byte _costTaxReduction;
    public byte levelTaxReduction;
    [SerializeField] private Text _textCostTaxReduction;
    [SerializeField] private Text _textLevelTaxReduction; 

    void Start()
    {
        if (PlayerPrefs.HasKey("levelTaxReduction")) { levelTaxReduction = (byte)PlayerPrefs.GetInt("levelTaxReduction"); }           
    }

    private void Update()
    {
        if (levelTaxReduction != 5)
        {
            _textCostTaxReduction.text = "RP " + _costTaxReduction;
            _textLevelTaxReduction.text = _localizationManager.translateMarketingLevel + " " + levelTaxReduction;
        }
        else
        {
            _textCostTaxReduction.text = "Max";
            _textCostTaxReduction.color = new Color(255, 255, 255);
            _textLevelTaxReduction.enabled = false;
        }
    }

    public void upgradeRaxReductionButton()
    {
        if (_mainGameMechanics.RecearchPoint >= _costTaxReduction)
        {
            if (levelTaxReduction != 5)
            {
                levelTaxReduction++;
                _mainGameMechanics.RecearchPoint -= _costTaxReduction;
                PlayerPrefs.SetInt("levelTaxReduction", levelTaxReduction);
            }
        }
    }
}
