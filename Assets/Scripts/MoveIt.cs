using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveIt : MonoBehaviour {
    float move = 0f;

	// Use this for initialization
	void Start () {
		
      
	}
	
	// Update is called once per frame
	void Update () {
		
        if(Input.GetKey(KeyCode.RightArrow)){
            movePlayerRight();
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
                movePlayerLeft();
        }
	}

    void movePlayerRight(){
        if (move < 16f)
        {
            
            iTween.MoveTo(gameObject, iTween.Hash(
                    "x", move++,
                    "time", 1f
                    
                )); 
            //moveLeft++;
            Debug.Log(move);
        }
      

    }

    void movePlayerLeft(){
        if (move != -16f)
        {
           
            iTween.MoveTo(gameObject, iTween.Hash(
                    "x", move--,
                    "time", 1f

                )); 
            //moveLeft++;
            Debug.Log(move);
        }
      


    }

   
       
}
