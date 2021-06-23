using UnityEngine;
using UnityEngine.UI;

public class DDRUpgrade : MonoBehaviour
{
    [Header("Доступ к скриптам")]
    [SerializeField] private CreateLaptop _createLaptop;
    [SerializeField] private MainGameMechanics _mainGameMechanics;
    [SerializeField] private LocalizationManager _localizationManager;
    [SerializeField] private ddrCP _ddrCP;

    public byte levelDDR;
    [SerializeField] private byte _costDDR;
    [SerializeField] private Text _textLevelDDR;
    [SerializeField] private Text _textCostDDR;

    void Awake()
    {
        if (PlayerPrefs.HasKey("ddrLevel")) { _costDDR = (byte)PlayerPrefs.GetInt("ddrCost"); levelDDR = (byte)PlayerPrefs.GetInt("ddrLevel"); } 
    }

    void OnEnable()
    {
        if (levelDDR != 6)
        {
            _textLevelDDR.text = _localizationManager.translateMarketingLevel + " " + levelDDR;
            _textCostDDR.text = "RP " + _costDDR;
        }
        else
        {
            _textCostDDR.text = "Max";
            _textCostDDR.color = new Color(255, 255, 255);
            _textLevelDDR.enabled = false;
        }
    }

    private void Update() { _textLevelDDR.text = _localizationManager.translateMarketingLevel + " " + levelDDR; }

    public void returnDefaultDDR() { _ddrCP.levelDDRLaptop = 2; }

    public void ddrUpgradeButton()
    {
        if (_mainGameMechanics.RecearchPoint >= _costDDR)
        {
            if (levelDDR < 6)
            {
                levelDDR++;
                _mainGameMechanics.RecearchPoint -= _costDDR;
                _costDDR += 10;
                PlayerPrefs.SetInt("ddrLevel", levelDDR);
                PlayerPrefs.SetInt("ddrCost", _costDDR);
            }
        }

        if (levelDDR != 6)
        {
            _textLevelDDR.text = _localizationManager.translateMarketingLevel + " " + levelDDR;
            _textCostDDR.text = "RP " + _costDDR;
        }
        else
        {
            _textCostDDR.text = "Max";
            _textCostDDR.color = new Color(255, 255, 255);
            _textLevelDDR.enabled = false;
        }
    }
}
