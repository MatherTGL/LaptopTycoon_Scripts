using UnityEngine;
using UnityEngine.UI;

public class VideocardManager : MonoBehaviour
{
    [SerializeField] private GameData _gameData;
    [SerializeField] private CreateLaptop _createLaptop;
    [SerializeField] private MainGameMechanics _mainGameMechanics;
    [SerializeField] private CoolingLaptopUpgrade _coolingLaptopUpgrade;
    [SerializeField] private WaterCooling _waterCooling;
    [SerializeField] private videocardData _videocardData;

    [SerializeField] private checkFpsTestGames _checkFpsTestGames;
    public Slider powerSlider;
    public Slider performanceSlider;
    [SerializeField] private byte _checkMaxVideocard;
    [SerializeField] private byte _currentVideocard;
    public GameObject[] defaultVideocards;
    public Button[] videocardButtonList;

    void Start() { _currentVideocard = 1; }

    private void OnEnable()
    {
        _currentVideocard = 1;
        defaultVideocards[0].SetActive(true);
        defaultVideocards[1].SetActive(false);
        _checkFpsTestGames.nameVideocard = "RYX 550";
    }

    void Update()
    {
        if (_gameData.Year >= 2025) { _checkMaxVideocard = 17; performanceSlider.maxValue = 145000; }
        else { _checkMaxVideocard = 11; }

        if (_currentVideocard == 1)
        {
            defaultVideocards[0].SetActive(true);
            defaultVideocards[1].SetActive(false);
            videocardButtonList[0].interactable = false;
        }

        if (_currentVideocard >= 1) { videocardButtonList[1].interactable = true; }
           
        if (_currentVideocard > 1) { videocardButtonList[0].interactable = true; videocardButtonList[1].interactable = true; }
            
        if (_gameData.Year < 2025) { if (_currentVideocard == 11) { videocardButtonList[1].interactable = false; } }
        if (_gameData.Year >= 2025) { if (_currentVideocard == 17) { videocardButtonList[1].interactable = false; } }
    }

    public void leftVideocardLaptopButton()
    {
        if (_currentVideocard != 1)
        {
            _currentVideocard--;
            _mainGameMechanics.FullZeroCostLaptop -= 40;
            _createLaptop.scoreRatingAverage -= 5;
            switch (_currentVideocard)
            {
                case 1:
                    defaultVideocards[0].SetActive(true);
                    defaultVideocards[1].SetActive(false);
                    _checkFpsTestGames.nameVideocard = "RYX 550";
                    break;
                case 2:
                    defaultVideocards[0].SetActive(false);
                    defaultVideocards[1].SetActive(true);
                    defaultVideocards[2].SetActive(false);
                    _checkFpsTestGames.nameVideocard = "MGX 1050";
                    break;
                case 3:
                    defaultVideocards[1].SetActive(false);
                    defaultVideocards[2].SetActive(true);
                    defaultVideocards[3].SetActive(false);
                    _checkFpsTestGames.nameVideocard = "MGX 1050 TI";
                    break;
                case 4:
                    defaultVideocards[2].SetActive(false);
                    defaultVideocards[3].SetActive(true);
                    defaultVideocards[4].SetActive(false);
                    _checkFpsTestGames.nameVideocard = "MGX 1650";
                    break;
                case 5:
                    defaultVideocards[3].SetActive(false);
                    defaultVideocards[4].SetActive(true);
                    defaultVideocards[5].SetActive(false);
                    _checkFpsTestGames.nameVideocard = "MGX 1060";
                    break;
                case 6:
                    defaultVideocards[4].SetActive(false);
                    defaultVideocards[5].SetActive(true);
                    defaultVideocards[6].SetActive(false);
                    _checkFpsTestGames.nameVideocard = "MGX 1070 TI";
                    break;
                case 7:
                    defaultVideocards[5].SetActive(false);
                    defaultVideocards[6].SetActive(true);
                    defaultVideocards[7].SetActive(false);
                    _checkFpsTestGames.nameVideocard = "RGX 2060";
                    break;
                case 8:
                    defaultVideocards[6].SetActive(false);
                    defaultVideocards[7].SetActive(true);
                    defaultVideocards[8].SetActive(false);
                    _checkFpsTestGames.nameVideocard = "RGX 2060s";
                    break;
                case 9:
                    defaultVideocards[7].SetActive(false);
                    defaultVideocards[8].SetActive(true);
                    defaultVideocards[9].SetActive(false);
                    _checkFpsTestGames.nameVideocard = "RGX 2070";
                    break;
                case 10:
                    defaultVideocards[8].SetActive(false);
                    defaultVideocards[9].SetActive(true);
                    defaultVideocards[10].SetActive(false);
                    _checkFpsTestGames.nameVideocard = "RGX 2070s";
                    break;
                case 11:
                    defaultVideocards[9].SetActive(false);
                    defaultVideocards[10].SetActive(true);
                    defaultVideocards[11].SetActive(false);
                    _checkFpsTestGames.nameVideocard = "RGX 2080 TI";
                    break;
                case 12:
                    defaultVideocards[10].SetActive(false);
                    defaultVideocards[11].SetActive(true);
                    defaultVideocards[12].SetActive(false);
                    _checkFpsTestGames.nameVideocard = "RGX 3070";
                    break;
                case 13:
                    defaultVideocards[11].SetActive(false);
                    defaultVideocards[12].SetActive(true);
                    defaultVideocards[13].SetActive(false);
                    _checkFpsTestGames.nameVideocard = "RGX 3070s";
                    break;
                case 14:
                    defaultVideocards[12].SetActive(false);
                    defaultVideocards[13].SetActive(true);
                    defaultVideocards[14].SetActive(false);
                    _checkFpsTestGames.nameVideocard = "RGX 3080";
                    break;
                case 15:
                    defaultVideocards[13].SetActive(false);
                    defaultVideocards[14].SetActive(true);
                    defaultVideocards[15].SetActive(false);
                    _checkFpsTestGames.nameVideocard = "RGX 3080s";
                    break;
                case 16:
                    defaultVideocards[14].SetActive(false);
                    defaultVideocards[15].SetActive(true);
                    defaultVideocards[16].SetActive(false);
                    _checkFpsTestGames.nameVideocard = "RGX 3090";
                    break;
                case 17:
                    defaultVideocards[15].SetActive(false);
                    defaultVideocards[16].SetActive(true);
                    defaultVideocards[17].SetActive(false);
                    _checkFpsTestGames.nameVideocard = "RGX 3090s";
                    break;
            }
        }
    }

