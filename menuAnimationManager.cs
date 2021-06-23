using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuAnimationManager : MonoBehaviour
{
    [Header("Доступ к скриптам:")]
    [SerializeField] private FunctionPanelButton _functionPanelButton;
    [Header("Аниматор Menu Scroll панели")]
    public Animator animatorMenuScrollPanel;

    void Start()
    {
        animatorMenuScrollPanel.GetComponent<Animator>();
    }
}
