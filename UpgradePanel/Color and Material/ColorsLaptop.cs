using UnityEngine;
using UnityEngine.UI;


public class ColorsLaptop : MonoBehaviour
{
    [SerializeField] private MainGameMechanics _mainGameMechanics;

    [SerializeField] private byte _costColorsLaptop;
    [SerializeField] private Text _textCostColorsLaptop;
    public byte levelColorsLaptop;
    [SerializeField] private Text _textLevelColorsLaptop;

    void Start()
    {
        if (PlayerPrefs.HasKey("levelColorsLaptop"))
            levelColorsLaptop = (byte)PlayerPrefs.GetInt("levelColorsLaptop");
    }

    void Update()
    {
        if (levelColorsLaptop != 4)
        {
            _textCostColorsLaptop.text = "RP " + _costColorsLaptop;
            _textLevelColorsLaptop.text = "Level " + levelColorsLaptop;
        }
        else
        {
            _textCostColorsLaptop.text = "Max";
            _textLevelColorsLaptop.enabled = false;
            _textCostColorsLaptop.color = new Color(255, 255, 255);
        }
    }

    public void colorsLaptopButton()
    {
        if (_mainGameMechanics.RecearchPoint >= _costColorsLaptop)
        {
            if (levelColorsLaptop != 4)
            {
                _mainGameMechanics.RecearchPoint -= _costColorsLaptop;
                levelColorsLaptop++;
                PlayerPrefs.SetInt("levelColorsLaptop", levelColorsLaptop);
            }
        }
    }
}
