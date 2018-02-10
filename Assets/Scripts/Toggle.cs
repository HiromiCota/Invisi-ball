using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toggle : MonoBehaviour {
    public List<GameObject> blockGroup;
    public GameObject button;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if ( (button.name))
        {
            foreach (GameObject block in blockGroup)
                block.SetActive(false);
        }
        else
        {
            foreach (GameObject block in blockGroup)
                block.SetActive(true);
        }
    }
}
