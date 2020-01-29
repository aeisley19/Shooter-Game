using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroidMove : MonoBehaviour
{

    public float speed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
       Collider2D coll = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()

    {
        Debug.Log(Camera.main.pixelHeight);
        transform.position += Vector3.down * speed * Time.deltaTime;

        if (transform.position.y < -Camera.main.orthographicSize - gameObject.transform.localScale.y)
        {
            Destroy (gameObject);
        }
    }
}
