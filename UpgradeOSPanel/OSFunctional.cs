using UnityEngine;
using UnityEngine.UI;

public class OSFunctional : MonoBehaviour
{
    [Header("Доступ к скриптам")]
    [SerializeField] private MainGameMechanics _mainGameMechanics;
    [SerializeField] private OSVersionData _osVersionData;
    [SerializeField] private OpenOS _openOS;

    [Header("Название улучшения")]
    [SerializeField] private string _nameOSUpgrade;
    [Header("Цена улучшения")]
    [SerializeField] private byte _costOSUpgrade;
    [SerializeField] private Text _textCostUpgrade;
    [Header("Уровень OS функции")]
    [SerializeField] private byte _levelOSUpgrade;
    [SerializeField] private Text _textLevelOSUpgrade;

    private void Awake()
    {
        _textLevelOSUpgrade.text = "Level " + _levelOSUpgrade;

        if (PlayerPrefs.HasKey("LevelSecurity"))
        {
            if (_nameOSUpgrade == "Security")
            {
                _levelOSUpgrade = (byte)PlayerPrefs.GetInt("LevelSecurity");
                if (_levelOSUpgrade != 32) { _textLevelOSUpgrade.text = "Level " + _levelOSUpgrade; }                  
                else { _textLevelOSUpgrade.text = "Max"; _textCostUpgrade.enabled = false; }
            }
        }

        if (PlayerPrefs.HasKey("LevelPerfomance"))
        {
            if (_nameOSUpgrade == "Perfomance")
            {
                _levelOSUpgrade = (byte)PlayerPrefs.GetInt("LevelPerfomance");
                if (_levelOSUpgrade != 35) { _textLevelOSUpgrade.text = "Level " + _levelOSUpgrade; }                 
                else { _textLevelOSUpgrade.text = "Max"; _textCostUpgrade.enabled = false; }
            }
        }

        if (PlayerPrefs.HasKey("LevelAnimation"))
        {
            if (_nameOSUpgrade == "Animation")
            {
                _levelOSUpgrade = (byte)PlayerPrefs.GetInt("LevelAnimation");
                if (_levelOSUpgrade != 40) { _textLevelOSUpgrade.text = "Level " + _levelOSUpgrade; }
                else { _textLevelOSUpgrade.text = "Max"; _textCostUpgrade.enabled = false; }
            }
        }

        if (PlayerPrefs.HasKey("LevelOptimization"))
        {
            if (_nameOSUpgrade == "Optimization")
            {
                _levelOSUpgrade = (byte)PlayerPrefs.GetInt("LevelOptimization");
                if (_levelOSUpgrade != 35) { _textLevelOSUpgrade.text = "Level " + _levelOSUpgrade; }                   
                else { _textLevelOSUpgrade.text = "Max"; _textCostUpgrade.enabled = false; }
            }
        }

        if (PlayerPrefs.HasKey("LevelMultitasking"))
        {
            if (_nameOSUpgrade == "Multitasking")
            {
                _levelOSUpgrade = (byte)PlayerPrefs.GetInt("LevelMultitasking");
                if (_levelOSUpgrade != 20) { _textLevelOSUpgrade.text = "Level " + _levelOSUpgrade; }                   
                else { _textLevelOSUpgrade.text = "Max"; _textCostUpgrade.enabled = false; }
            }
        }

        if (PlayerPrefs.HasKey("LevelFunctional"))
        {
            if (_nameOSUpgrade == "Functional")
            {
                _levelOSUpgrade = (byte)PlayerPrefs.GetInt("LevelFunctional");
                if (_levelOSUpgrade != 32) { _textLevelOSUpgrade.text = "Level " + _levelOSUpgrade; }                  
                else { _textLevelOSUpgrade.text = "Max"; _textCostUpgrade.enabled = false; }
            }
        }

        if (PlayerPrefs.HasKey("LevelConvenience"))
        {
            if (_nameOSUpgrade == "Convenience")
            {
                _levelOSUpgrade = (byte)PlayerPrefs.GetInt("LevelConvenience");
                if (_levelOSUpgrade != 25) { _textLevelOSUpgrade.text = "Level " + _levelOSUpgrade; }                  
                else { _textLevelOSUpgrade.text = "Max"; _textCostUpgrade.enabled = false; }
            }
        }

        if (PlayerPrefs.HasKey("LevelAutonomy"))
        {
            if (_nameOSUpgrade == "Autonomy")
            {
                _levelOSUpgrade = (byte)PlayerPrefs.GetInt("LevelAutonomy");
                if (_levelOSUpgrade != 50) { _textLevelOSUpgrade.text = "Level " + _levelOSUpgrade; }         
                else { _textLevelOSUpgrade.text = "Max"; _textCostUpgrade.enabled = false; }
            }
        }       
    }

