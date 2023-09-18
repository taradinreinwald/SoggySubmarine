using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UpAndDown : MonoBehaviour
{
    private Rigidbody2D _body;
    [SerializeField] float _downForce = 12.72f;
    [SerializeField] float _downForceCap = 22.55f;
    [SerializeField] private Floaty _bouyancy;
    [SerializeField] private float _angle;
    [SerializeField] private Animator animator;

    void Start()
    {
        _body = GetComponent<Rigidbody2D>();
        if(animator == null)
        {
            animator = GetComponentInChildren<Animator>();
        }
        animator.SetBool("Dead", false);

    }

    void FixedUpdate()
    {
        HoldDown();

        //angle boat. angle front towards vector. issues: no forward vector so would need to do math with a fake forward vector to calculate angle. 
        AngleShip();

        
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
                if(_downForce < _downForceCap)
                {
                    _downForce += .05f;
                }
            }
           
        }
    }

    void AngleShip()
    {
        _angle = (Mathf.Pow(_body.velocity.y, 2f) + 1);
        _angle = _body.velocity.y > 0 ? _angle : -_angle;
        if(_angle < -25f)
        {
            _angle = -25f;
        }
        transform.eulerAngles = new Vector3(0, 0, _angle);// = _angle;
       // transform.Rotate(0, 0, _angle);
        
        
    }
    public void Die()
    {
        animator.SetBool("Dead",true);
    }
}
