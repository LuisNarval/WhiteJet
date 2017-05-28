using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background_move : MonoBehaviour {

    public puntuaciones HUDD;

    public float velocidad = 5.0f;
    float offsetX;


    public Material materialFondo;
    Vector2 offset;


	// Use this for initialization
	void Start () {

        //materialFondo = this.GetComponent<MeshRenderer>().material;

        offset = materialFondo.GetTextureOffset("_MainTex");
        offsetX = offset.x;
    }


    float caminoRecorrido=0.0f;
    
  

    // Update is called once per frame
    void Update () {

        float aumento= 0.02f * velocidad * Time.deltaTime;

        offsetX -= aumento;
        caminoRecorrido += aumento*50; 


        HUDD.aD((int)caminoRecorrido);

        if (offsetX < -100.0f)
            offsetX = 0.0f;

        materialFondo.SetTextureOffset("_MainTex", new Vector2(offsetX,offset.y));

    }



}
