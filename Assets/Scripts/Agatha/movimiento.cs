using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour {

    public float velocidad = 5.0f;

	// Use this for initialization
	void Start () {
	}


    private void FixedUpdate()
    {
        detectarTeclas();
    }

    // Update is called once per frame
    void Update () {
        
	}

    void detectarTeclas() {
        if (Input.GetKey(KeyCode.W))
        {
            moverse(Vector2.up);
        }

        if (Input.GetKey(KeyCode.A))
        {
            moverse(Vector2.left);
        }

        if (Input.GetKey(KeyCode.D))
        {
            moverse(Vector2.right);
        }

        if (Input.GetKey(KeyCode.S))
        {
            moverse(Vector2.down);
        }
    }



    public void moverse(Vector3 direccion)
    {
        this.transform.Translate(direccion * velocidad * Time.deltaTime);
    }


}
