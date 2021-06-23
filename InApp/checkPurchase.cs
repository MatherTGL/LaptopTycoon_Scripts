using UnityEngine;
using UnityEngine.Purchasing;

public class checkPurchase : MonoBehaviour
{
    [SerializeField] private adsManagerScr _adsManagerScr;

    void Start() { PurchaseManager.OnPurchaseNonConsumable += PurchaseManager_OnPurchaseNonConsumable; }
    private void PurchaseManager_OnPurchaseNonConsumable(PurchaseEventArgs args)
    {
        _adsManagerScr.checkNumberBuyAdsSave = 1;
        PlayerPrefs.SetInt("buyAdsSave", _adsManagerScr.checkNumberBuyAdsSave);
        _adsManagerScr.checkBuyAd = true;
    }
}
