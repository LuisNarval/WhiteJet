using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class palanca : MonoBehaviour {


    public GameObject stick;
    RectTransform stickP;

    // Use this for initialization
    void Start () {
        stickP = stick.GetComponent<RectTransform>();
	}
	
	// Update is called once per frame
	void Update () {

        actualizarStick();

    }



    void actualizarStick() {

        stickP.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        stickP.position = new Vector3(stickP.position.x, stickP.position.y, 0);

    }



    


}
