using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Collectable : MonoBehaviour
{
    [SerializeField] int _pointValue = 1;
   
    private GameManager gameManager;
    private void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Boat")
        {
            GameManager.Instance.IncreaseScore(_pointValue);
            Destroy(gameObject);
        }
        
    }

}
