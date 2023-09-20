using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCollection : MonoBehaviour
{
    [SerializeField] private float speed = -5f;
   

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(speed, 0,0) * Time.deltaTime;
    }

    public void Stop()
    {
        speed = 0;
    }
}
