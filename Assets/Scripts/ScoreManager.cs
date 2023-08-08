using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private int Score=0;
    [SerializeField] private TextMeshProUGUI highScore;
    [SerializeField] private TextMeshProUGUI score;

    public void Start()
    {
        highScore.text = "Best\n" + PlayerPrefs.GetInt("HighScore").ToString();
    }

    public void IncreaseScore()
    {
        Score += 1;
        score.text = Score.ToString();
    }

    public void IncreaseHighScore()
    {
        if (Score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", Score);
            highScore.text = "Best\n" + PlayerPrefs.GetInt("HighScore").ToString();
            PlayerPrefs.Save();
        }
    }
}
