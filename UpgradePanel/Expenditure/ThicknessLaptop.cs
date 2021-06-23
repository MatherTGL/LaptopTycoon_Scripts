using UnityEngine;
using UnityEngine.UI;

public class ThicknessLaptop : MonoBehaviour
{
    [SerializeField] private MainGameMechanics _mainGameMechanics;
    [SerializeField] private LocalizationManager _localizationManager;

    [SerializeField] private byte _costThicknessLaptop;
    [SerializeField] private Text _textCostThicknessLaptop;
    public byte levelThicknessLaptop;
    [SerializeField] private Text _textLevelThicknessLaptop;

    void Start()
    {
        if (PlayerPrefs.HasKey("levelThicknessLaptop")) { levelThicknessLaptop = (byte)PlayerPrefs.GetInt("levelThicknessLaptop"); }          
    }

    private void Update()
    {
        if (levelThicknessLaptop != 8)
        {
            _textCostThicknessLaptop.text = "RP " + _costThicknessLaptop;
            _textLevelThicknessLaptop.text = _localizationManager.translateMarketingLevel + " " + levelThicknessLaptop;
        }
        else
        {
            _textCostThicknessLaptop.text = "Max";
            _textCostThicknessLaptop.color = new Color(255, 255, 255);
            _textLevelThicknessLaptop.enabled = false;
        }
    }

    public void thicknessLaptopButton()
    {
        if (_mainGameMechanics.RecearchPoint >= _costThicknessLaptop)
        {
            if (levelThicknessLaptop != 8)
            {
                _mainGameMechanics.RecearchPoint -= _costThicknessLaptop;
                levelThicknessLaptop++;
                PlayerPrefs.SetInt("levelThicknessLaptop", levelThicknessLaptop);
            }
        }
    }
}
