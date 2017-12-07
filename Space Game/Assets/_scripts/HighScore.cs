using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HighScore : MonoBehaviour {

    public Text highScoreDisplay;
    public Text scoreDispaly;
    public int number;

    private void Start()
    {
        number = 0;
        if (scoreDispaly != null)
        {
            scoreDispaly.text = number.ToString();
        }
        if (highScoreDisplay != null)
            highScoreDisplay.text = GetScore().ToString();

        
    }


    public void ScoreBoard(int value)
    {
        number += value;
        scoreDispaly.text = number.ToString();
    }

    public void SaveScore()
    {
        PlayerPrefs.SetInt("Highscore", number);

    }
    public int GetScore()
    {
        return PlayerPrefs.GetInt("Highscore");
    }

    public void OnDisable()
    {
        SaveScore();
              
    }



}