    public void rightVideocardLaptopButton()
    {
        if (_checkMaxVideocard != _currentVideocard)
        {
            _currentVideocard++;
            _mainGameMechanics.FullZeroCostLaptop += 40;
            _createLaptop.scoreRatingAverage += 5;
            switch (_currentVideocard)
            {
                case 1:
                    defaultVideocards[0].SetActive(true);
                    defaultVideocards[1].SetActive(false);
                    _checkFpsTestGames.nameVideocard = "RYX 550";
                    break;
                case 2:
                    defaultVideocards[0].SetActive(false);
                    defaultVideocards[1].SetActive(true);
                    defaultVideocards[2].SetActive(false);
                    _checkFpsTestGames.nameVideocard = "MGX 1050";
                    break;
                case 3:
                    defaultVideocards[1].SetActive(false);
                    defaultVideocards[2].SetActive(true);
                    defaultVideocards[3].SetActive(false);
                    _checkFpsTestGames.nameVideocard = "MGX 1050 TI";
                    break;
                case 4:
                    defaultVideocards[2].SetActive(false);
                    defaultVideocards[3].SetActive(true);
                    defaultVideocards[4].SetActive(false);
                    _checkFpsTestGames.nameVideocard = "MGX 1650";
                    break;
                case 5:
                    defaultVideocards[3].SetActive(false);
                    defaultVideocards[4].SetActive(true);
                    defaultVideocards[5].SetActive(false);
                    _checkFpsTestGames.nameVideocard = "MGX 1060";
                    break;
                case 6:
                    defaultVideocards[4].SetActive(false);
                    defaultVideocards[5].SetActive(true);
                    defaultVideocards[6].SetActive(false);
                    _checkFpsTestGames.nameVideocard = "MGX 1070 TI";
                    break;
                case 7:
                    defaultVideocards[5].SetActive(false);
                    defaultVideocards[6].SetActive(true);
                    defaultVideocards[7].SetActive(false);
                    _checkFpsTestGames.nameVideocard = "RGX 2060";
                    break;
                case 8:
                    defaultVideocards[6].SetActive(false);
                    defaultVideocards[7].SetActive(true);
                    defaultVideocards[8].SetActive(false);
                    _checkFpsTestGames.nameVideocard = "RGX 2060s";
                    break;
                case 9:
                    defaultVideocards[7].SetActive(false);
                    defaultVideocards[8].SetActive(true);
                    defaultVideocards[9].SetActive(false);
                    _checkFpsTestGames.nameVideocard = "RGX 2070";
                    break;
                case 10:
                    defaultVideocards[8].SetActive(false);
                    defaultVideocards[9].SetActive(true);
                    defaultVideocards[10].SetActive(false);
                    _checkFpsTestGames.nameVideocard = "RGX 2070s";
                    break;
                case 11:
                    defaultVideocards[9].SetActive(false);
                    defaultVideocards[10].SetActive(true);
                    defaultVideocards[11].SetActive(false);
                    _checkFpsTestGames.nameVideocard = "RGX 2080 TI";
                    break;
                case 12:
                    defaultVideocards[10].SetActive(false);
                    defaultVideocards[11].SetActive(true);
                    defaultVideocards[12].SetActive(false);
                    _checkFpsTestGames.nameVideocard = "RGX 3070";
                    break;
                case 13:
                    defaultVideocards[11].SetActive(false);
                    defaultVideocards[12].SetActive(true);
                    defaultVideocards[13].SetActive(false);
                    _checkFpsTestGames.nameVideocard = "RGX 3070s";
                    break;
                case 14:
                    defaultVideocards[12].SetActive(false);
                    defaultVideocards[13].SetActive(true);
                    defaultVideocards[14].SetActive(false);
                    _checkFpsTestGames.nameVideocard = "RGX 3080";
                    break;
                case 15:
                    defaultVideocards[13].SetActive(false);
                    defaultVideocards[14].SetActive(true);
                    defaultVideocards[15].SetActive(false);
                    _checkFpsTestGames.nameVideocard = "RGX 3080s";
                    break;
                case 16:
                    defaultVideocards[14].SetActive(false);
                    defaultVideocards[15].SetActive(true);
                    defaultVideocards[16].SetActive(false);
                    _checkFpsTestGames.nameVideocard = "RGX 3090";
                    break;
                case 17:
                    defaultVideocards[15].SetActive(false);
                    defaultVideocards[16].SetActive(true);
                    defaultVideocards[17].SetActive(false);
                    _checkFpsTestGames.nameVideocard = "RGX 3090s";
                    break;
            }
        }
    }
}
