using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class storycode : MonoBehaviour
{


    public Text TheText;
    public enum States
    {
        start, wall, lightswitch, room, table, 
        LockedBox, bed, CutBed, door, outside,
        man, win, lose
    };
    public States mystate;
    private bool knife = false;
    private bool GoldKey = false;
    private bool BlackKey = false;
    private bool cloth = false;
    private bool cut = false;
    private bool kut = false;
    private bool slash = false;
    private bool stab = false;


    // Use this for initialization
    void Start()
    {
        mystate = States.start;
    }

    //check state 
    void Update()
    {
        if (mystate == States.start)
        {
            State_start();
        }

        else if (mystate == States.wall)
        {
            state_wall();
        }
        else if (mystate == States.lightswitch)
        {
            state_lightswitch();
        }
        else if (mystate == States.room)
        {
            state_room();
        }
        else if (mystate == States.table)
        {
            state_table();
        }       
        else if (mystate == States.LockedBox)
        {
            state_LockedBox();
        }
        
        else if (mystate == States.bed)
        {
             state_bed();
        }
        else if (mystate == States.CutBed)
        {
            state_CutBed();
        }
        
        else if (mystate == States.door)
        {
            state_door();
        }
        else if (mystate == States.outside)
        {
            state_outside();
        }
        else if (mystate == States.man)
        {
            state_man();
        }
       
        else if (mystate == States.win)
        {
            state_win();
        }        
        else if (mystate == States.lose)
        {
            state_lose();
        }
    }

    void State_start()
    {

        TheText.text = "You are in a Dark Room" +
            "\nyou walk forward and run into a Wall" +
            "\n\n press W to search the Wall";
        if (Input.GetKeyDown(KeyCode.W))
        {
            mystate = States.wall;
        }

    }

    void state_wall()
    {
        TheText.text = "wall" + "\n press L for light switch";
        if (Input.GetKeyDown(KeyCode.L))
        {
            mystate = States.lightswitch;
        }

    }

    void state_lightswitch()
    {
        TheText.text = "lightswitch" + " \n press R for room";
        if (Input.GetKeyDown(KeyCode.R))
        {
            mystate = States.room;
        }

    }

    void state_room()
    { if (cut == true)
        {
        TheText.text = "room" + "\n press T for table" +
           "\n press D for door" +
           "\n press C for bed";
        }
        TheText.text = "room" + "\n press T for table" +
            "\n press D for door" +
            "\n press B for bed";
        if (Input.GetKeyDown(KeyCode.T))
        {
            mystate = States.table;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            mystate = States.door;
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            mystate = States.bed;
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            mystate = States.CutBed;
        }
    }

    void state_table()
    {
        if (knife == true)
        {
            TheText.text = "table" + " \n press R for room" +
           "\n press L for Lock Box" +
           "\n you have the knife" 
           ;
        }
        else
        {
            TheText.text = "table" + " \n press R for room" +
            "\n press L for Lock Box" +
            "\n press K for Knife";
        }
        
        if (Input.GetKeyDown(KeyCode.R))
        {
            mystate = States.room;
        }
        else if (Input.GetKeyDown(KeyCode.K))
        {
            knife = true;           
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            mystate = States.LockedBox;
        }


    }

    void state_LockedBox()
    { if (GoldKey == true)
        {
            TheText.text = "Locked Box" +
                "\nyou got a gold key" +
                "\nthe box is opened and nothing is left inside" + " \n press R for room" 
           ;
        }
        else if (BlackKey == true)
        {
            TheText.text = "Locked Box" + " \n press R for room" +
           "\n press O to open";
        }
        else {
            TheText.text = "Locked Box" +
                "\nthe box is locked, you need a key" + " \n press R for room"
           ;
        }

        
        if (Input.GetKeyDown(KeyCode.R))
        {
            mystate = States.room;
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            GoldKey = true;
        }
    }
  
    

    void state_bed()
    {
        if (cut == true)
        {
            mystate = States.CutBed;
        }
        else if (knife == true)
        {
            TheText.text = "Bed" + " \n press R for room" +
            "\n press C to cut the bed with the knife";
        }
        else
        {
            TheText.text = "Bed" + " \n press R for room" 
            ;
        }
        
        if (Input.GetKeyDown(KeyCode.R))
        {
            mystate = States.room;
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            cut = true;
        }
    }

    void state_CutBed()
    { if (kut == true)
        {
            TheText.text = "Cut bed" +
                "\nyou got come cloth" +
             " \n press R for room" 
           ;
        }
    else if (slash == true)
        {
            TheText.text = "Cut bed" 
                + " \n press R for room" +
               "\n press K to cut of cloth";
        }
    else if ( stab == true)
        {
            TheText.text = "Cut bed" +
                 " \n press R for room" +
               "\n press C to slash the bed";

        }
    else
        {
         TheText.text = "Cut bed" +
            "\nyou found a black key, this might be usefull" + " \n press R for room" +
            "\n press S to Stab the bed";
        }

       

        BlackKey = true; 
        
        if (Input.GetKeyDown(KeyCode.R))
        {
            mystate = States.room;
        }
        else if (Input.GetKeyDown(KeyCode.K))
        {
            cloth = true;
            kut = true;
            slash = false;
            stab = false;
            cloth = true;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            stab = true;
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            slash = true;
        }
       
    }


    void state_door()
    { if (GoldKey == true)
        {
            TheText.text = "Door" + " \n press R for room" +
            "\n press U to unlock and leave";
        }
    else
        {
            TheText.text = "Door" +
                "\nthe door is locked" + " \n press R for room";            
        }
        
        if (Input.GetKeyDown(KeyCode.R))
        {
            mystate = States.room;
        }
        else if (Input.GetKeyDown(KeyCode.U))
        {
            mystate = States.outside;
        }

    }

    void state_outside()
    {
        TheText.text = "outside" + " \n press M to aproch man";
        if (Input.GetKeyDown(KeyCode.M))
        {
            mystate = States.man;
        }

    }

    void state_man()
    {
        if (cloth == true)
        {
            TheText.text = "Man" + " \n press W to wave cloth" +
            "\n press K to pull knife";
        }
        else
        {
            TheText.text = "Man" +
               "\n press K to pull knife";

        }       
       
        
        if (Input.GetKeyDown(KeyCode.W))
        {
            mystate = States.win;
        }
        else if (Input.GetKeyDown(KeyCode.K))
        {
            mystate = States.lose;
        }

    }

    void state_win()
    {
        TheText.text = "win" + " \n the man is friendly and takes you to safty";
        if (Input.GetKeyDown(KeyCode.R))
        {
            mystate = States.start;
        }

    }

    void state_lose()
    {
        TheText.text = "lose" + " \n the man pulls a gun and shoots you" +
            "press R to restart";
        if (Input.GetKeyDown(KeyCode.R))
        {
            mystate = States.start;
        }

    }

    
}
