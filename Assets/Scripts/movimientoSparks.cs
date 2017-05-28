using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoSparks : MonoBehaviour {


    public float velocidad = 5.0f;
    public float tamanio = 10.0f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        avanzar();	
	}


    void avanzar() {
        this.transform.Translate(Vector3.left*velocidad*Time.deltaTime);

        if (this.transform.position.x < -tamanio) {

            Destroy(this.gameObject,2.0f);

        }

    }

}
