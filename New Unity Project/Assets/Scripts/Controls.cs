using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{   
    public Rigidbody rb;

    public float spd;

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, spd * Time.deltaTime);

       if (Input.GetKey("D"))
        {
            rb.AddForce(500 * Time.deltaTime, 0, 0);
        }
    }
}
