using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class move_forward : MonoBehaviour
{
    public float moveSpeed = 5f; // Adjust this value to set the speed of movement.
    public float targetX = 40f; // The target X-coordinate.

    private bool isMoving = false;

    private void Update()
    {
        // Check if the sprite is currently moving.
        if (isMoving)
        {
            // Calculate the target position with the specified X-coordinate.
            Vector3 targetPosition = new Vector3(targetX, transform.position.y, transform.position.z);

            // Move the sprite towards the target position on the X-axis.
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

            // Check if the sprite has reached the target position.
            if (transform.position == targetPosition)
            {
                isMoving = false;
            }
        }
    }

    private void OnMouseDown()
    {
        // Set the flag to start moving the sprite.
        isMoving = true;
    }
}

