using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class puntuaciones : MonoBehaviour {

    public Text txt_distancia;
    public Text txt_mejor;
    public Text txt_spark;


    public int scoreDistancia = 0;
    public int scoreMejor = 0;
    public int scoreSpark = 0;
    


	// Use this for initialization
	void Start () {
        aumentarSparks(0);

        if (PlayerPrefs.HasKey("MEJORDISTANCIA"))
        {
            print("Ya hay una mejor distancia.");
            scoreMejor = PlayerPrefs.GetInt("MEJORDISTANCIA");
        }
        else
        {
            print("Nunca se ha jugado.");
            scoreMejor = 0;
        }

        actualizarMejor();

    }
	
	// Update is called once per frame
	void Update () {
	 	
	}

    void actualizarMejor(){
        txt_mejor.text = acomodarDatos(4, scoreMejor);
    }

    public void aD(int cantidad) {
        scoreDistancia = cantidad;
        txt_distancia.text = acomodarDatos(4, scoreDistancia);
    }

    public void aumentarSparks(int cantidad) {
        scoreSpark += cantidad;
        txt_spark.text = acomodarDatos(3, scoreSpark);
    }

    string acomodarDatos(int largo, int cantidad) {

        string resultado="";

        switch (largo) {

            case 3:
                if (cantidad < 10)
                {
                    resultado = "00" + cantidad;
                }
                else if (cantidad < 100) {
                    resultado = "0" + cantidad;
                }
                else if (cantidad < 1000)
                {
                    resultado = ""+cantidad;
                }
                break;

            case 4:
                if (cantidad < 10)
                {
                    resultado = "000" + cantidad;
                }
                else if (cantidad < 100)
                {
                    resultado = "00" + cantidad;
                }
                else if (cantidad < 1000)
                {
                    resultado = "0" + cantidad;
                }
                else if (cantidad < 10000)
                {
                    resultado = ""+cantidad;
                }

                break;
                
            default:
                print("Algo salio terriblemente mal, el largo de la cadena que se quiere acomodar en el marcador es de: "+cantidad.ToString());

                resultado="Algo salio terriblemente mal.";

                break;
        }


        return resultado;

    }




    public void guardarPuntuaciones() {
        PlayerPrefs.SetInt("DISTANCIARECORRIDA",scoreDistancia);
        PlayerPrefs.SetInt("SPARKS",scoreSpark);
    }

}
