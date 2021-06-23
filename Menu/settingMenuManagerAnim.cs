using UnityEngine;

public class settingMenuManagerAnim : MonoBehaviour
{
    public Animator _settingAnimator;
    public Animator _settingLocalizationAnimator;
    [SerializeField] private FunctionPanelButton _functionPanelButton;
    void Start()
    {
        _settingAnimator = GetComponent<Animator>();
        _settingLocalizationAnimator = GetComponent<Animator>();
    }
}
