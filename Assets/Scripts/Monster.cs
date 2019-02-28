using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public GenericStats stats;

    private HealthKeeper healthKeeper;

    private void Awake()
    {
        stats = new GenericStats(Random.Range(1, 3), Random.Range(1, 3));

        healthKeeper = (HealthKeeper)FindObjectOfType<HealthKeeper>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Health playerHealth = collision.gameObject.GetComponent<Health>();
            Sfx playerHurtSfx = collision.gameObject.GetComponent<Sfx>();
            playerHurtSfx.Play();
            playerHealth.Damage(stats.attack);
            healthKeeper.UpdateText();
        }
    }
}
