﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recibirDanio : MonoBehaviour {

    public int vida = 1;

    public GameObject HUD;
    public GameObject puntuaciones;
    public Animator animadorUI;
    public background_move codigoFondo;
    public generador codigoGenerador;

    puntuaciones codigoPuntuaciones;

    // Use this for initialization
    void Start () {
        codigoPuntuaciones = puntuaciones.GetComponent<puntuaciones>();
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
                morir();
            }

        }

    }



    public void morir() {

        codigoFondo.velocidad = 0.0f;
        codigoGenerador.enabled = false;

        codigoPuntuaciones.guardarPuntuaciones();
        animadorUI.SetTrigger("abrirEstadisticas");

        HUD.SetActive(false);


        Destroy(this.gameObject);
  
    }


}
