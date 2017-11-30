using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundMang : MonoBehaviour {

    public static AutoClip laser, boom;
    static AudioSource audioSrc;

	// Use this for initialization
	void Start () {
        laser = Resource.Load < AutoClip > "laser";
        boom = Resource.Load < AutoClip > "boom";

        audioSrc = GetComponet <>

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
