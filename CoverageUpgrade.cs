using UnityEngine;
using UnityEngine.UI;

public class CoverageUpgrade : MonoBehaviour
{
    [SerializeField] private MainGameMechanics _mainGameMechanics;
    [SerializeField] private LocalizationManager _localizationManager;
    [SerializeField] private ScreenCoverageCL _screenCoverageCL;
    [SerializeField] private checkInfoReleasePanel _checkInfoReleasePanel;
    [SerializeField] private CreateLaptop _createLaptop;
    [SerializeField] private FunctionPanelButton _functionPanelButton;

    [SerializeField] private byte _costCoverage;
    [SerializeField] private Text _textCostCoverage;
    public byte levelCoverage;
    [SerializeField] private Text _textLevelCoverage;

    void Start()
    {
        if (PlayerPrefs.HasKey("levelCoverage")) { levelCoverage = (byte)PlayerPrefs.GetInt("levelCoverage"); }
           
    }

    private void Update()
    {
        if (_functionPanelButton.CreateLaptopPanel.activeSelf)
        {
            if (levelCoverage != 2) { _screenCoverageCL._textNameDeactive.color = _screenCoverageCL._textColorNameDeactive; }
            else { _screenCoverageCL._textNameDeactive.color = _screenCoverageCL._textColorNameActive; }
        }
       
        if (levelCoverage == 2)
        {
            _textLevelCoverage.enabled = false;
            _textCostCoverage.text = "Max";
            _textCostCoverage.color = new Color(255, 255, 255);
        }
        else { _textLevelCoverage.text = _localizationManager.translateMarketingLevel + " " + levelCoverage; }
    }

    public void CoverageMatteButton()
    {
        if (levelCoverage == 2)
        {
            if (!_screenCoverageCL._greenCyrcle[1].activeSelf)
            {
                _screenCoverageCL._greenCyrcle[0].SetActive(false);
                _screenCoverageCL._greenCyrcle[1].SetActive(true);
                _mainGameMechanics.FullZeroCostLaptop = (ushort)(_mainGameMechanics.FullZeroCostLaptop + 70);
                _checkInfoReleasePanel.coverageLaptop = 1;
                _createLaptop.scoreRatingAverage += 10;
                _screenCoverageCL._textNameDeactive.color = _screenCoverageCL._textColorNameActive;
            }
        }
    }

    public void coverageUpgradeButton()
    {
        if (_mainGameMechanics.RecearchPoint >= _costCoverage)
        {
            if (levelCoverage != 2)
            {
                levelCoverage++;
                _mainGameMechanics.RecearchPoint -= _costCoverage;
                _textLevelCoverage.enabled = false;
                _textCostCoverage.text = "Max";
                _textCostCoverage.color = new Color(255, 255, 255);
                PlayerPrefs.SetInt("levelCoverage", levelCoverage);
            }
        }
    }
}
