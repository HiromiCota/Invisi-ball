using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmitterControl : MonoBehaviour {
    public Rigidbody ball;
    public ParticleSystem sparks;    

	// Use this for initialization
	void Start () {      
        sparks.Stop();
	}
	
	// Update is called once per frame
	void Update () {
        if (ball.IsSleeping())
            sparks.Stop();
        else
            sparks.Play();
	}
}
