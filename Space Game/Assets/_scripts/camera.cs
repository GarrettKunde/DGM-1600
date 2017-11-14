using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour {

    public Transform objectToFollow;
    float zOffset = -20;
	
	void Update () {
        Vector3 myPos = objectToFollow.position;
       
        myPos.z = zOffset;
        gameObject.transform.position = myPos;
        
	}
}
