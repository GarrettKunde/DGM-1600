﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser : MonoBehaviour {

    public float lifetime;
    public float speed;

    void Update ()
    {
        //transform.Translate(Vector3.up * speed * Time.deltaTime);

        lifetime -= Time.deltaTime;
        if (lifetime <= 0)
        {
            Destroy(this.gameObject);
        }
		
	}
}
