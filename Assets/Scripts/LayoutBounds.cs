using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class LayoutBounds : MonoBehaviour
{
    private Vector3 minimum;
    public Vector3 Minimum
    {
        get
        {
            return minimum;
        }
        private set
        {
            minimum = value;
        }
    }

    private Vector3 maximum;
    public Vector3 Maximum
    {
        get
        {
            return maximum;
        }
        private set
        {
            maximum = value;
        }
    }

    public static LayoutBounds GetLayoutBounds()
    {
        GameObject layoutBoundsObject = GameObject.Find("LayoutBounds");

        if (layoutBoundsObject != null)
        {
            LayoutBounds layoutBounds = layoutBoundsObject.GetComponent<LayoutBounds>();
            if (layoutBounds != null)
            {
                return layoutBounds;
            }
            else
            {
                Debug.Log("Cannot find LayoutBounds behavior on GameObject with name of LayoutBounds");
                return null;
            }
        }

        Debug.Log("Cannot find GameObject with name of LayoutBounds");
        return null;
    }

    private BoxCollider2D boundingBox;

    private void Awake()
    {
        boundingBox = GetComponent<BoxCollider2D>();

        Minimum = boundingBox.bounds.min;
        Maximum = boundingBox.bounds.max;
    }
}
