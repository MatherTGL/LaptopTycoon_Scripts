using UnityEngine;
using UnityEngine.UI;

public class RealtorUpgrade : MonoBehaviour
{
    [SerializeField] private MainGameMechanics _mainGameMechanics;
    [SerializeField] private LocalizationManager _localizationManager;

    public byte levelRealtor;
    [SerializeField] private Text _textLevelRealtor;
    public byte costRealtor;
    [SerializeField] private Text _textCostRealtor;
    public byte ownCompany;

    private void Update()
    {
        if (levelRealtor != 13)
        {
            _textLevelRealtor.text = _localizationManager.translateMarketingLevel + " " + levelRealtor.ToString();
            _textCostRealtor.text = "RP " + costRealtor.ToString();
        }
        else
        {
            _textLevelRealtor.enabled = false;
            _textCostRealtor.text = "Max";
            _textCostRealtor.color = new Color(255, 255, 255);
        }
    }

    public void realtorUpgradeButton()
    {
        if (_mainGameMechanics.RecearchPoint >= costRealtor)
        {
            if (levelRealtor < 13)
            {
                levelRealtor++;
                _mainGameMechanics.RecearchPoint -= costRealtor;
                costRealtor += 10;
                ownCompany++;
                PlayerPrefs.SetInt("levelRealtorSave", levelRealtor);
                PlayerPrefs.SetInt("costRealtorSave", costRealtor);
                PlayerPrefs.SetInt("ownRealtorSave", ownCompany);
            } 
        }
    }
}
