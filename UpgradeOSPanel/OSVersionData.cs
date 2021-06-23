using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class OSVersionData : MonoBehaviour
{
    [Header("1.0.0")]
    [SerializeField] private byte _firstNumberVersion; //1.0.0
    [Header("0.1.0")]
    [SerializeField] private byte _secondNumberVersion; //0.1.0
    [Header("0.0.1")]
    public byte thirdNumberVersion; //0.0.1
    [SerializeField] private Text _textVersionOS;

    [SerializeField] private MainGameMechanics _mainGameMechanics;
    [SerializeField] private Text _receatchPointOSPanel;

    void Start()
    {
        if (PlayerPrefs.HasKey("firstVersionOS"))
        {
            thirdNumberVersion = (byte)PlayerPrefs.GetInt("versionOS");
            _secondNumberVersion = (byte)PlayerPrefs.GetInt("secondVersionOS");
            _firstNumberVersion = (byte)PlayerPrefs.GetInt("firstVersionOS");
        }
    }

    void Update()
    {
        _receatchPointOSPanel.text = _mainGameMechanics.RecearchPoint.ToString();
        if (thirdNumberVersion >= 15)
        {
            _secondNumberVersion++;
            thirdNumberVersion = 1;
            PlayerPrefs.SetInt("secondVersionOS", _secondNumberVersion);
        }
        if (_secondNumberVersion >= 18)
        {
            _firstNumberVersion++;
            _secondNumberVersion = 1;
            PlayerPrefs.SetInt("firstVersionOS", _firstNumberVersion);
        }
        _textVersionOS.text = "V " + _firstNumberVersion + "." + _secondNumberVersion + "." + thirdNumberVersion;
    }
}
