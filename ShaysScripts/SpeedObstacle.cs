using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedObstacle : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("This obstacle increases your speed.");
    }
}
