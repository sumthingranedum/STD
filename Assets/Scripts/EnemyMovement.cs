using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    // Public Variables
    public WaypointSystem waypointSystem;
    public float movementSpeed = 5f;

    // Private Variables
    private int currentWaypointIndex = 0; //Which waypoint object is moving towards

    // Update is called once per frame
    private void Update()
    {
        if (currentWaypointIndex >= waypointSystem.waypoints.Count)
        {
            // Reached the end of the path
            Destroy(gameObject);
            return;
        }

        // Get the position of the current waypoint
        Vector2 targetPosition = waypointSystem.waypoints[currentWaypointIndex];

        // Move towards the current waypoint
        transform.position = Vector2.MoveTowards(transform.position, targetPosition, movementSpeed * Time.deltaTime);

        // Check if the enemy has reached the current waypoint
        if (Vector2.Distance(transform.position, targetPosition) < 0.01f)
        {
            // Move to the next waypoint
            currentWaypointIndex++;
        }
    }
}
