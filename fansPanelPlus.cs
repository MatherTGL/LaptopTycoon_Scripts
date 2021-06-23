using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fansPanelPlus : MonoBehaviour
{
    [SerializeField] private MainGameMechanics _mainGameMechanics;
    [SerializeField] private static MarketingSettings _marketingSettings;
    [SerializeField] private static settingsMarketingButton _settingsMarketingButton;
    [SerializeField] private Text _textFansPlus;
    [SerializeField] private int _fans;
    
    private void OnEnable()
    {
        StartCoroutine(plusFansCor());
    }

    void Update()
    {
       
    }

    IEnumerator plusFansCor()
    {
        while(true)
        {
            Debug.Log("Старт");
            _fans = (int)(_mainGameMechanics.currenFunsMarketingBuy / _mainGameMechanics.validMarketingBuy);
            _marketingSettings.currentFunMarketing -= _fans;
            _textFansPlus.text = "+" + _fans;
            yield return new WaitForSeconds(1);
        }
    }
}
