using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class guessing : MonoBehaviour {

    public Text Textbox;

       private int max = 100;
       private int min = 1;
       private int guess;

       public int counter;

	// Use this for initialization
	void Start () {

        guess = Random.Range(max, min);

        Textbox.text = "Welcome to Number Guesser! "
                + "\n Pick a number in your head."
                + "\n \n The highest number you can pick is " + max + ",\n the lowest you can pick is " + min + "."
                + "\n\n Once you have picked your number press the space bar.";
       

        max = max + 1;
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Space)) 
        {       Textbox.text = "Is the number higher or lower than " + guess + "?"
                + "\n press the up arrow for higher, down arrow for lower, and enter for equal";
        }

        if (counter == -1)
        {                     
            if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.UpArrow))
            {
                counter = -1;
                Textbox.text = "You Win!";
                print("You win");
            }
        }
       else  if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            guess = (max + min) / 2;
            Textbox.text = "Is the number higher or lower than " + guess + "?";
            print("Is the number higher or lower than " + guess + "?");
            counter--;

        } 
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            guess = (max + min) / 2;
            Textbox.text = "Is the number higher or lower than " + guess + "?";
            print("Is the number higher or lower than " + guess + "?");
            counter--;
        } 
         if (Input.GetKeyDown(KeyCode.Return))
        {
            Textbox.text = "You lose";
           print("You lose");
        }
        
            if (counter == 0)
        {          
            counter = -1;                                  
        }

        
                    }
	
}
