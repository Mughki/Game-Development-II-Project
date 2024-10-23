using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathGuide : MonoBehaviour
{
    private int currentChildIndex = 0;

    public Vector3 NextWayPoint
    {
        get
        {
            var waypoint = transform.GetChild(currentChildIndex);
            currentChildIndex = (currentChildIndex + 1) % transform.childCount;
            return waypoint.transform.position;
        }
    }
}
