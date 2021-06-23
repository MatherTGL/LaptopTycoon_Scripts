using UnityEngine;
using UnityEngine.UI;

public class pushQuestManager : MonoBehaviour
{
    public Image _questImageButton;
    public Color pushCyrcleDefaultColor;

    public void colorDefaultQuestImage() { _questImageButton.color = pushCyrcleDefaultColor; }    
}
