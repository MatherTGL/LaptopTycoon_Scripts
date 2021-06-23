using UnityEngine;
using UnityEngine.UI;

public class FaceIDUpgrade : MonoBehaviour
{
    [SerializeField] private MainGameMechanics _mainGameMechanics;
    [SerializeField] private LocalizationManager _localizationManager;

    [SerializeField] private byte _costFaceId;
    [SerializeField] private Text _textCostFaceID;
    [SerializeField] private byte unlockFaceID;
    [SerializeField] private Text _textUnlockFaceID;

    [SerializeField] private Color _unlockTextColor;
    public Toggle addFaceID;

    void Awake()
    {
        if (PlayerPrefs.HasKey("unlockFaceIDSave"))
        {
            unlockFaceID = (byte)PlayerPrefs.GetInt("unlockFaceIDSave");
            addFaceID.interactable = true;
        }           
    }

    private void Update()
    {
        if (unlockFaceID == 0)
        {
            if (_localizationManager._indexLanguage == 1) { _textUnlockFaceID.text = "Lock"; }
            else if (_localizationManager._indexLanguage == 2) { _textUnlockFaceID.text = "Закрыто"; }
            else { _textUnlockFaceID.text = "Stängd"; }
            _textCostFaceID.enabled = true;
        }
        else
        {
            if (_localizationManager._indexLanguage == 1) { _textCostFaceID.text = "Unlock"; }
            else if (_localizationManager._indexLanguage == 2) { _textCostFaceID.text = "Открыто"; }
            else { _textCostFaceID.text = "Öppet"; }
            _textCostFaceID.color = _unlockTextColor;
            _textUnlockFaceID.enabled = false;
        }
    }

    public void faceIdUpgradeButton()
    {
        if (unlockFaceID != 1)
        {
            if (_mainGameMechanics.RecearchPoint >= _costFaceId)
            {
                _mainGameMechanics.RecearchPoint -= _costFaceId;
                unlockFaceID = 1;
                _textUnlockFaceID.enabled = false;
                _textCostFaceID.color = _unlockTextColor;
                addFaceID.interactable = true;
                PlayerPrefs.SetInt("unlockFaceIDSave", unlockFaceID);
            }
        }
    }
}
