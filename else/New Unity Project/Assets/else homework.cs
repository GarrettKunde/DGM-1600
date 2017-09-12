using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elsehomework : MonoBehaviour {

	// Use this for initialization
	void Start () {
        print("this is about else clauses");
        print("press enter to continue");
	}
	
	// Update is called once per frame
	void Update() {

        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                print("if your if caluse doesnt work,");
            }
            else if (Input.GetKeyUp(KeyCode.Return))
            {
                print("it will use your else clause. press the up arrow to continue.");
            }
        }
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                print("An if clause will run when the requirements are met, ");
            }
            else if (Input.GetKeyUp(KeyCode.UpArrow))
            {
                print("but if they arent then the else clause will be used instead.");
            }
        }
	}
}
