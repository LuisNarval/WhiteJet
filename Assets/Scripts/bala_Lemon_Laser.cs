using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala_Lemon_Laser : MonoBehaviour {


    public float velocidad = 10.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        desplazarse();
	}


    void desplazarse() {
        this.transform.Translate(Vector2.right * velocidad * Time.deltaTime);


        if (this.transform.position.x > 18.5) {
            Destroy(this.gameObject);
        }

    }



}
