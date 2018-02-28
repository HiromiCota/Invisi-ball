using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VictoryCondition : MonoBehaviour {
    int Level; // What level are we on?
    Rigidbody ball;
    bool readyForWin;
    [SerializeField] Text victoryText;
    
    // Use this for initialization
    void Start() {
        ball = GetComponent<Rigidbody>();
        Level = 1;
        readyForWin = true;
        victoryText.enabled = false;
    }
           
    void OnCollisionEnter(Collision col) {
        //Debug.Log("Collision detected.");
        if (readyForWin && col.collider.tag == "floor") {
            Victory(Level++);
            readyForWin = false;
        }
        if (col.collider.tag == "block") {
            BlockHit(col);
        }
    }

    void Victory(int level) {
        string victory = "You've completed Level " + level + "!";
        victoryText.text = victory;
        victoryText.enabled = true;
    }

    void BlockHit(Collision col) {
        // Trigger the block's emitter. 
        Debug.Log(col.gameObject.name + " hit.");        
    }
}
