using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class osLaptopCreate : MonoBehaviour
{
    [SerializeField] private OpenOS _openOS;

    [Header("Номер ОС")]
    [SerializeField] private byte _checkActiveOS;
    [SerializeField] private Text _nameActiveOS;

    [Header("Кнопки")]
    [SerializeField] private Button _minusOSButton;
    [SerializeField] private Button _plusOSButton;

    void Start()
    {
        
    }

    private void OnEnable()
    {
        _checkActiveOS = 1;
    }

    void Update()
    {
        if (_checkActiveOS == 1)
        {
            _nameActiveOS.text = "WONDOW";
            _minusOSButton.interactable = false;
            _plusOSButton.interactable = true;
        }
        else if (_checkActiveOS == 2)
        {
            _nameActiveOS.text = "LOSOS";
            _minusOSButton.interactable = true;
            _plusOSButton.interactable = true;
        }
        else if (_checkActiveOS == 3)
        {
            _nameActiveOS.text = "MAGOS";
            if (_openOS._activeOSUpgrade == 0)
            {
                _minusOSButton.interactable = true;
                _plusOSButton.interactable = false;
            }
            else
            {
                _minusOSButton.interactable = true;
                _plusOSButton.interactable = true;
            }
        }
        else if (_checkActiveOS == 4)
        {
            _nameActiveOS.text = _openOS.namePlayerOS;
            _minusOSButton.interactable = true;
            _plusOSButton.interactable = false;
        }
    }

    public void plusOSLaptop()
    {
        if (_openOS._activeOSUpgrade == 0)
        {
            if (_checkActiveOS < 3)
            {
                _checkActiveOS++;
            }
        }
        else
        {
            if (_checkActiveOS < 4)
            {
                _checkActiveOS++;
            }
        }
    }

    public void minusOSLaptop()
    {
        if (_checkActiveOS != 1)
        {
            _checkActiveOS--;
        }
    }
}
