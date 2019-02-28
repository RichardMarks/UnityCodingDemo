using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollTo : MonoBehaviour
{
    public LayoutBounds layoutBounds;
    public bool unboundedScrolling = false;

    public float speed = 2.0f;

    private Camera cam;
    private float halfWidth;
    private float halfHeight;

    private void Awake()
    {
        layoutBounds = LayoutBounds.GetLayoutBounds();

        cam = Camera.main;
        halfHeight = cam.orthographicSize;
        halfWidth = halfHeight * Screen.width / Screen.height;
    }

    private void Update()
    {
        float movement = speed * Time.deltaTime;

        Vector3 position = cam.transform.position;

        position.x = Mathf.Lerp(cam.transform.position.x, transform.position.x, movement);
        position.y = Mathf.Lerp(cam.transform.position.y, transform.position.y, movement);

        if (!unboundedScrolling)
        {
            position.x = Mathf.Clamp(position.x, layoutBounds.Minimum.x + halfWidth, layoutBounds.Maximum.x - halfWidth);
            position.y = Mathf.Clamp(position.y, layoutBounds.Minimum.y + halfHeight, layoutBounds.Maximum.y - halfHeight);
        }

        cam.transform.position = position;
    }

}
