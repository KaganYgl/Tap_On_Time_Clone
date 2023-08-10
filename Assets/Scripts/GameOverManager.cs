using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    private bool isGameOver;
    [SerializeField] private GameObject gameOverPanel;

    private void Awake()
    {
        isGameOver = false;
        gameOverPanel.SetActive(false);
    }

    public void SetGameOver()
    {
        isGameOver = true;
        Time.timeScale = 0;
        gameOverPanel.SetActive(true);
    }

    public bool IsGameOver()
    {
        return isGameOver;
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
}
