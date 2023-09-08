using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    // The time elapsed before invoking the Destroy function
    private float destroyTime = 3f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Destroys the obstacle after something collides with it + a delay of 3 seconds. We can change this later to require a tag check for the player object.
        Invoke("DestroyObstacle", destroyTime);
    }

    public void DestroyObstacle()
    {
        Destroy(gameObject);
    }



}
