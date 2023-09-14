using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Collectable : MonoBehaviour
{
    [SerializeField] int _pointValue = 1;
    public UnityEvent<int, Collectable> collected;
    private void Awake()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collected.Invoke(_pointValue,this);
        Destroy(gameObject);
    }

}
