using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject missile;
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

    //Controls player movement using transform.position.
    void Movement ()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * spd * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * spd * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.up * spd * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.down * spd * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(missile, transform.position, transform.rotation);
        }
    }
}
