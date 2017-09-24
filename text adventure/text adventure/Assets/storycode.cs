using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class storycode : MonoBehaviour {


    public Text TheText ;  
    public enum States {start, wall, lightswitch,   };
    public States mystate;

	// Use this for initialization
	void Start () {
        mystate = States.start;	
	}
	
	void Update () {
        if (mystate == States.start)
        {
            State_start();
      
        }
         
        else if (mystate == States.wall)
        {
            state_wall();
        }
	}

    void State_start()
    {

        TheText.text = "You are in a Dark Room" +
            "\nall you can feel is the Wall" +
            "\n\n presa W to search the Wall";
        if (Input.GetKeyDown(KeyCode.W))
        {
            mystate = States.wall;
        }
    
    }

    void state_wall()
    {
        TheText.text = "wall";
    }

}
