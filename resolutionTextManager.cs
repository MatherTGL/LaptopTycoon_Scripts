using UnityEngine;
using UnityEngine.UI;

public class resolutionTextManager : MonoBehaviour
{
    public Text textResolutionRelease;
    public byte checkResolutionNumber = 1;

    void OnEnable()
    {
        if (checkResolutionNumber == 1) { textResolutionRelease.text = "FHD"; }
        else if (checkResolutionNumber == 2) { textResolutionRelease.text = "QHD"; }
        else if (checkResolutionNumber == 3) { textResolutionRelease.text = "4K"; }
        else if (checkResolutionNumber == 4) { textResolutionRelease.text = "5K"; }
        else if (checkResolutionNumber == 5) { textResolutionRelease.text = "8K"; }
        else  { textResolutionRelease.text = "10K"; }
    }
}
