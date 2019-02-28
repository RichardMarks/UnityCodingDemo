using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class EightDirectionMovement : MonoBehaviour
{
    // speed in pixels per second the object travels at
    public float speed = 200.0f;

    [Range(0.0f, 0.3f)] public float smoothing = 0.05f;

    private float horizontalInput = 0.0f;
    private float verticalInput = 0.0f;

    private Vector3 velocity = Vector3.zero;

    private Rigidbody2D body;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

        Vector2 moveDirection = body.velocity;

        if (moveDirection != Vector2.zero)
        {
            float angle = Mathf.Atan2(moveDirection.y, moveDirection.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
    }

    private void FixedUpdate()
    {
        float xMotion = speed * horizontalInput * Time.fixedDeltaTime;
        float yMotion = speed * verticalInput * Time.fixedDeltaTime;

        Vector3 targetVelocity = new Vector3(xMotion, yMotion, 0.0f);

        body.velocity = Vector3.SmoothDamp(body.velocity, targetVelocity, ref velocity, smoothing);
    }
}
