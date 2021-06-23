using UnityEngine;
using UnityEngine.UI;

public class ALUUpgrade : MonoBehaviour
{
    [SerializeField] private MainGameMechanics _mainGameMechanics;
    [SerializeField] private LocalizationManager _localizationManager;

    [SerializeField] private byte _costALU;
    [SerializeField] private Text _textCostALU;
    public byte levelALU;
    [SerializeField] private Text _levelTextALU;

    private void Awake()
    {
        if (PlayerPrefs.HasKey("levelALU"))
        {
            levelALU = (byte)PlayerPrefs.GetInt("levelALU");
            _costALU = (byte)PlayerPrefs.GetInt("costALU");
        } 
    }

    void OnEnable()
    {
        if (levelALU != 8)
        {
            _textCostALU.text = "RP " + _costALU;
            _levelTextALU.text = _localizationManager.translateMarketingLevel + " " + levelALU;
        }
        else
        {
            _textCostALU.text = "Max";
            _levelTextALU.enabled = false;
            _textCostALU.color = new Color(255, 255, 255);
        }
    }

    private void Update() { _levelTextALU.text = _localizationManager.translateMarketingLevel + " " + levelALU; }

    public void upgradeALUButton()
    {
        if (levelALU != 8)
        {
            if (_mainGameMechanics.RecearchPoint >= _costALU)
            {
                _mainGameMechanics.RecearchPoint -= _costALU;
                levelALU++;
                _costALU += 5;
                PlayerPrefs.SetInt("levelALU", levelALU);
                PlayerPrefs.SetInt("costALU", _costALU);
            }
        }

        if (levelALU != 8)
        {
            _textCostALU.text = "RP " + _costALU;
            _levelTextALU.text = _localizationManager.translateMarketingLevel + " " + levelALU;
        }
        else { _textCostALU.text = "Max"; _levelTextALU.enabled = false; _textCostALU.color = new Color(255, 255, 255); }
    }
}
