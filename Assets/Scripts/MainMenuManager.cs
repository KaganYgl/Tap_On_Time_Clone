using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    private bool isGameStarted;
    [SerializeField] private GameObject mainMenuPanel;

    private void Awake()
    {
        isGameStarted = false;
        mainMenuPanel.SetActive(true);
        Time.timeScale = 0.3f;
    }

    public void StartTheGame()
    {
        isGameStarted = true;
        Time.timeScale = 1;
        mainMenuPanel.SetActive(false);
    }

    public bool IsGameStarted()
    {
        return isGameStarted;
    }
}
