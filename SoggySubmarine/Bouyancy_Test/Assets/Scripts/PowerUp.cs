using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Boat")
        {
            other?.GetComponent<UpAndDown>().GetArmour();
            AudioManager.Instance.PlayPickup();
            Destroy(gameObject);
        }

    }
}