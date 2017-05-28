using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ventanaGameOver : MonoBehaviour {


    public Text recorrido;
    public Text mejorRecorrido;
    public Text sparks;
    public Text tesoroSparks;
    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void marcarDatos() {
        if (PlayerPrefs.HasKey("MEJORDISTANCIA"))
        {
            if (PlayerPrefs.GetInt("DISTANCIARECORRIDA") > PlayerPrefs.GetInt("MEJORDISTANCIA")) {
                PlayerPrefs.SetInt("MEJORDISTANCIA", PlayerPrefs.GetInt("DISTANCIARECORRIDA"));
            }
        }
        else {
            PlayerPrefs.SetInt("MEJORDISTANCIA", PlayerPrefs.GetInt("DISTANCIARECORRIDA"));
        }


        if (PlayerPrefs.HasKey("TESOROSPARKS"))
        {
                PlayerPrefs.SetInt("TESOROSPARKS", PlayerPrefs.GetInt("TESOROSPARKS")+ PlayerPrefs.GetInt("SPARKS"));
           
        }
        else
        {
            PlayerPrefs.SetInt("TESOROSPARKS", PlayerPrefs.GetInt("SPARKS"));
        }

    }

    public void actualizarDatos() {
        recorrido.text = acomodarDatos( 4, PlayerPrefs.GetInt("DISTANCIARECORRIDA"));
        mejorRecorrido.text = acomodarDatos(4, PlayerPrefs.GetInt("MEJORDISTANCIA"));
        sparks.text = acomodarDatos(4, PlayerPrefs.GetInt("SPARKS"));
        tesoroSparks.text = acomodarDatos(4,PlayerPrefs.GetInt("TESOROSPARKS"));
    }



  


    public void reiniciarJuego(){
        SceneManager.LoadScene("Juego");
    }



    string acomodarDatos(int largo, int cantidad)
    {

        string resultado = "";

        switch (largo)
        {

            case 3:
                if (cantidad < 10)
                {
                    resultado = "00" + cantidad;
                }
                else if (cantidad < 100)
                {
                    resultado = "0" + cantidad;
                }
                else if (cantidad < 1000)
                {
                    resultado = "" + cantidad;
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
                    resultado = "" + cantidad;
                }

                break;

            default:
                print("Algo salio terriblemente mal, el largo de la cadena que se quiere acomodar en el marcador es de: " + cantidad.ToString());

                resultado = "Algo salio terriblemente mal.";

                break;
        }


        return resultado;

    }











}
