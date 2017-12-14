using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HighScore : MonoBehaviour {

    public Text highScoreDisplay;
    public Text scoreDispaly;
    public Text endScore;
    public int number;

    private void Start()
    {
        number = 0;
        if (scoreDispaly != null)
            scoreDispaly.text = number.ToString();
        
        if (highScoreDisplay != null)
            highScoreDisplay.text = GetHighScore().ToString();

        if (endScore != null)
            endScore.text = GetEndScore().ToString();




    }


    public void ScoreBoard(int value)
    {
        number += value;
        scoreDispaly.text = number.ToString();
    }

    public void SaveScore()
    {
        PlayerPrefs.SetInt("yourScore", number);

        if (number > PlayerPrefs.GetInt("highscoreS")) {
            PlayerPrefs.SetInt("highscoreS", number);

        }

    }
    public int GetHighScore()
    {
        return PlayerPrefs.GetInt("highscoreS");
    }
    public int GetEndScore()
    {
        return PlayerPrefs.GetInt("yourScore");
    }
        

    public void OnDisable()
    {
        SaveScore();
              
    }



}
