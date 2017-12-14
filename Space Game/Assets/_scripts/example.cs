using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class example : MonoBehaviour {
    //functions with paramiters
	// Use this for initialization
	void Start () {
        AdderUpper(10, 20);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void AdderUpper(int value1, int value2)
    {
        print(value1 + value2);
    }
}
