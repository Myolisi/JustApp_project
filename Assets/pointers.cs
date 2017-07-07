using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointers : MonoBehaviour {

    private Rigidbody rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
    void OnTriggerEnter (Collider other) {
        if (other.gameObject.CompareTag("trap"))
        {
            other.gameObject.SetActive(false);
        }
	}
}
