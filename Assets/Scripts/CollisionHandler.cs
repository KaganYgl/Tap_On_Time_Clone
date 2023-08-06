using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    private static bool CollisionState = false;

    public static bool IsColliding()
    {
        return CollisionState;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        CollisionState = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        CollisionState = false;
    }
}
