using UnityEngine;

public class CreatingAverageRating : MonoBehaviour
{
    [SerializeField] private GameData _gameData;
    [Header("Сколько очков нужно")]
    public ushort scoresYearAverageRating;

    void Update()
    {
        if (_gameData.Year == 2019) { scoresYearAverageRating = 200; }          
        else if (_gameData.Year == 2020) { scoresYearAverageRating = 230; }           
        else if (_gameData.Year == 2021) { scoresYearAverageRating = 260; }           
        else if (_gameData.Year == 2022) { scoresYearAverageRating = 290; }            
        else if (_gameData.Year == 2023) { scoresYearAverageRating = 320; }          
        else if (_gameData.Year == 2024) { scoresYearAverageRating = 350; }           
        else if (_gameData.Year == 2025) { scoresYearAverageRating = 380; }          
        else if (_gameData.Year == 2026) { scoresYearAverageRating = 410; }           
        else if (_gameData.Year == 2027) { scoresYearAverageRating = 440; }            
        else if (_gameData.Year == 2028) { scoresYearAverageRating = 470; }           
        else if (_gameData.Year == 2029) { scoresYearAverageRating = 500; }          
        else if (_gameData.Year == 2030) { scoresYearAverageRating = 530; }            
        else if (_gameData.Year == 2031) { scoresYearAverageRating = 560; }          
        else if (_gameData.Year == 2032) { scoresYearAverageRating = 590; }          
        else if (_gameData.Year == 2033) { scoresYearAverageRating = 620; }            
        else if (_gameData.Year == 2034) { scoresYearAverageRating = 650; }            
        else if (_gameData.Year == 2035) { scoresYearAverageRating = 680; }            
        else if (_gameData.Year == 2036) { scoresYearAverageRating = 710; }          
        else if (_gameData.Year == 2037) { scoresYearAverageRating = 740; }           
        else if (_gameData.Year == 2038) { scoresYearAverageRating = 770; }           
        else if (_gameData.Year == 2039) { scoresYearAverageRating = 800; }            
        else if (_gameData.Year == 2040) { scoresYearAverageRating = 830; }           
        else if (_gameData.Year == 2041) { scoresYearAverageRating = 860; }          
        else if (_gameData.Year == 2042) { scoresYearAverageRating = 890; }           
        else if (_gameData.Year == 2043) { scoresYearAverageRating = 920; }          
        else if (_gameData.Year == 2044) { scoresYearAverageRating = 950; }           
        else if (_gameData.Year == 2045) { scoresYearAverageRating = 980; }         
        else if (_gameData.Year == 2046) { scoresYearAverageRating = 1010; }           
        else if (_gameData.Year == 2047) { scoresYearAverageRating = 1040; }
        else if (_gameData.Year == 2048) { scoresYearAverageRating = 1070; }
        else if (_gameData.Year == 2049) { scoresYearAverageRating = 1100; }          
        else if (_gameData.Year == 2050) { scoresYearAverageRating = 1130; }
    }
}
