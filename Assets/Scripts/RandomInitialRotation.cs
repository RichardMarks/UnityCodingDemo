using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomInitialRotation : MonoBehaviour
{
    void Start()
    {
        float angle = Random.Range(0, 360);
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}
