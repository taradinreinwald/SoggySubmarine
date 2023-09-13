using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{

    [SerializeField] private Object[] _objects;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(_objects[Random.Range(0, _objects.Length)], this.transform);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
}