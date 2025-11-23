using UnityEngine;

public class Health : MonoBehaviour
{
    public float maxHealth = 100f;
    float current;

    void Start()
    {
        current = maxHealth;
    }

    public void TakeDamage(float amount)
    {
        current -= amount;

        if (current <= 0)
            Die();
    }

    void Die()
    {
        // disable object
        gameObject.SetActive(false);
    }
}
