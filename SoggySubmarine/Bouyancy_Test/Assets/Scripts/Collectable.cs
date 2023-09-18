using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Collectable : MonoBehaviour
{
    [SerializeField] int _pointValue = 1;
    public UnityEvent<int, Collectable> collected;
    private GameManager gameManager;
    private void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Boat")
        {
            gameManager.IncreaseScore(_pointValue);
            Destroy(gameObject);
        }
        
    }

}
