using UnityEngine;
using UnityEngine.UI;

public class Matrix : MonoBehaviour
{
    [SerializeField] private MainGameMechanics _mainGameMechanics;
    [SerializeField] private LocalizationManager _localizationManager;

    [SerializeField] private byte _costScreenMatrix;
    [SerializeField] private Text _textCostScreenMatrix;
    public byte levelScreenMatrix;
    [SerializeField] private Text _textLevelScreenMatrix;

    void Start()
    {
        if (PlayerPrefs.HasKey("levelScreenMatrix")) { levelScreenMatrix = (byte)PlayerPrefs.GetInt("levelScreenMatrix"); }
    }

    private void Update()
    {
        if (levelScreenMatrix != 8)
        {
            _textCostScreenMatrix.text = "RP " + _costScreenMatrix;
            _textLevelScreenMatrix.text = _localizationManager.translateMarketingLevel + " " + levelScreenMatrix;
        }
        else
        {
            _textCostScreenMatrix.text = "Max";
            _textCostScreenMatrix.color = new Color(255, 255, 255);
            _textLevelScreenMatrix.enabled = false;
        }
    }

    public void ScreenMatrixButton()
    {
        if (_mainGameMechanics.RecearchPoint >= _costScreenMatrix)
        {
            if (levelScreenMatrix != 8)
            {
                _mainGameMechanics.RecearchPoint -= _costScreenMatrix;
                levelScreenMatrix++;
                PlayerPrefs.SetInt("levelScreenMatrix", levelScreenMatrix);
            }
        }
    }
}
