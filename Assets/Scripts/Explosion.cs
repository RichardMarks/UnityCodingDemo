using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]
public class Explosion : MonoBehaviour
{
    public string damageTag = "Monster";
    public int damageValue = 100;

    private CircleCollider2D circle;
    private Sfx sfx;

    private void Awake()
    {
        circle = GetComponent<CircleCollider2D>();
        sfx = GetComponent<Sfx>();
    }

    private void Start()
    {
        sfx.Play();
    }

    public void Kaboom()
    {
        Collider2D[] potentials = Physics2D.OverlapCircleAll(transform.position, circle.radius);

        foreach (Collider2D potential in potentials)
        {
            if (potential.gameObject.CompareTag(damageTag))
            {
                Health health = potential.gameObject.GetComponent<Health>();
                if (health != null)
                {
                    health.Damage(damageValue);
                }
            }
        }
    }

    public void FinishExplosion()
    {
        Destroy(gameObject);
    }

    private void FixedUpdate()
    {

    }
}
