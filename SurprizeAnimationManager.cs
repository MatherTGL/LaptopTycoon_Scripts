using UnityEngine;

public class SurprizeAnimationManager : MonoBehaviour
{
    [SerializeField] private Animator _chestAnimator;
    [SerializeField] private SurprizeChest _surprizeChest;

    void Start()
    {
        _chestAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        if (_surprizeChest.ChestImage.enabled == false) { _chestAnimator.SetBool("checkActiveSurprize", false); }
        else { _chestAnimator.SetBool("checkActiveSurprize", true); }
    }
}
