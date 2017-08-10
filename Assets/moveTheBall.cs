using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveTheBall : MonoBehaviour {

    private Rigidbody b;
    private Vector3 movement;
    [HideInInspector] public float speed = 4.0f;
    // Use this for initialization
    void Start () {

        b = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate () {

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");


        if (Input.GetKeyDown("space"))
        {
            Vector3 movement2 = new Vector3(horizontal, 120.0f, 0f); 
            b.AddForce(movement2 * speed);
        }
        else
        {
            movement = new Vector3(horizontal, 0f, 0f);
            b.AddForce(movement * speed);
        }


    }
}