using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmitterControl : MonoBehaviour {
    private Rigidbody ball;
    public ParticleSystem sparks;    

	// Use this for initialization
	void Start () {
        ball = GetComponent<Rigidbody>();
        //sparks.Stop();
	}
	
	// Update is called once per frame
	void Update () {
        if (ball.IsSleeping()) {
            sparks.Pause();
            sparks.Clear();
        } else
            sparks.Play();
	}
}
