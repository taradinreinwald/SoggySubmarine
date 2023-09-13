using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpAndDown : MonoBehaviour
{
    private Rigidbody2D _body;
    [SerializeField] float _downForce = 22.53f;
    [SerializeField] private Floaty _bouyancy;
    [SerializeField] private float _angle;
    

    void Start()
    {
        _body = GetComponent<Rigidbody2D>();

    }

    void FixedUpdate()
    {
        HoldDown();

        //angle boat. angle front towards vector. issues: no forward vector so would need to do math with a fake forward vector to calculate angle. 
        //AngleShip();
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

    void AngleShip()
    {
        _angle = (Vector2.Angle(new Vector2 (0,_body.velocity.y) , new Vector2(1, 0))) ;
        //this.transform.Rotate(0,0, _angle);
        transform.LookAt(transform.position + new Vector3(0,0,_angle));
        
        Debug.Log(_angle/50);
        
    }
}
