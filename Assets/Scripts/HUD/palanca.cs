using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class palanca : MonoBehaviour {

    public movimiento movAgatha;

    public GameObject stick;
    RectTransform stickP;
    
    Vector3 posicionTouch;



    // Use this for initialization
    void Start () {
        stickP = stick.GetComponent<RectTransform>();
    }


    private void FixedUpdate()
    {
        actualizarStick();
    }


    // Update is called once per frame
    void Update () {}


    Vector3 nuevoTamanio= new Vector3(0,0,0);

    void actualizarStick() {

        posicionTouch= Camera.main.ScreenToWorldPoint(Input.mousePosition);
        posicionTouch= new Vector3(posicionTouch.x, posicionTouch.y, 0);

        stickP.position = posicionTouch;

        nuevoTamanio = stickP.anchoredPosition.normalized;
        
        if (stickP.anchoredPosition.magnitude>40.0) {
            stickP.anchoredPosition = nuevoTamanio*39;
        }

        movAgatha.moverse(nuevoTamanio);

        print(nuevoTamanio);   
    }

    
}