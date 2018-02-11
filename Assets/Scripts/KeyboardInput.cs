using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class KeyboardInput : MonoBehaviour {
    public GameObject RedButton;
    public GameObject GreenButton;
    public GameObject BlueButton;
    public GameObject YellowButton;
    static bool ButtonDown;
    PointerEventData pointer;

    // Use this for initialization
    void Start () {
        pointer = new PointerEventData(EventSystem.current);
        ButtonDown = false;
    }
	
	// Update is called once per frame
	void Update () {
        //Only wake up if something's been pressed.
        // Also, only one of these gets to trigger at a time.
		if (Input.anyKey) {
            if (Input.GetMouseButton(0)) {
                ButtonDown = false;
                return; //Don't wake up for mouse events
            }
            else if (Input.GetAxis("RedB") != 0)
                FakeClick(RedButton);
            else if (Input.GetAxis("GreenA") != 0)
                FakeClick(GreenButton);
            else if (Input.GetAxis("BlueX") != 0)
                FakeClick(BlueButton);
            else if (Input.GetAxis("YellowY") != 0)
                FakeClick(YellowButton);
            else
                ButtonDown = false; //Not one of the 4 play buttons? Then, we don't care.
        }
        if (Input.GetAxis("RedB") == 0)
            FakeUp(RedButton);
        if (Input.GetAxis("GreenA") == 0)
            FakeUp(GreenButton);
        if (Input.GetAxis("BlueX") == 0)
            FakeUp(BlueButton);
        if (Input.GetAxis("YellowY") == 0)
            FakeUp(YellowButton);

    }

    void FakeClick(GameObject button) {
        if (ButtonDown != true) {
            ExecuteEvents.Execute(button.gameObject, pointer, ExecuteEvents.pointerEnterHandler);
            ExecuteEvents.Execute(button.gameObject, pointer, ExecuteEvents.pointerDownHandler);
            ButtonDown = true;
        }
    }

    void FakeUp(GameObject button) {
        ExecuteEvents.Execute(button.gameObject, pointer, ExecuteEvents.pointerEnterHandler);
        ExecuteEvents.Execute(button.gameObject, pointer, ExecuteEvents.pointerUpHandler);
        if (!Input.anyKey)
            ButtonDown = false;
    }
}
