using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeekPlayerWhenOutsideLayout : MonoBehaviour
{
    public LayoutBounds layoutBounds;

    private BulletMovement bulletMovement;

    private void Awake()
    {
        layoutBounds = LayoutBounds.GetLayoutBounds();
        bulletMovement = GetComponent<BulletMovement>();
    }

    private void LateUpdate()
    {
        if (
            transform.position.x < layoutBounds.Minimum.x ||
            transform.position.x > layoutBounds.Maximum.x ||
            transform.position.y < layoutBounds.Minimum.y ||
            transform.position.y > layoutBounds.Maximum.y)
        {
            GameObject playerObject = GameObject.FindWithTag("Player");
            Vector3 playerPosition = playerObject.transform.position;

            float angle = Mathf.Atan2(playerPosition.y - transform.position.y, playerPosition.x - transform.position.x) * Mathf.Rad2Deg;
            bulletMovement.SetMovementAngle(angle);
        }
    }
}
