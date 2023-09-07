using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floaty : MonoBehaviour
{
    Collider2D Detector;
    private Rigidbody2D _hull;
    private bool _inWater = false;

    void Start()
    {
        Detector = GetComponent<Collider2D>();
        _hull = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       if(_inWater == true)
        {
            _hull.AddForce((transform.up * 12.72f), ForceMode2D.Force);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
      
        _inWater = true;
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        
        _inWater = false;
    }
}
