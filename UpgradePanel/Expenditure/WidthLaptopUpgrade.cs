using UnityEngine;
using UnityEngine.UI;

public class WidthLaptopUpgrade : MonoBehaviour
{
    [SerializeField] private MainGameMechanics _mainGameMechanics;
    [SerializeField] private LocalizationManager _localizationManager;

    [SerializeField] private byte _costWidthLaptop;
    [SerializeField] private Text _textCostWidthLaptop;
    public byte levelWidthLaptop;
    [SerializeField] private Text _textLevelWidthLaptop;

    void Start()
    {
        if (PlayerPrefs.HasKey("LevelWidthLaptop")) { levelWidthLaptop = (byte)PlayerPrefs.GetInt("LevelWidthLaptop"); }
    }

    private void Update()
    {
        if (levelWidthLaptop != 8)
        {
            _textCostWidthLaptop.text = "RP " + _costWidthLaptop;
            _textLevelWidthLaptop.text = _localizationManager.translateMarketingLevel + " " + levelWidthLaptop;
        }
        else
        {
            _textCostWidthLaptop.text = "Max";
            _textCostWidthLaptop.color = new Color(255, 255, 255);
            _textLevelWidthLaptop.enabled = false;
        }
    }

    public void widthLaptopButton()
    {
        if (_mainGameMechanics.RecearchPoint >= _costWidthLaptop)
        {
            if (levelWidthLaptop != 8)
            {
                levelWidthLaptop++;
                _mainGameMechanics.RecearchPoint -= _costWidthLaptop;
                PlayerPrefs.SetInt("LevelWidthLaptop", levelWidthLaptop);
            }
        }  
    }
}
