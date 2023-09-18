using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodingObstacle : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "Boat")
        {
            other?.GetComponent<UpAndDown>().Die();
        }
        Debug.Log("EXPLOSION!");
    }
}
