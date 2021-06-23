using UnityEngine;
using UnityEngine.UI;

public class FrontalCameraUpgrade : MonoBehaviour
{
    [SerializeField] private MainGameMechanics _mainGameMechanics;
    [SerializeField] private CreateLaptop _createLaptop;
    [SerializeField] private LocalizationManager _localizationManager;

    [SerializeField] private byte _costFrontalCamera;
    [SerializeField] private Text _textcostFrontalCamera;
    public byte levelFrontalCamera;
    [SerializeField] private Text _textLevelFrontalCamera;

    [SerializeField] private byte _checkLevelFrontal;

    void Start()
    {
        if (PlayerPrefs.HasKey("levelFrontalCamera"))
        {
            levelFrontalCamera = (byte)PlayerPrefs.GetInt("levelFrontalCamera");
            _createLaptop.MPRearCam = (byte)PlayerPrefs.GetFloat("MPRearCam");
        }            
        if (!PlayerPrefs.HasKey("checkLevelFrontal"))
            if (levelFrontalCamera > 1) { _checkLevelFrontal = 1; levelFrontalCamera = 1; PlayerPrefs.SetInt("checkLevelFrontal", _checkLevelFrontal); PlayerPrefs.SetInt("levelFrontalCamera", levelFrontalCamera); }

    }

    private void Update()
    {
        if (levelFrontalCamera < 7) { _textLevelFrontalCamera.text = _localizationManager.translateMarketingLevel + " " + levelFrontalCamera; }
        if (levelFrontalCamera >= 7)
        {
            _textcostFrontalCamera.text = "Max";
            _textLevelFrontalCamera.enabled = false;
            _textcostFrontalCamera.color = new Color(255, 255, 255);
        }
    }

    public void frontalCameraButtonUpgrade()
    {
        if (levelFrontalCamera != 7)
        {
            if (_mainGameMechanics.RecearchPoint >= _costFrontalCamera)
            {
                _mainGameMechanics.RecearchPoint -= _costFrontalCamera;
                levelFrontalCamera++;
                PlayerPrefs.SetInt("levelFrontalCamera", levelFrontalCamera);
                _createLaptop.MPRearCam += 1;
                PlayerPrefs.SetFloat("MPRearCam", _createLaptop.MPRearCam);
            }
        }
    }
}
