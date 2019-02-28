using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int currentHealth = 100;
    public int maximumHealth = 100;
    public bool destroyWhenZero = true;

    public void Upgrade(int amount, bool replenishHealth)
    {
        maximumHealth += amount;
        if (replenishHealth)
        {
            currentHealth = maximumHealth;
        }
    }

    public void Restore(int amount)
    {
        currentHealth += amount;
        currentHealth = currentHealth > maximumHealth ? maximumHealth : currentHealth;
    }

    public void Damage(int amount)
    {
        currentHealth -= amount;
        currentHealth = currentHealth < 0 ? 0 : currentHealth;
    }

    private void LateUpdate()
    {
        if (destroyWhenZero && currentHealth == 0)
        {
            Destroy(gameObject);
        }
    }
}
