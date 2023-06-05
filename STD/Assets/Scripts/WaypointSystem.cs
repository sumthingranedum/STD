using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointSystem : MonoBehaviour
{
    public List<Vector2> waypoints = new List<Vector2>();

    private void Awake()
    {
        // Store the positions of each child waypoint GameObject
        for (int i = 0; i < transform.childCount; i++)
        {
            Transform waypoint = transform.GetChild(i);
            waypoints.Add(waypoint.position);
        }
    }
}
