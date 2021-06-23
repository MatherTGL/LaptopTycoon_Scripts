using UnityEngine;
using UnityEngine.UI;

public class FrontalCameraCP : MonoBehaviour
{
    [SerializeField] private FrontalCameraUpgrade _frontalCameraUpgrade;
    [SerializeField] private CreateLaptop _createLaptop;
    [SerializeField] private MainGameMechanics _mainGameMechanics;
    [SerializeField] private LocalizationManager _localizationManager;
    [SerializeField] private byte _mpFrontalCamera;
    [SerializeField] private Text _textMPFrontalCamera;

    [Header("Кнопки")]
    [SerializeField] private Button _plusFrontalCamera;
    [SerializeField] private Button _minusFrontalCamera;

    void Start() { _mpFrontalCamera = 2; }

    private void OnEnable() { _mpFrontalCamera = 2; }

    void Update()
    {
        _textMPFrontalCamera.text = _localizationManager.translateFrontalCameraCreate + " | 0." + _mpFrontalCamera + "MP";

        if (_mpFrontalCamera == _createLaptop.MPRearCam)
        {
            if (_createLaptop.MPRearCam > _mpFrontalCamera) { _minusFrontalCamera.interactable = false; _plusFrontalCamera.interactable = true; }
            else
            {
                if (_mpFrontalCamera != 2) { _minusFrontalCamera.interactable = true; _plusFrontalCamera.interactable = false; }
                else { _minusFrontalCamera.interactable = false; _plusFrontalCamera.interactable = false; }
            }
        }

        else if (_createLaptop.MPRearCam > _mpFrontalCamera)
        {
            if (_mpFrontalCamera != 2) { _minusFrontalCamera.interactable = true; _plusFrontalCamera.interactable = true; }
            else { _minusFrontalCamera.interactable = false; _plusFrontalCamera.interactable = true; }
        }

        if (_mpFrontalCamera == _createLaptop.MPRearCam)
        {
            if (_mpFrontalCamera != 2) { _minusFrontalCamera.interactable = true; _plusFrontalCamera.interactable = false; }
            else { _minusFrontalCamera.interactable = false; _plusFrontalCamera.interactable = false; }
        }
    }

    public void frontalCameraPlus()
    {
        if (_createLaptop.MPRearCam > _mpFrontalCamera)
        {
            _mpFrontalCamera += 1;
            _mainGameMechanics.FullZeroCostLaptop += 5;
            _createLaptop.scoreRatingAverage += 5;
        }
    }

    public void frontalCameraMines()
    {
        if (_mpFrontalCamera >= 0.3)
        {
            _mpFrontalCamera -= 1;
            _mainGameMechanics.FullZeroCostLaptop -= 5;
            _createLaptop.scoreRatingAverage -= 5;
        }
    }
}
