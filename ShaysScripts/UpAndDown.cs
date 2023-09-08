using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpAndDown : MonoBehaviour
{
    private Rigidbody2D body;


    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        HoldDown();
    }

    void HoldDown()
    {
        // While holding down the spacebar...
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // ... move the boat down.
            body.AddForce((new Vector3(0, -1, 0) * 22.53f), ForceMode2D.Force);
        }
    }
}
