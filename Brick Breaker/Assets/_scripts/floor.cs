﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floor : MonoBehaviour {
    public LevelManager myLevelManager;

   

    private void OnTriggerEnter2D (Collider2D trigger)
    {
        myLevelManager.LevelLoad("GameOver");   
    }


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
