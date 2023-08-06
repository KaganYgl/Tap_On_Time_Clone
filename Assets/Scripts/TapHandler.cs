using UnityEngine;

public class TapHandler : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (CollisionHandler.IsColliding())
            {
                Debug.Log("success");
            }
            else
            {
                Debug.Log("Fail");
            }
        }
    }
}
