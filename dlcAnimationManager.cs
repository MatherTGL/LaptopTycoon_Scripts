using UnityEngine;

public class dlcAnimationManager : MonoBehaviour
{
    [Header("Доступ к скриптам:")]
    [SerializeField] private FunctionPanelButton _functionPanelButton;
    [Header("Аниматор DLC панели")]
    public Animator animatorDLCPanel;

    void Start() { animatorDLCPanel.GetComponent<Animator>(); }
}
