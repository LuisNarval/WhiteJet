using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mov_lateral : MonoBehaviour {

    public float velocidad = 5.0f;
    public float tamanio = 2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


        this.transform.Translate(Vector2.left*velocidad*Time.deltaTime);

        if (this.transform.position.x < -tamanio)
            Destroy(this.gameObject);

	}
}
