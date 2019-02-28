using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeekPlayerWhenInLineOfSight : MonoBehaviour
{
    private BulletMovement bulletMovement;

    private void Awake()
    {
        bulletMovement = transform.parent.GetComponent<BulletMovement>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Vector3 playerPosition = collision.gameObject.transform.position;

            float angle = Mathf.Atan2(playerPosition.y - transform.position.y, playerPosition.x - transform.position.x) * Mathf.Rad2Deg;
            bulletMovement.SetMovementAngle(angle);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Vector3 playerPosition = collision.gameObject.transform.position;

            float angle = Mathf.Atan2(playerPosition.y - transform.position.y, playerPosition.x - transform.position.x) * Mathf.Rad2Deg;
            bulletMovement.SetMovementAngle(angle);
        }
    }
}
