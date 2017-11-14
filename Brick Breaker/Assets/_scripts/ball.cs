using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour {

    public GameObject paddle;

    private Vector3 paddleToBallVector; //distance from ball to paddle 
    private Rigidbody2D rigid;
    private bool playing = false;
	
	void Start () {
      paddleToBallVector = this.transform.position - paddle.transform.position;
        rigid = this.GetComponent<Rigidbody2D>();
       
	}
	
	
	void Update () {
        if (!playing)
        {
            this.transform.position = paddle.transform.position + paddleToBallVector;
        if (Input.GetKeyDown(KeyCode.Space))
                {
                    rigid.velocity = new Vector2 (4, 20);
                    playing = true;
            
                }
        }
        
               
   	}
}
