using UnityEngine;
using UnityEngine.UI;

public class CoolingLaptopUpgrade : MonoBehaviour
{
    [Header("Доступы к скриптам")]
    [SerializeField] private CreateLaptop _createLaptop;
    [SerializeField] private MainGameMechanics _mainGameMechanics;
    [SerializeField] private LocalizationManager _localizationManager;

    [Header("Название компонента")]
    [SerializeField] private string _nameCooling;
    [Header("Цена")]
    [SerializeField] private byte _costCooling = 60;
    [Header("Вывод цены в текст")]
    [SerializeField] private Text _textCostCooling;
    [Header("Уровень охлаждения")]
    public byte levelCooling;
    [SerializeField] private Text _textLevelCooling;

    void Start()
    {
        if (levelCooling != 13)
        {
            _textCostCooling.text = "RP " + _costCooling;
            _textLevelCooling.text = _localizationManager.translateMarketingLevel + " " + levelCooling;
        }
        else { _textLevelCooling.enabled = false; _textCostCooling.text = "Max"; }
      
        if (PlayerPrefs.HasKey("levelCoolingSave")) { levelCooling = (byte)PlayerPrefs.GetInt("levelCoolingSave"); }
    }

    private void Update()
    {
        if (levelCooling != 13)
        {
            _textCostCooling.text = "RP " + _costCooling;
            _textLevelCooling.text = _localizationManager.translateMarketingLevel + " " + levelCooling;
        }
        else
        {
            _textLevelCooling.enabled = false;
            _textCostCooling.text = "Max";
            _textCostCooling.color = new Color(255, 255, 255);
        }
    }

    public void upgradeCooling()
    {
        if (levelCooling < 13)
        {
            if (_mainGameMechanics.RecearchPoint >= _costCooling)
            {
                levelCooling++;
                _mainGameMechanics.RecearchPoint -= _costCooling;
                PlayerPrefs.SetInt("levelCoolingSave", levelCooling);
            }
        }
    }
}
