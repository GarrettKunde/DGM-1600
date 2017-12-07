using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HighScore : MonoBehaviour {

    public Text highScore;
    public Text score;

    private void Update()
    {
        int number = 0 ;
        score.text = number.ToString();
    }
}
