using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject bulletPrefab;

    public void Fire(Vector3 origin, Quaternion rotation)
    {
        GameObject bullet = Instantiate(bulletPrefab, origin, rotation);
        BulletMovement bulletMovement = bullet.GetComponent<BulletMovement>();

        float angle = 0.0f;
        Vector3 axis = Vector3.zero;

        rotation.ToAngleAxis(out angle, out axis);

        bulletMovement.SetMovementAngle(angle * axis.z);

    }
}