    public void OSUpgradeButton()
    {
        PlayerPrefs.SetFloat("SliderCostOSMaxValue", _openOS.sliderCostSaleOS.maxValue);
        PlayerPrefs.SetFloat("SliderCostOSMinValue", _openOS.sliderCostSaleOS.minValue);
        if (_mainGameMechanics.RecearchPoint >= _costOSUpgrade)
        {          
            if (_nameOSUpgrade == "Security")
            {
                if (_levelOSUpgrade < 32)
                {
                    _mainGameMechanics.RecearchPoint -= _costOSUpgrade;
                    _levelOSUpgrade++;
                    _osVersionData.thirdNumberVersion += 1;
                    if (_levelOSUpgrade != 32) { _textLevelOSUpgrade.text = "Level " + _levelOSUpgrade; _openOS.sliderCostSaleOS.maxValue += 10000; _openOS.sliderCostSaleOS.minValue += 5000; }
                    else { _textLevelOSUpgrade.text = "Max"; _textCostUpgrade.enabled = false; }
                    PlayerPrefs.SetInt("LevelSecurity", _levelOSUpgrade);
                    PlayerPrefs.SetInt("versionOS", _osVersionData.thirdNumberVersion);
                }
            }
            if (_nameOSUpgrade == "Perfomance")
            {
                if (_levelOSUpgrade < 35)
                {
                    _mainGameMechanics.RecearchPoint -= _costOSUpgrade;
                    _levelOSUpgrade++;
                    _osVersionData.thirdNumberVersion += 1;
                    if (_levelOSUpgrade != 35) { _textLevelOSUpgrade.text = "Level " + _levelOSUpgrade; _openOS.sliderCostSaleOS.maxValue += 10000; _openOS.sliderCostSaleOS.minValue += 5000; }                       
                    else { _textLevelOSUpgrade.text = "Max"; _textCostUpgrade.enabled = false; }
                    PlayerPrefs.SetInt("LevelPerfomance", _levelOSUpgrade);
                    PlayerPrefs.SetInt("versionOS", _osVersionData.thirdNumberVersion);
                }        
            }
            if (_nameOSUpgrade == "Animation")
            {
                if (_levelOSUpgrade < 40)
                {
                    _mainGameMechanics.RecearchPoint -= _costOSUpgrade;
                    _levelOSUpgrade++;
                    _osVersionData.thirdNumberVersion += 1;
                    if (_levelOSUpgrade != 40) { _textLevelOSUpgrade.text = "Level " + _levelOSUpgrade; _openOS.sliderCostSaleOS.maxValue += 10000; _openOS.sliderCostSaleOS.minValue += 5000; }                        
                    else { _textLevelOSUpgrade.text = "Max"; _textCostUpgrade.enabled = false; }
                    PlayerPrefs.SetInt("LevelAnimation", _levelOSUpgrade);
                    PlayerPrefs.SetInt("versionOS", _osVersionData.thirdNumberVersion);
                }
            }
            if (_nameOSUpgrade == "Optimization")
            {
                if (_levelOSUpgrade < 35)
                {
                    _mainGameMechanics.RecearchPoint -= _costOSUpgrade;
                    _levelOSUpgrade++;
                    _osVersionData.thirdNumberVersion += 1;
                    if (_levelOSUpgrade != 35) { _textLevelOSUpgrade.text = "Level " + _levelOSUpgrade; _openOS.sliderCostSaleOS.maxValue += 10000; _openOS.sliderCostSaleOS.minValue += 5000; }                      
                    else { _textLevelOSUpgrade.text = "Max"; _textCostUpgrade.enabled = false; }
                    PlayerPrefs.SetInt("LevelOptimization", _levelOSUpgrade);
                    PlayerPrefs.SetInt("versionOS", _osVersionData.thirdNumberVersion);
                }    
            }
            if (_nameOSUpgrade == "Multitasking")
            {
                if (_levelOSUpgrade < 20)
                {
                    _mainGameMechanics.RecearchPoint -= _costOSUpgrade;
                    _levelOSUpgrade++;
                    _osVersionData.thirdNumberVersion += 1;
                    if (_levelOSUpgrade != 20) { _textLevelOSUpgrade.text = "Level " + _levelOSUpgrade; _openOS.sliderCostSaleOS.maxValue += 10000; _openOS.sliderCostSaleOS.minValue += 5000; }         
                    else { _textLevelOSUpgrade.text = "Max"; _textCostUpgrade.enabled = false; }
                    PlayerPrefs.SetInt("LevelMultitasking", _levelOSUpgrade);
                    PlayerPrefs.SetInt("versionOS", _osVersionData.thirdNumberVersion);
                }         
            }
            if (_nameOSUpgrade == "Functional")
            {
                if (_levelOSUpgrade < 32)
                {
                    _mainGameMechanics.RecearchPoint -= _costOSUpgrade;
                    _levelOSUpgrade++;
                    _osVersionData.thirdNumberVersion += 1;
                    if (_levelOSUpgrade != 32) { _textLevelOSUpgrade.text = "Level " + _levelOSUpgrade; _openOS.sliderCostSaleOS.maxValue += 10000; _openOS.sliderCostSaleOS.minValue += 5000; }                      
                    else { _textLevelOSUpgrade.text = "Max"; _textCostUpgrade.enabled = false; }
                    PlayerPrefs.SetInt("LevelFunctional", _levelOSUpgrade);
                    PlayerPrefs.SetInt("versionOS", _osVersionData.thirdNumberVersion);
                }     
            }
            if (_nameOSUpgrade == "Convenience")
            {
                if (_levelOSUpgrade < 25)
                {
                    _mainGameMechanics.RecearchPoint -= _costOSUpgrade;
                    _levelOSUpgrade++;
                    _osVersionData.thirdNumberVersion += 1;
                    if (_levelOSUpgrade != 25) { _textLevelOSUpgrade.text = "Level " + _levelOSUpgrade; _openOS.sliderCostSaleOS.maxValue += 10000; _openOS.sliderCostSaleOS.minValue += 5000; }
                    else { _textLevelOSUpgrade.text = "Max"; _textCostUpgrade.enabled = false; }
                    PlayerPrefs.SetInt("LevelConvenience", _levelOSUpgrade);
                    PlayerPrefs.SetInt("versionOS", _osVersionData.thirdNumberVersion);
                }      
            }
            if (_nameOSUpgrade == "Autonomy")
            {
                if (_levelOSUpgrade < 50)
                {
                    _mainGameMechanics.RecearchPoint -= _costOSUpgrade;
                    _levelOSUpgrade++;
                    _osVersionData.thirdNumberVersion += 1;
                    if (_levelOSUpgrade != 50) { _textLevelOSUpgrade.text = "Level " + _levelOSUpgrade; _openOS.sliderCostSaleOS.maxValue += 10000; _openOS.sliderCostSaleOS.minValue += 5000; }                      
                    else { _textLevelOSUpgrade.text = "Max"; _textCostUpgrade.enabled = false; }
                    PlayerPrefs.SetInt("LevelAutonomy", _levelOSUpgrade);
                    PlayerPrefs.SetInt("versionOS", _osVersionData.thirdNumberVersion);
                }   
            }
        }
    }
}
