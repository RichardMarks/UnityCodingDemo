using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class BulletMovement : MonoBehaviour
{
    public float speed = 400.0f;

    private Rigidbody2D body;

    private float angleOfMovement = 0.0f;

    public void SetMovementAngle(float angleDegrees)
    {
        angleOfMovement = angleDegrees;
    }

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        float angle = 0.0f;
        Vector3 axis = Vector3.zero;

        transform.rotation.ToAngleAxis(out angle, out axis);
        angleOfMovement = angle * axis.z;
    }


    private void Update()
    {
        transform.rotation = Quaternion.AngleAxis(angleOfMovement, Vector3.forward);
    }

    private void FixedUpdate()
    {
        Vector2 force = Quaternion.Euler(0, 0, angleOfMovement) * Vector2.right * Time.fixedDeltaTime * speed;
        body.AddForce(force - body.velocity, ForceMode2D.Impulse);
    }
}
