using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouce_Ball : MonoBehaviour {

    float x;
    float y;
    float z;
    Vector3 pos;
    Transform trans;
	// Use this for initialization
	void Start () {
        trans = GetComponent<Transform>();

	}
	
	// Update is called once per frame
	void Update () {
        bouneBall();
	}

    void bouneBall(){

        x = Random.Range(-25, 26);
        y = 5;
        z = Random.Range(-25, 26);

        iTween.MoveBy(gameObject, iTween.Hash(

            "z", z,
            "time", 0.1f,
            "transition", iTween.EaseType.easeInBack
        ));

    }
}
