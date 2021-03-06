﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public static int playerCount;

    private void Start()
    {
        playerCount = FindObjectsOfType<PlayerContoler>().Length;
        
    }

    private void Update()
    {
        playerCount = FindObjectsOfType<PlayerContoler>().Length;
       
        if ( playerCount <= 0)
        {
            LoadNextLevel();
        }
    }

    public void LevelLoad(string lvl)
    {
        SceneManager.LoadScene(lvl);
    }

    public void ExitGame ()
    {
        print ("Tried to Exit");
        Application.Quit (); 
    }

    public void LoadNextLevel ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        print ("tried to load");
    }

    
    
}
