using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManufacturerMemory : MonoBehaviour
{
    [SerializeField] private FunctionPanelButton _functionPanelButton;
    [SerializeField] private Text _manufacturerText;
    [SerializeField] private byte _currentManufacturer = 1;

    [SerializeField] private Button _plusManufacturerButton;
    [SerializeField] private Button _minusManufacturerButton;

    [SerializeField] private Image _plusManufacturerImage;
    [SerializeField] private Image _minusManufacturerImage;

    [SerializeField] private Color _deactiveColor;
    [SerializeField] private Color _activeColor;

    private void OnEnable()
    {
        _currentManufacturer = 1;        
    }

    void Update()
    {
        if (_functionPanelButton.CreateLaptopPanel.activeSelf)
        {
            if (_currentManufacturer == 1) { _manufacturerText.text = "SAMSANG"; }
            if (_currentManufacturer == 2) { _manufacturerText.text = "HypurEX"; }
            if (_currentManufacturer == 3) { _manufacturerText.text = "Crucal"; }
            if (_currentManufacturer == 4) { _manufacturerText.text = "GSkilo"; }
            if (_currentManufacturer == 5) { _manufacturerText.text = "Adota"; }
            if (_currentManufacturer == 6) { _manufacturerText.text = "Corsary"; }
            if (_currentManufacturer == 7) { _manufacturerText.text = "King Stone"; }
            if (_currentManufacturer == 8) { _manufacturerText.text = "GodRam"; }
            if (_currentManufacturer == 9) { _manufacturerText.text = "PatroMem"; }
            if (_currentManufacturer == 10) { _manufacturerText.text = "Gegobute"; }

            if (_currentManufacturer == 1) 
            {
                _plusManufacturerButton.interactable = true;
                _minusManufacturerButton.interactable = false;
                _minusManufacturerImage.color = _deactiveColor;
                _plusManufacturerImage.color = _activeColor;
            }
            else if (_currentManufacturer == 10) 
            {
                _plusManufacturerButton.interactable = false;
                _minusManufacturerButton.interactable = true;
                _minusManufacturerImage.color = _activeColor;
                _plusManufacturerImage.color = _deactiveColor;
            }
            else 
            {
                _plusManufacturerButton.interactable = true;
                _minusManufacturerButton.interactable = true;
                _minusManufacturerImage.color = _activeColor;
                _plusManufacturerImage.color = _activeColor;
            }
        }
    }

    public void plusManufacturerButton()
    {
        if (_currentManufacturer != 10) { _currentManufacturer++; }
    }

    public void minusManufacturerButton()
    {
        if (_currentManufacturer != 1) { _currentManufacturer--; }
    }
}
