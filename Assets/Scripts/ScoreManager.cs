using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private int score;
    private int highScore;
    [SerializeField] private TextMeshProUGUI highScoreText;
    [SerializeField] private TextMeshProUGUI scoreText;

    public void Start()
    {   score = 0;
        highScore = PlayerPrefs.GetInt("HighScore");
        highScoreText.text = "Best\n" + highScore.ToString();
    }

    public void IncreaseScore()
    {
        score += 1;
        scoreText.text = score.ToString();
    }

    public void IncreaseHighScore()
    {
        if (score > highScore)
        {
            highScore = score;
            highScoreText.text = "Best\n" + highScore.ToString();
        }
    }

    private void OnDestroy()
    {
        PlayerPrefs.SetInt("HighScore", highScore);
        PlayerPrefs.Save();
    }
}
