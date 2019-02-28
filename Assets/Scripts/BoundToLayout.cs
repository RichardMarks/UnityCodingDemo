using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundToLayout : MonoBehaviour
{
    public LayoutBounds layoutBounds;

    private Collider2D targetCollider;

    private float halfWidth;
    private float halfHeight;

    private void Awake()
    {
        layoutBounds = LayoutBounds.GetLayoutBounds();
        targetCollider = GetComponent<BoxCollider2D>();
        if (targetCollider == null)
        {
            targetCollider = GetComponent<CircleCollider2D>();
        }

        halfWidth = (targetCollider.bounds.max.x - targetCollider.bounds.min.x) * 0.5f;
        halfHeight = (targetCollider.bounds.max.y - targetCollider.bounds.min.y) * 0.5f;
    }

    private void LateUpdate()
    {
        Vector3 position = transform.position;

        position.x = Mathf.Clamp(position.x, layoutBounds.Minimum.x + halfWidth, layoutBounds.Maximum.x - halfWidth);
        position.y = Mathf.Clamp(position.y, layoutBounds.Minimum.y + halfHeight, layoutBounds.Maximum.y - halfHeight);

        transform.position = position;
    }
}
