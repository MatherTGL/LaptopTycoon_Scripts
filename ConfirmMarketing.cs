using UnityEngine;

public class ConfirmMarketing : MonoBehaviour
{
    [SerializeField] private MarketingSettings _marketingSettings;
    [SerializeField] private settingsMarketingButton _settingsMarketingButton;
    [SerializeField] private FunctionPanelButton _functionPanelButton;
    [SerializeField] private MainGameMechanics _mainGameMechanics;
    [SerializeField] private CheckSaveMarketing _checkSaveMarketing;
   
    private void Awake() { _checkSaveMarketing.imageMarketing.SetActive(false); }

    public void ConfirmButton()
    {
        if (_mainGameMechanics.Money >= _marketingSettings.costMarketing)
        {
            if (_settingsMarketingButton.buyMarketingPanel.activeSelf)
            {
                _functionPanelButton._confirmPanel.SetActive(true);
                _marketingSettings.confirmButton.SetActive(true);
                _marketingSettings.dontConfirmButton.SetActive(true);
                _functionPanelButton.ScrollPanelMarketing.SetActive(false);
                _functionPanelButton.quitMarketingButton.SetActive(false);
                _checkSaveMarketing.imageMarketing.SetActive(true);
            }
        } 
    }
}
