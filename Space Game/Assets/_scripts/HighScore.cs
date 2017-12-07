using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HighScore : MonoBehaviour {

    public Text highScore;
    public Text score;
    public int number;

    private void Start()
    {
        score.text = number.ToString();
    }


    public void scoreBoard()
    {
        
        score.text = number.ToString();
    }
}
