using UnityEngine;
using UnityEngine.UI;

public class menuScrollManager : MonoBehaviour
{
    [SerializeField] private Scrollbar _menuScrollbar;

    private void OnEnable() { _menuScrollbar.value = 0; }
}
