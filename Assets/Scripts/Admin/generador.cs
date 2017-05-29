using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generador : MonoBehaviour {


    public float frecuencia = 3.0f;

    [Range(2.0f, 14.0f)]
    public float balance = 9.0f;


    float tE;

    public GameObject Robot1;
    public GameObject Meteorito;

    public GameObject Spark1;
    public GameObject Spark3;
    public GameObject Spark6;
    public GameObject Spark10;
    public GameObject SparkSnake;



    float tiempo;

    

    // Use this for initialization
    void Start () {
        tiempo = 0;
        tE= frecuencia;
	}
	


	// Update is called once per frame
	void Update () {

        tiempo += Time.deltaTime;
      
        if (tiempo>tE){

            tiempo = 0;
            instanciarAlgo();
        }
        	
	}



    void instanciarAlgo() {

        float dado1 = Random.Range(1.0f,7.0f);
        float dado2 = Random.Range(1.0f, 7.0f);

        float resultado = dado1 + dado2;

        //Aquí debe ir un número del 2 al 14 y representa el balance entre los enemigos y las monedas
        //Si queremos que haya más monedas se debe disminuir el número
        //Si queremos que haya más enemigos el número debe aumentar.
        //Actualmente esta en el nueve, más o menos balanceado pero con más enemigos que monedas. Esta ligera alteración al balance ocaciona que haya el doble de enemigos que de monedas.

        if (resultado > balance)
        {
            instanciarMonedas();
            print("Monedas");
        }
        else
        {
            instanciarEnemigos();
            print("Enemigo");
        }
        
    }


    void instanciarEnemigos(){
        float dado1 = Random.Range(1.0f, 7.0f);
        float dado2 = Random.Range(1.0f, 7.0f);

        float resultado = dado1 + dado2;


        if (resultado > 7)
        {
            instanciarMeteorito();
        }
        else {
            instanciarRobot1();
        }



    }

    void instanciarMonedas(){
        float dado1 = Random.Range(1.0f, 6.0f);
        
        int resultado = (int) dado1;

        switch (resultado) {

            case 1:

                instanciarSpark3();
                break;

            case 2:
                instanciarSpark6();
                break;

            case 3:
                instanciarSpark10();
                break;

            case 4:
                instanciarSparkSnake();
                break;

            case 5:
                instanciarSpark1();
                break;

            default:
                print("Algo salio terriblemente mal a la hora del random de las monedas. Valor resultado: "+resultado);
                break;

        }

    }




    void instanciarRobot1(){
        float dado1 = Random.Range(1.0f, 4.0f);
        int resultado = (int)dado1;

        switch (resultado) {
            case 1:
                Instantiate(Robot1, new Vector3(22.25f, 13.0f, -1), Quaternion.Euler(0.0f,0.0f,30.0f));
                tE= frecuencia + 1;
                break;
                
            case 2:
                Instantiate(Robot1, new Vector3(22, Random.Range(1.3f, 8.5f), -1), this.transform.rotation);
                tE = frecuencia + 1;
                break;

            case 3:
                Instantiate(Robot1, new Vector3(22.25f, -3.0f, -1), Quaternion.Euler(0.0f, 0.0f, -30.0f));
                tE = frecuencia + 1;
                break;

            default:
                print("Algo salio terriblemente mal a la hora del random de las monedas. Valor resultado: " + resultado);
                break;
        }
    }


    void instanciarMeteorito() {
        Instantiate(Meteorito, new Vector3(22, Random.Range(1.4f, 8.5f), -1), this.transform.rotation);
        tE = frecuencia + 0.6f;
    }

    void instanciarSpark1() {
        Instantiate(Spark1, new Vector3(22, Random.Range(1.0f, 9.0f), -2), this.transform.rotation);
        tE = frecuencia + 0.3f;
    }

    void instanciarSpark3(){
        Instantiate(Spark3, new Vector3(22, Random.Range(1.0f, 9.0f), -2), this.transform.rotation);
        tE = frecuencia + 0.9f;
    }

    void instanciarSpark6(){
        Instantiate(Spark6, new Vector3(22, Random.Range(1.0f, 9.0f), -2), this.transform.rotation);
        tE = frecuencia + 1.8f;
    }

    void instanciarSpark10(){
        Instantiate(Spark10, new Vector3(22, Random.Range(1.0f, 7.0f), -2), this.transform.rotation);
        tE = frecuencia + 1.5f;
    }

    void instanciarSparkSnake(){
        Instantiate(SparkSnake, new Vector3(22, Random.Range(1.0f, 5.6f), -2), this.transform.rotation);
        tE = frecuencia + 2.8f;
    }


}