using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{
    private Weapon weapon;

    private Sfx sfx;

    private void Awake()
    {
        weapon = GetComponent<Weapon>();

        sfx = GetComponent<Sfx>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire"))
        {
            weapon.Fire(transform.parent.position, transform.parent.rotation);
            sfx.Play();
        }
    }
}
