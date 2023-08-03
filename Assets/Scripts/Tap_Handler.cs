using UnityEngine;

public class Tap_Handler : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (Collision_Handler.IsColliding())
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
