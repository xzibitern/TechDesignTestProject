using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class bird_cycled_fly : MonoBehaviour
{
    public float moveSpeed = 5f; // Adjust this value to set the speed of movement.
    public float startX = -15f; // The starting X-coordinate.
    public float endX = 45f;    // The ending X-coordinate.
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        StartCoroutine(MoveBird());
    }

    private IEnumerator MoveBird()
    {
        float currentX = startX;
        int direction = 1; // 1 for moving right, -1 for moving left.

        while (true) // This creates an infinite loop for cyclic movement.
        {
            // Move the bird towards the target X-coordinate.
            currentX = Mathf.MoveTowards(currentX, endX * direction, moveSpeed * Time.deltaTime);
            transform.position = new Vector3(currentX, transform.position.y, transform.position.z);

            // Check if the bird has reached the target position.
            if ((direction == 1 && currentX >= endX) || (direction == -1 && currentX <= startX))
            {
                // Mirror the sprite when changing direction.
                FlipSprite();
                direction *= -1;
            }

            yield return null;
        }
    }

    private void FlipSprite()
    {
        // Flip the bird's sprite by changing its local scale.
        Vector3 newScale = transform.localScale;
        newScale.x *= -1;
        transform.localScale = newScale;
    }
}