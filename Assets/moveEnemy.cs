using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveEnemy : MonoBehaviour {
    public GameObject enemy;
    private float moveX = -1f;
    private Vector3 move;
    private float x;
    private Transform t ;
	// Use this for initialization
	void Start () {
        t = GetComponent<Transform>();

	}
	
	// Update is called once per frame
	void Update () {
        
        Vector3 moveTo = new Vector3(moveX, 0f, 0f);
        t.position = Vector3.right * moveX;
	}
}
