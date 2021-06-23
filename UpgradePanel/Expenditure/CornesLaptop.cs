using UnityEngine;
using UnityEngine.UI;

public class CornesLaptop : MonoBehaviour
{
    [SerializeField] private MainGameMechanics _mainGameMechanics;
    [SerializeField] private LocalizationManager _localizationManager;

    [SerializeField] private byte _costCornesLaptop;
    [SerializeField] private Text _textCostCornes;
    public byte levelCornes;
    [SerializeField] private Text _textLevelCornes;

    void Start()
    {
        if (PlayerPrefs.HasKey("levelCornesLaptop")) { levelCornes = (byte)PlayerPrefs.GetInt("levelCornesLaptop"); }
        _textLevelCornes.text = _localizationManager.translateMarketingLevel + " " + levelCornes;
    }

    void OnEnable()
    {
        if (levelCornes != 8)
        {
            _textCostCornes.text = "RP " + _costCornesLaptop;
            _textLevelCornes.text = _localizationManager.translateMarketingLevel + " " + levelCornes;
        }
        else
        {
            _textCostCornes.text = "Max";
            _textCostCornes.color = new Color(255, 255, 255);
            _textLevelCornes.enabled = false;
        }
    }

    public void cornesLaptopButton()
    {
        if (_mainGameMechanics.RecearchPoint >= _costCornesLaptop)
        {
            if (levelCornes != 8)
            {
                _mainGameMechanics.RecearchPoint -= _costCornesLaptop;
                levelCornes++;
                PlayerPrefs.SetInt("levelCornesLaptop", levelCornes);
            }
        }

        if (levelCornes != 8)
        {
            _textCostCornes.text = "RP " + _costCornesLaptop;
            _textLevelCornes.text = _localizationManager.translateMarketingLevel + " " + levelCornes;
        }
        else
        {
            _textCostCornes.text = "Max";
            _textCostCornes.color = new Color(255, 255, 255);
            _textLevelCornes.enabled = false;
        }
    }
}
