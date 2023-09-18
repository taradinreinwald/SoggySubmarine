using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{

    [SerializeField] private Object[] _objects;
    [SerializeField] private float _sec = 3f;
    // Start is called before the first frame update
    IEnumerator Start()
    {
       while(true)
        {
            yield return new WaitForSeconds(_sec);
            Spawn();
        }
    }

    
    void Spawn()
    {
        Instantiate(_objects[Random.Range(0, _objects.Length)], this.transform);
    }
}