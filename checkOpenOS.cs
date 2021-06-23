using UnityEngine;
using UnityEngine.UI;

public class checkOpenOS : MonoBehaviour
{
    [SerializeField] private OpenOS _openOS;
    [SerializeField] private Tutorial _tutorial;
    [SerializeField] private Button _buttonOSGameWindow;
    [SerializeField] private Text _textOSButton;
    [SerializeField] private Image _imageOSButton;
    [SerializeField] private Color _deactiveColor;
    [SerializeField] private Color _activeColor;

    void Update()
    {
        if (_openOS._activeOSUpgrade == 0) { _buttonOSGameWindow.interactable = false; _textOSButton.color = _deactiveColor; _imageOSButton.color = _deactiveColor; }            
        else { _buttonOSGameWindow.interactable = true; _textOSButton.color = _activeColor; _imageOSButton.color = _activeColor; }          
    }
}
