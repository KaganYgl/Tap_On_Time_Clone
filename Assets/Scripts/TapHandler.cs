using UnityEngine;

public class TapHandler : MonoBehaviour
{
    [SerializeField] private Spawner spawner;
    [SerializeField] private ScoreManager scoreManager;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (CollisionHandler.IsColliding())
            {
                Debug.Log("success");
                scoreManager.IncreaseScore();
                scoreManager.IncreaseHighScore();
                spawner.Spawn();
            }
            else
            {
                Debug.Log("Fail");
            }
        }
    }
}
