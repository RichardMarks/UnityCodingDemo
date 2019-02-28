using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutsideLayout : MonoBehaviour
{
    public LayoutBounds layoutBounds;

    private void Awake()
    {
        layoutBounds = LayoutBounds.GetLayoutBounds();
    }

    private void LateUpdate()
    {
        if (
            transform.position.x < layoutBounds.Minimum.x ||
            transform.position.x > layoutBounds.Maximum.x ||
            transform.position.y < layoutBounds.Minimum.y ||
            transform.position.y > layoutBounds.Maximum.y)
        {
            Destroy(gameObject);
        }
    }
}
