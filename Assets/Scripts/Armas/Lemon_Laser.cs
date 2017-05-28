using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lemon_Laser : MonoBehaviour {


    Animator animador;
    public GameObject Lemon_Bala;
    public GameObject Posicion_Bala;


	// Use this for initialization
	void Start () {
        animador = this.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.Space))
        {
            disparar();
        }

    }


    void disparar() {
        animador.SetTrigger("disparar");
        animador.SetBool("disparando", true);
    }



    public void apagarDisparo() {
        animador.SetBool("disparando", false);
    }


    public void instanciarBala() {
        Instantiate(Lemon_Bala,Posicion_Bala.transform.position,Posicion_Bala.transform.rotation);
    }


}
