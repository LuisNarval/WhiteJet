using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour {

    public float velocidad = 5.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        moverse();
        	
	}



    void moverse() {
        

        if (Input.GetKey(KeyCode.W) && this.transform.position.y < 8.5f)
        {
            this.transform.Translate(Vector2.up * velocidad * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A) && this.transform.position.x > 2.2f)
        {
            this.transform.Translate(Vector2.left * velocidad * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D) && this.transform.position.x < 15.5f)
        {
            this.transform.Translate(Vector2.right * velocidad * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S) && this.transform.position.y > 0.08f)
        {
            this.transform.Translate(Vector2.down * velocidad * Time.deltaTime);
        }

    }


}
