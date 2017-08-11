using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveThePlayer : MonoBehaviour {

    public float speed;

    private Rigidbody rb;

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate ()
    {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");

        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

        rb.AddForce (movement * speed);

        if (Input.GetKeyDown("space"))
        {
            Vector3 movement2 = new Vector3(moveHorizontal, 120.0f, 0f); 
            rb.AddForce(movement2 * speed);
        }
        else
        {
            movement = new Vector3(moveHorizontal, 0f, 0f);
            rb.AddForce(movement * speed);
        }
    }
}
