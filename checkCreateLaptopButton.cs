using UnityEngine;
using UnityEngine.UI;

public class checkCreateLaptopButton : MonoBehaviour
{
    [SerializeField] private MainGameMechanics _mainGameMechanics;

    [SerializeField] private Button _createLaptopButton;
    [SerializeField] private Text _textCreateLaptop;
    [SerializeField] private Image _imageCreateLaptop;
    [SerializeField] private Color _deactiveColor;
    [SerializeField] private Color _activeColor;

    [SerializeField] private CreateLaptop _createLaptop;
    [SerializeField] private Tutorial _tutorial;

    private void OnEnable()
    {
        if (_mainGameMechanics.staffsPlayer == 0) { _createLaptopButton.interactable = false; _textCreateLaptop.color = _deactiveColor; _imageCreateLaptop.color = _deactiveColor; }  
        else { _createLaptopButton.interactable = true; _textCreateLaptop.color = _activeColor; _imageCreateLaptop.color = _activeColor; }
         
        if (_createLaptop.createInfoLaptopPanel.activeSelf) { _createLaptopButton.interactable = false; _textCreateLaptop.color = _deactiveColor; _imageCreateLaptop.color = _deactiveColor; }          
        else { _createLaptopButton.interactable = true; _textCreateLaptop.color = _activeColor; _imageCreateLaptop.color = _activeColor; }        
    }

    void Update()
    {
        if (_mainGameMechanics.staffsPlayer == 0) { _createLaptopButton.interactable = false; _textCreateLaptop.color = _deactiveColor; _imageCreateLaptop.color = _deactiveColor; }
        else { _createLaptopButton.interactable = true; _textCreateLaptop.color = _activeColor; _imageCreateLaptop.color = _activeColor; }
           
        if (_createLaptop.createInfoLaptopPanel.activeSelf) { _createLaptopButton.interactable = false; _textCreateLaptop.color = _deactiveColor; _imageCreateLaptop.color = _deactiveColor; }          
           
        if (_tutorial.activeTutorial == true)
        {
            if (_mainGameMechanics.staffsPlayer == 0) { _createLaptopButton.interactable = false; _textCreateLaptop.color = _deactiveColor; _imageCreateLaptop.color = _deactiveColor; }
            else { _createLaptopButton.interactable = true; _textCreateLaptop.color = _activeColor; _imageCreateLaptop.color = _activeColor; }
        }
    }
}
