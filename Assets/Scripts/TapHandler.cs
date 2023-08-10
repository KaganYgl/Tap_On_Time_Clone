using UnityEngine;

public class TapHandler : MonoBehaviour
{
    [SerializeField] private CollisionHandler collisionHandler;
    [SerializeField] private Spawner spawner;
    [SerializeField] private ScoreManager scoreManager;
    [SerializeField] private GameOverManager gameOverManager;
    [SerializeField] private MainMenuManager mainMenuManager;

    private void Update()
    {
        if (!gameOverManager.IsGameOver() && mainMenuManager.IsGameStarted())
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (collisionHandler.IsColliding())
                {
                    Debug.Log("success");
                    scoreManager.IncreaseScore();
                    scoreManager.IncreaseHighScore();
                    spawner.Spawn();
                }
                else
                {
                    Debug.Log("Fail");
                    gameOverManager.SetGameOver();
                }
            }
        }
    }
}
