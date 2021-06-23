using System;
using UnityEngine;
using UnityEngine.UI;

public class MyOSPanel : MonoBehaviour
{
    [Header("Доступ к другим скриптам")]
    private UpgradeTreeData _upgradeTreeData;
    [SerializeField] private MainGameMechanics _mainGameMechanics;
    [SerializeField] private FunctionPanelButton _functionPanelButton;
    private UpgradeTree _upgradeTree;

    [SerializeField] private Text[] _textRatingOS;
    [SerializeField] private int[] _ratingOSArray;

    public bool ActiveOSPanelBool;

    public UnityEngine.UI.Button ActiveOSPanel;

    public ushort RatingOS; //Рейтинг ОС игрока

    [Obsolete]
    private void Start()
    {
        if (PlayerPrefs.HasKey("RatingOSPlayer")) { RatingOS = (ushort)PlayerPrefs.GetInt("RatingOSPlayer"); }
        else
        {
            _ratingOSArray[0] = UnityEngine.Random.RandomRange(200, 3000);
            _ratingOSArray[1] = UnityEngine.Random.RandomRange(200, 3000);
            _ratingOSArray[2] = UnityEngine.Random.RandomRange(200, 3000);
            _ratingOSArray[3] = UnityEngine.Random.RandomRange(200, 3000);
            _ratingOSArray[4] = UnityEngine.Random.RandomRange(200, 3000);
            _ratingOSArray[5] = UnityEngine.Random.RandomRange(200, 3000);
            _ratingOSArray[6] = UnityEngine.Random.RandomRange(200, 3000);
            _ratingOSArray[7] = UnityEngine.Random.RandomRange(200, 3000);
            _ratingOSArray[8] = UnityEngine.Random.RandomRange(200, 3000);

            _textRatingOS[0].text = _ratingOSArray[0].ToString();
            _textRatingOS[1].text = _ratingOSArray[1].ToString();
            _textRatingOS[2].text = _ratingOSArray[2].ToString();
            _textRatingOS[3].text = _ratingOSArray[3].ToString();
            _textRatingOS[4].text = _ratingOSArray[4].ToString();
            _textRatingOS[5].text = _ratingOSArray[5].ToString();
            _textRatingOS[6].text = _ratingOSArray[6].ToString();
            _textRatingOS[7].text = _ratingOSArray[7].ToString();
            _textRatingOS[8].text = _ratingOSArray[8].ToString();
            _textRatingOS[9].text = RatingOS.ToString();
        }
    }

    private void Update() { _ratingOSArray[9] = RatingOS; _textRatingOS[9].text = RatingOS.ToString(); PlayerPrefs.SetInt("RatingOSPlayer", RatingOS); }
}
