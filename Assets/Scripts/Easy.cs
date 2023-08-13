using UnityEngine;

public class Easy : MonoBehaviour, IDamageable
{
    private int health;

    private void OnEnable()
    {
        health = 1;
    }

    public void OnDamage()
    {
        health--;
    }

    public int GetHealth()
    {
        return health;
    }
}
