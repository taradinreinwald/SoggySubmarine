using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpAndDown : MonoBehaviour
{
    private Rigidbody2D _body;
    [SerializeField] float _downForce = 22.53f;
    [SerializeField] private Floaty _bouyancy;
    

    void Start()
    {
        _body = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        HoldDown();
    }

    void HoldDown()
    {
        // While holding down the spacebar...
        if (Input.GetKey(KeyCode.Space))
        {
            if (_bouyancy.GetWater() == true) //makes sure boat is in water before sinking
            {
                // ... move the boat down.
            _body.AddForce((new Vector3(0, -1, 0) * _downForce), ForceMode2D.Force);
            }
           
        }
    }
}
