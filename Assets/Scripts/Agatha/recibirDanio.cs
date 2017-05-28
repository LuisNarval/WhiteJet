using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recibirDanio : MonoBehaviour {

    public int vida = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    void OnCollisionEnter2D(Collision2D invasor)
    {

        if (invasor.gameObject.tag == "enemigo")
        {
            vida--;

            if (vida <= 0)
            {
                Destroy(this.gameObject);
            }

        }

    }



}
