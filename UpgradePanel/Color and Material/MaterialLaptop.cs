using UnityEngine;
using UnityEngine.UI;

public class MaterialLaptop : MonoBehaviour
{
    [SerializeField] private MainGameMechanics _mainGameMechanics;

    [SerializeField] private byte _costMaterialLaptop;
    [SerializeField] private Text _textCostMaterialLaptop;
    public byte levelMaterialLaptop;
    [SerializeField] private Text _textLevelMaterialLaptop;

    void Start()
    {
        if (PlayerPrefs.HasKey("levelMaterialLaptop"))
            levelMaterialLaptop = (byte)PlayerPrefs.GetInt("levelMaterialLaptop");
    }

    
    void Update()
    {
        if (levelMaterialLaptop != 8)
        {
            _textCostMaterialLaptop.text = "RP " + _costMaterialLaptop;
            _textLevelMaterialLaptop.text = "Level " + levelMaterialLaptop;
        }
        else
        {
            _textCostMaterialLaptop.text = "Max";
            _textCostMaterialLaptop.color = new Color(255, 255, 255);
            _textLevelMaterialLaptop.enabled = false;
        }
    }

    public void colorsLaptopButton()
    {
        if (_mainGameMechanics.RecearchPoint >= _costMaterialLaptop)
        {
            if (levelMaterialLaptop != 8)
            {
                _mainGameMechanics.RecearchPoint -= _costMaterialLaptop;
                levelMaterialLaptop++;
                PlayerPrefs.SetInt("levelMaterialLaptop", levelMaterialLaptop);
            }
        }
    }
}
