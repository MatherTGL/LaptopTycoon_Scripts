using UnityEngine;
using UnityEngine.UI;

public class CheckSaveMarketing : MonoBehaviour
{
    [SerializeField] private MarketingSettings _marketingSettings;
    public byte levelMarketingObject;
    public Text textLevelMarketingConfirm;

    [Header("Картинка маркетинга")]
    public GameObject imageMarketing;

    private void Awake()
    {
        textLevelMarketingConfirm.text = "Level " + levelMarketingObject.ToString();
        if (_marketingSettings.nameMarketing == "SMM")
        {
            if (PlayerPrefs.HasKey("levelMarketingSMM"))
            {
                _marketingSettings.levelMarketing = (byte)PlayerPrefs.GetInt("levelMarketingSMM");
                _marketingSettings.costMarketing = PlayerPrefs.GetInt("costMarketingSMM");
                levelMarketingObject = _marketingSettings.levelMarketing;
                _marketingSettings.minFunMarketing = PlayerPrefs.GetInt("minFunsMarketingSMM");
                _marketingSettings.maxFunMarketing = PlayerPrefs.GetInt("maxFunsMarketingSMM");
                textLevelMarketingConfirm.text = "Level " + levelMarketingObject.ToString();
                _marketingSettings.textLevelMarketing.text = levelMarketingObject.ToString();
            }
        }

        if (_marketingSettings.nameMarketing == "Billboard")
        {
            if (PlayerPrefs.HasKey("levelMarketingBillboard"))
            {
                _marketingSettings.levelMarketing = (byte)PlayerPrefs.GetInt("levelMarketingBillboard");
                _marketingSettings.costMarketing = PlayerPrefs.GetInt("costMarketingBillboard");
                levelMarketingObject = _marketingSettings.levelMarketing;
                _marketingSettings.minFunMarketing = PlayerPrefs.GetInt("minFunsMarketingBillboard");
                _marketingSettings.maxFunMarketing = PlayerPrefs.GetInt("maxFunsMarketingBillboard");
                textLevelMarketingConfirm.text = "Level " + levelMarketingObject.ToString();
                _marketingSettings.textLevelMarketing.text = _marketingSettings.levelMarketing.ToString();
            }
        }

        if (_marketingSettings.nameMarketing == "TV")
        {
            if (PlayerPrefs.HasKey("levelMarketingTV"))
            {
                _marketingSettings.levelMarketing = (byte)PlayerPrefs.GetInt("levelMarketingTV");
                _marketingSettings.costMarketing = PlayerPrefs.GetInt("costMarketingTV");
                levelMarketingObject = _marketingSettings.levelMarketing;
                _marketingSettings.minFunMarketing = PlayerPrefs.GetInt("minFunsMarketingTV");
                _marketingSettings.maxFunMarketing = PlayerPrefs.GetInt("maxFunsMarketingTV");
                textLevelMarketingConfirm.text = "Level " + levelMarketingObject.ToString();
                _marketingSettings.textLevelMarketing.text = levelMarketingObject.ToString();
            }
        }

        if (_marketingSettings.nameMarketing == "Journal")
        {
            if (PlayerPrefs.HasKey("levelMarketingJournal"))
            {
                _marketingSettings.levelMarketing = (byte)PlayerPrefs.GetInt("levelMarketingJournal");
                _marketingSettings.costMarketing = PlayerPrefs.GetInt("costMarketingJournal");
                levelMarketingObject = _marketingSettings.levelMarketing;
                _marketingSettings.minFunMarketing = PlayerPrefs.GetInt("minFunsMarketingJournal");
                _marketingSettings.maxFunMarketing = PlayerPrefs.GetInt("maxFunsMarketingJournal");
                textLevelMarketingConfirm.text = "Level " + levelMarketingObject.ToString();
                _marketingSettings.textLevelMarketing.text = levelMarketingObject.ToString();
            }
        }

        if (_marketingSettings.nameMarketing == "Radio")
        {
            if (PlayerPrefs.HasKey("levelMarketingRadio"))
            {
                _marketingSettings.levelMarketing = (byte)PlayerPrefs.GetInt("levelMarketingRadio");
                _marketingSettings.costMarketing = PlayerPrefs.GetInt("costMarketingRadio");
                levelMarketingObject = _marketingSettings.levelMarketing;
                _marketingSettings.minFunMarketing = PlayerPrefs.GetInt("minFunsMarketingRadio");
                _marketingSettings.maxFunMarketing = PlayerPrefs.GetInt("maxFunsMarketingRadio");
                textLevelMarketingConfirm.text = "Level " + levelMarketingObject.ToString();
                _marketingSettings.textLevelMarketing.text = levelMarketingObject.ToString();
            }
        }

        if (_marketingSettings.nameMarketing == "E-Mail")
        {
            if (PlayerPrefs.HasKey("levelMarketingE-Mail"))
            {
                _marketingSettings.levelMarketing = (byte)PlayerPrefs.GetInt("levelMarketingE-Mail");
                _marketingSettings.costMarketing = PlayerPrefs.GetInt("costMarketingE-Mail");
                levelMarketingObject = _marketingSettings.levelMarketing;              
                _marketingSettings.minFunMarketing = PlayerPrefs.GetInt("minFunsMarketingE-Mail");
                _marketingSettings.maxFunMarketing = PlayerPrefs.GetInt("maxFunsMarketingE-Mail");
                textLevelMarketingConfirm.text = "Level " + levelMarketingObject.ToString();
                _marketingSettings.textLevelMarketing.text = levelMarketingObject.ToString();
            }
        }
    }

    private void Update() { textLevelMarketingConfirm.text = "Level " + levelMarketingObject.ToString(); }
}
