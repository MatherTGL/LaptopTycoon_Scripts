using UnityEngine;
using UnityEngine.UI;

public class RatingGenerateText : MonoBehaviour
{
    [SerializeField] private RatingCreate _ratingCreate;

    [SerializeField] private Text _textNumbersRating;
    [SerializeField] private float _averageTextRating;
    public byte checkTypeText;

    private void OnEnable()
    {
        checkTypeText = (byte)Random.Range(1, 4);
         
        if (checkTypeText == 1)
        {
            _averageTextRating = _ratingCreate.AverageRating + Random.Range(-0.5f, +0.5f);
            _textNumbersRating.text = _averageTextRating.ToString(_ratingCreate.averageFormate);
        }   
        else if (checkTypeText == 2) { _textNumbersRating.text = "+"; }
        else { _textNumbersRating.text = "-"; }           
    }
}
