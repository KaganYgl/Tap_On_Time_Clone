using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    private bool collisionState = false;

    public static Collider2D CurrentCollision;
    
    public bool IsColliding()
    {
        return collisionState;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        CurrentCollision = collision;
        collisionState = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        collisionState = false;
        CurrentCollision = null;
    }
}

