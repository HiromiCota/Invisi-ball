using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmitterControl : MonoBehaviour {
    private Rigidbody ball;
    public ParticleSystem sparks;
    [SerializeField] float particleMultiplier;

    // Use this for initialization
    void Start () {
        ball = GetComponent<Rigidbody>();
        //sparks.Stop();
	}

    // Update is called once per frame
    void Update() {
        var main = sparks.main;
        main.maxParticles = (int)((Vector3.Distance(ball.velocity, Vector3.zero)) * particleMultiplier);
        if (main.maxParticles < 10) {
            sparks.Pause();
            sparks.Clear();
        } else
            sparks.Play();
    }
}
