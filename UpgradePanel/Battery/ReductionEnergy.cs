using UnityEngine;
using UnityEngine.UI;

public class ReductionEnergy : MonoBehaviour
{
    [SerializeField] private MainGameMechanics _mainGameMechanics;
    [SerializeField] private LocalizationManager _localizationManager;

    [SerializeField] private byte _costReductionEnergy;
    [SerializeField] private Text _textCostReductionEnergy;
    public byte levelReductionEnergy;
    [SerializeField] private Text _textLevelReductionEnergy;

    void Start()
    {
        if (PlayerPrefs.HasKey("levelReductionEnergy")) { levelReductionEnergy = (byte)PlayerPrefs.GetInt("levelReductionEnergy"); }
    }

    private void Update()
    {
        if (levelReductionEnergy != 8)
        {
            _textCostReductionEnergy.text = "RP " + _costReductionEnergy;
            _textLevelReductionEnergy.text = _localizationManager.translateMarketingLevel + " " + levelReductionEnergy;
        }
        else
        {
            _textLevelReductionEnergy.enabled = false;
            _textCostReductionEnergy.text = "Max";
            _textCostReductionEnergy.color = new Color(255, 255, 255);
        }
    }

    public void ReductionEnergyButton()
    {
        if (_mainGameMechanics.RecearchPoint >= _costReductionEnergy)
        {
            if (levelReductionEnergy != 8)
            {
                _mainGameMechanics.RecearchPoint -= _costReductionEnergy;
                levelReductionEnergy++;
                PlayerPrefs.SetInt("levelReductionEnergy", levelReductionEnergy);
            }
        }
    }
}
