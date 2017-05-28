using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recolectarSparks : MonoBehaviour {

    public puntuaciones HUDPuntuaciones;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    private void OnTriggerEnter2D(Collider2D invasor)
    {
        if (invasor.gameObject.tag == "spark") {
            Destroy(invasor.gameObject,2.0F);
            invasor.gameObject.transform.position=new Vector3(0.0f,100.0f,-2.0f);
            invasor.gameObject.GetComponent<AudioSource>().Play();
            HUDPuntuaciones.aumentarSparks(1);
        }
    }


}
