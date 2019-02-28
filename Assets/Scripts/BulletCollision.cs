using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CapsuleCollider2D))]
public class BulletCollision : MonoBehaviour
{
    public GameObject explosionPrefab;
    public string damageTag = "Monster";

    private CapsuleCollider2D capsule;

    private void Awake()
    {
        capsule = GetComponent<CapsuleCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(damageTag))
        {
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
