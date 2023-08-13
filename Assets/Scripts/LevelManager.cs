using UnityEditor;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private CollisionHandler collisionHandler;
    [SerializeField] private Spawner spawner;
    [SerializeField] private ScoreManager scoreManager;
    [SerializeField] private AudioManager audioManager;

    private void Awake()
    {
        gameObject.SetActive(false);
        GameManager.OnGameStateChanged += StateAction;
    }

    private void OnDestroy()
    {
        GameManager.OnGameStateChanged -= StateAction;
    }

    private void StateAction(GameState state)
    {
        if (state == GameState.Gameplay)
        {
            gameObject.SetActive(true);
        }
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (collisionHandler.IsColliding())
            {
                IDamageable comp = CollisionHandler.CurrentCollision.GetComponent<IDamageable>();
                comp.OnDamage();
                if (comp.GetHealth() == 0)
                {
                    audioManager.PlaySFX(true);
                    spawner.Spawn();
                    scoreManager.IncreaseScore();
                    scoreManager.IncreaseHighScore();
                }
                else
                {
                    audioManager.PlaySFX();
                }
            }
            else
            { 
                GameManager.Instance.UpdateGameState(GameState.GameOver);
                audioManager.PlaySFX(false);
            }
        }
    }
}
