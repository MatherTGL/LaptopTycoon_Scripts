using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenCoverageCL : MonoBehaviour
{
    [Header("Доступы")]
    [SerializeField] private CreateLaptop _createLaptop;
    [SerializeField] private MainGameMechanics _mainGameMechanics;
    [SerializeField] private CoverageUpgrade _coverageUpgrade;
    [SerializeField] private FunctionPanelButton _functionPanelButton;
    [SerializeField] private checkInfoReleasePanel _checkInfoReleasePanel;

    [Header("Название покрытия")]
    public string nameCoverage; 
    public GameObject[] _greenCyrcle;
    [SerializeField] private byte _costCoverage;
    public Text _textNameDeactive;
    public Color _textColorNameDeactive;
    public Color _textColorNameActive;

    [SerializeField] private byte _levelCoverageManager;

    private void Start()
    {
        _greenCyrcle[0].SetActive(true);
        _greenCyrcle[1].SetActive(false);
    }

    private void OnEnable()
    {
        _greenCyrcle[0].SetActive(true);
        _greenCyrcle[1].SetActive(false);
    }

    public void CoverageGlossyButton()
    {
        if (!_greenCyrcle[0].activeSelf)
        {
            _greenCyrcle[0].SetActive(true);
            _greenCyrcle[1].SetActive(false);
            _mainGameMechanics.FullZeroCostLaptop = (ushort)(_mainGameMechanics.FullZeroCostLaptop - 70);
            _checkInfoReleasePanel.coverageLaptop = 0;
            _createLaptop.scoreRatingAverage -= 10;
        }
    }  
}
