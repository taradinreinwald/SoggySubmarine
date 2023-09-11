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
       if(_inWater == true)  //adds upwards force when in water. decreases drag as object floats up (need to tune)
        {
            _hull.AddRelativeForce((transform.up * UpwardForce), ForceMode2D.Force);
            _drag -= .05f;
            _hull.drag =_drag;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        _inWater = true;
        _drag = 5f; //drag of object when entering the water
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        _inWater = false;
        _drag = .05f; //default drag
        _hull.drag = _drag;
    }

    public bool GetWater()
    {
        return(_inWater);
    }
}
