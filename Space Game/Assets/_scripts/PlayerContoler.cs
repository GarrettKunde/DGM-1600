﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContoler : MonoBehaviour {

    //public float MoveSpeed = 1;
    private Transform transform;
   
    public float turnSpeed = 100;

    public GameObject projectile;
    public Transform shotPos;
    public float shotForce;
    public float moveSpeed;

    public float thrust;
    public Rigidbody2D rb;

    public ParticleSystem particles;

    public int health;

    public bool tooFast;
    public float timer;

    void Start()
    {
        transform = this.GetComponent<Transform>();

        rb = GetComponent<Rigidbody2D>();

        tooFast = false;
        timer = 30;

    }

    private void Update()
    {

        

        if (Input.GetKey(KeyCode.UpArrow))
        {  
            rb.AddForce(transform.up * thrust);
        particles.Emit (1); 
        }
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(Vector3.forward, turnSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(Vector3.forward, -turnSpeed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject shot = Instantiate(projectile, shotPos.position, shotPos.rotation) as GameObject;

            shot.GetComponent<Rigidbody2D>().AddForce(shotPos.up * shotForce);
            
        }
        
        if (tooFast == true)
        {
            timer -= Time.deltaTime;
        }
        if (timer <= 0)
        {
            thrust = 10;
            tooFast = false;
            timer = 30;
        }

    
    }

}
