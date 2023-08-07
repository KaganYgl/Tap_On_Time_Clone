using UnityEngine;

public class TapHandler : MonoBehaviour
{
    [SerializeField] private Spawner spawner;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (CollisionHandler.IsColliding())
            {
                Debug.Log("success");
                spawner.Spawn();
            }
            else
            {
                Debug.Log("Fail");
            }
        }
    }
}
