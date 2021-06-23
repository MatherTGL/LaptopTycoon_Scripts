using UnityEngine;
using UnityEngine.UI;

public class MarketingUpgrade : MonoBehaviour
{
    [SerializeField] private MarketingSettings _marketingSettings;
    [SerializeField] private MainGameMechanics _mainGameMechanics;
    [SerializeField] private CheckSaveMarketing _checkSaveMarketing;
    [SerializeField] private LocalizationManager _localizationManager;

    [SerializeField] private Text _textCostUpgradeMarketing;

    private void Update()
    {
        if (_checkSaveMarketing.levelMarketingObject != 5)
        {
            _marketingSettings.levelTextSpec.text = _localizationManager.translateMarketingLevel + " " + _marketingSettings.levelMarketing.ToString();
            _textCostUpgradeMarketing.text = "RP " + _marketingSettings.costUpgradeMarketing;
        }
        else
        {
            _marketingSettings.levelTextSpec.enabled = false;
            _textCostUpgradeMarketing.text = "Max";
            _textCostUpgradeMarketing.color = new Color(255, 255, 255);
        }      
    }

    public void UpgradeMarketingButton()
    {
        if (_mainGameMechanics.RecearchPoint >= _marketingSettings.costUpgradeMarketing)
        {
            if (_checkSaveMarketing.levelMarketingObject != 5)
            {
                _marketingSettings.levelMarketing++;
                _checkSaveMarketing.levelMarketingObject++;
                _marketingSettings.costMarketing += 100000;
                _mainGameMechanics.RecearchPoint -= (ushort)_marketingSettings.costUpgradeMarketing;
                _marketingSettings.levelTextSpec.text = _localizationManager.translateMarketingLevel + " " + _marketingSettings.levelMarketing.ToString();
                _marketingSettings.minFunMarketing += 50;
                _marketingSettings.maxFunMarketing += 100;
                _marketingSettings.defaultMarketingMaxFun += 100;


                if (_marketingSettings.nameMarketing == "Radio")
                {
                    PlayerPrefs.SetInt("levelMarketingRadio", _checkSaveMarketing.levelMarketingObject);
                    PlayerPrefs.SetInt("costMarketingRadio", _marketingSettings.costMarketing);
                    PlayerPrefs.SetInt("minFunsMarketingRadio", _marketingSettings.minFunMarketing);
                    PlayerPrefs.SetInt("maxFunsMarketingRadio", _marketingSettings.maxFunMarketing);
                }
                if (_marketingSettings.nameMarketing == "Journal")
                {
                    PlayerPrefs.SetInt("levelMarketingJournal", _checkSaveMarketing.levelMarketingObject);
                    PlayerPrefs.SetInt("costMarketingJournal", _marketingSettings.costMarketing);
                    PlayerPrefs.SetInt("minFunsMarketingJournal", _marketingSettings.minFunMarketing);
                    PlayerPrefs.SetInt("maxFunsMarketingJournal", _marketingSettings.maxFunMarketing);
                }
                if (_marketingSettings.nameMarketing == "TV")
                {
                    PlayerPrefs.SetInt("levelMarketingTV", _checkSaveMarketing.levelMarketingObject);
                    PlayerPrefs.SetInt("costMarketingTV", _marketingSettings.costMarketing);
                    PlayerPrefs.SetInt("minFunsMarketingTV", _marketingSettings.minFunMarketing);
                    PlayerPrefs.SetInt("maxFunsMarketingTV", _marketingSettings.maxFunMarketing);
                }
                if (_marketingSettings.nameMarketing == "Billboard")
                {
                    PlayerPrefs.SetInt("levelMarketingBillboard", _checkSaveMarketing.levelMarketingObject);
                    PlayerPrefs.SetInt("costMarketingBillboard", _marketingSettings.costMarketing);
                    PlayerPrefs.SetInt("minFunsMarketingBillboard", _marketingSettings.minFunMarketing);
                    PlayerPrefs.SetInt("maxFunsMarketingBillboard", _marketingSettings.maxFunMarketing);
                }
                if (_marketingSettings.nameMarketing == "SMM")
                {
                    PlayerPrefs.SetInt("levelMarketingSMM", _checkSaveMarketing.levelMarketingObject);
                    PlayerPrefs.SetInt("costMarketingSMM", _marketingSettings.costMarketing);
                    PlayerPrefs.SetInt("minFunsMarketingSMM", _marketingSettings.minFunMarketing);
                    PlayerPrefs.SetInt("maxFunsMarketingSMM", _marketingSettings.maxFunMarketing);
                }
                if (_marketingSettings.nameMarketing == "E-Mail")
                {
                    PlayerPrefs.SetInt("levelMarketingE-Mail", _checkSaveMarketing.levelMarketingObject);
                    PlayerPrefs.SetInt("costMarketingE-Mail", _marketingSettings.costMarketing);
                    PlayerPrefs.SetInt("minFunsMarketingE-Mail", _marketingSettings.minFunMarketing);
                    PlayerPrefs.SetInt("maxFunsMarketingE-Mail", _marketingSettings.maxFunMarketing);
                }
            }
        }
    }
}
