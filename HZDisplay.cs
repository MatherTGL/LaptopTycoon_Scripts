using UnityEngine;
using UnityEngine.UI;

public class HZDisplay : MonoBehaviour
{
    [SerializeField] private MainGameMechanics _mainGameMechanics;
    [SerializeField] private LocalizationManager _localizationManager;

    public byte levelHZ;
    [SerializeField] private byte _costHZ;
    public ushort hzDisplay;
    [SerializeField] private Text _textLevelHZ;
    [SerializeField] private Text _textCostHZ;

    void Start()
    {
        if (PlayerPrefs.HasKey("HZLevelSave"))
        {
            levelHZ = (byte)PlayerPrefs.GetInt("HZLevelSave");
            hzDisplay = (ushort)PlayerPrefs.GetInt("hzDisplay");
        }
    }
    private void Update()
    {
        if (levelHZ != 5)
        {
            _textLevelHZ.text = _localizationManager.translateMarketingLevel + " " + levelHZ;
            _textCostHZ.text = "RP " + _costHZ;
        }
        else
        {
            _textLevelHZ.enabled = false;
            _textCostHZ.text = "Max";
            _textCostHZ.color = new Color(255, 255, 255);
        }
    }

    public void upgradeScreenHZ()
    {
        if (_mainGameMechanics.RecearchPoint >= _costHZ)
        {
            if (levelHZ != 5)
            {
                if (levelHZ == 2) { hzDisplay = 120; }                  
                else if (levelHZ == 3) { hzDisplay = 144; }
                else if (levelHZ == 4) { hzDisplay = 240; }
                else { hzDisplay = 300; }
                   
                _mainGameMechanics.RecearchPoint -= _costHZ;
                levelHZ++;
                PlayerPrefs.SetInt("HZLevelSave", levelHZ);
                PlayerPrefs.SetInt("hzDisplay", hzDisplay);
            }
        }      
    }
}
