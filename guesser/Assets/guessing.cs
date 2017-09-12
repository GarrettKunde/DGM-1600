using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guessing : MonoBehaviour {

       private int max = 100;
       private int min = 1;
       private int guess;

       public int counter;

	// Use this for initialization
	void Start () {

        guess = Random.Range(max, min);
        print("Welcome to Number Guesser");
        print("Pick a number in your head");

        print("The highest number you can pick is " + max);
        print("The lowest number you can pick is " + min);
         
        print("Is the number higher or lower than " + guess + "?");
        print("Up arrow for higher, down arrow for lower, equal for equal");

        max = max + 1;
	}
	
	// Update is called once per frame
	void Update () {

        if (counter == -1)
        {                     
            if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.UpArrow))
            {
                counter = -1;
                print("You win");
            }
        }
       else  if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            guess = (max + min) / 2;
            print("Is the number higher or lower than " + guess + "?");
            counter--;

        } 
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            guess = (max + min) / 2;
            print("Is the number higher or lower than " + guess + "?");
            counter--;
        } 
         if (Input.GetKeyDown(KeyCode.Return))
        {
            print("You lose");
        }
        
            if (counter == 0)
        {          
            counter = -1;                                  
        }

        
                    }
	
}
