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
            transform.position += Vector3.right * spd * Time.deltaTime;
        }

        if (Input.GetKey("a"))
        {
            transform.position += Vector3.left * spd * Time.deltaTime;
        }

        if (Input.GetKey("w"))
        {
            transform.position += Vector3.up * spd * Time.deltaTime;
        }

        if (Input.GetKey("s"))
        {
            transform.position += Vector3.down * spd * Time.deltaTime;
        }
    }
}
