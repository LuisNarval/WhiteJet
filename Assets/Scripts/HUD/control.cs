using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour {

    public GameObject PAD;
    RectTransform PADposition;

    // Use this for initialization
    void Start()
    {
        PADposition = PAD.GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void colocarPAD()
    {
        PAD.SetActive(true);
        PADposition.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        PADposition.position = new Vector3(PADposition.position.x, PADposition.position.y, 0);
    }

    public void quitarPAD()
    {
        PAD.SetActive(false);
    }

}
