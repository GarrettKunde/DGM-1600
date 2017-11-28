﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockScript : MonoBehaviour {

    public float StartingSpin;
    public Rigidbody2D rb2;
    public float move;
    public GameObject Splosion;


    void Start () {
        GetComponent<Rigidbody2D>().AddTorque(Random.Range(-StartingSpin,StartingSpin),ForceMode2D.Impulse);
        rb2 = GetComponent<Rigidbody2D>();
        rb2.AddForce(transform.up * move);
	}
	
	
	void Update () {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(this.gameObject);
        Instantiate(Splosion, transform.position, Quaternion.identity);
    }
}
