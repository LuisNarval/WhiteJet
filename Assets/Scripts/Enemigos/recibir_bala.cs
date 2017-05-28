using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recibir_bala : MonoBehaviour {


    public float vida = 2;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    

    void OnCollisionEnter2D (Collision2D invasor)
    {

        if (invasor.gameObject.tag == "bala_Lemon")
        {
            Destroy(invasor.gameObject);
            vida--;

            if (vida <= 0) {
                Destroy(this.gameObject);
            }

        }
        
    }

}
