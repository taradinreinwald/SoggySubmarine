using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floaty : MonoBehaviour
{
    Collider2D Detector;
    private Rigidbody2D _hull;
    protected bool _inWater = false;

    [SerializeField] float UpwardForce = 12.72f; 
    [SerializeField] float _drag = 5f;

    void Start()
    {
        Detector = GetComponent<Collider2D>();
        _hull = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       if(_inWater == true && Input.GetKey(KeyCode.Space) ==  false)  //adds upwards force when in water. decreases drag as object floats up (need to tune)
        {
            _hull.AddRelativeForce((new Vector2(0,1) * UpwardForce), ForceMode2D.Force);
            _drag -= .07f;
            _hull.drag =_drag;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 4) //4 is the water layer
        {
            _inWater = true;
            _drag = 5f; //drag of object when entering the water
        }
        
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 4)
        {
            _inWater = false;
            _drag = .05f; //default drag
            _hull.drag = _drag;
        }
        
    }

    public bool GetWater()
    {
        return(_inWater);
    }
}
