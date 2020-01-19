using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{   
    public Rigidbody2D rb;

    public float spd;


    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        Movement();

 
    }

    void Movement ()
    {
        if (Input.GetKey("d"))
        {
            rb.AddForce(transform.right * spd);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-transform.right * spd);
        }

        if (Input.GetKey("w"))
        {
            rb.AddForce(transform.up);
        }

        if (Input.GetKey("s"))
        {
            rb.AddForce(-transform.up * spd);
        }
    }
}
