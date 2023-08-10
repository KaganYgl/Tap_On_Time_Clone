using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private int score=0;
    [SerializeField] private TextMeshProUGUI highScoreText;
    [SerializeField] private TextMeshProUGUI scoreText;

    public void Start()
    {
        highScoreText.text = "Best\n" + PlayerPrefs.GetInt("HighScore").ToString();
    }

    public void IncreaseScore()
    {
        score += 1;
        scoreText.text = score.ToString();
    }

    public void IncreaseHighScore()
    {
        if (score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", score);
            highScoreText.text = "Best\n" + PlayerPrefs.GetInt("HighScore").ToString();
            PlayerPrefs.Save();
        }
    }
}
