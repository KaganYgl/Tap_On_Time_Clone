using UnityEngine;

public class Hard : MonoBehaviour, IDamageable
{
    private int health;
    [SerializeField] Sprite damaged;
    [SerializeField] Sprite normal;

    private void OnEnable()
    {
        health = 2;
        gameObject.GetComponent<SpriteRenderer>().sprite = normal;
    }

    public void OnDamage()
    {
        health--;
        gameObject.GetComponent<SpriteRenderer>().sprite = damaged;
    }

    public int GetHealth()
    {
        return health;
    }
}
