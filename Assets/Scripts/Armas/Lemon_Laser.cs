using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lemon_Laser : MonoBehaviour {


    Animator animador;
    public GameObject Lemon_Bala;
    public GameObject Posicion_Bala;

    public bool disparando = false;

	// Use this for initialization
	void Start () {
        animador = this.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            disparando=true;
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            disparando = false;
        }



        if (disparando){
            disparar();
        }

    }
    



   public void disparar() {
        animador.SetTrigger("disparar");
        animador.SetBool("disparando", true);
    }



    public void apagarDisparo() {
        animador.SetBool("disparando", false);
    }


    public void instanciarBala() {
        Instantiate(Lemon_Bala,Posicion_Bala.transform.position,Posicion_Bala.transform.rotation);
    }




    public void touchDown() {
        disparando = true;
    }


    public void touchUp() {
        disparando = false;
    }


}
