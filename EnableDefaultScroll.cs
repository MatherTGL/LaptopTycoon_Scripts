using UnityEngine;
using UnityEngine.UI;

public class EnableDefaultScroll : MonoBehaviour
{
    [SerializeField] private Scrollbar _upgradePanelScrollbar;
    [Header("Value")]
    [SerializeField] private float _valueScrollbar;

    void Awake() { _upgradePanelScrollbar = GetComponent<Scrollbar>(); }

    private void OnEnable() { _upgradePanelScrollbar.value = _valueScrollbar; }
}
