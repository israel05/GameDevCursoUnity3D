using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caera : MonoBehaviour
{

    public float tiempoAntesDeCaida = 3f;
    // Start is called before the first frame update
    void Start()
    {
        //comienza oculto y sin gravedad
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Rigidbody>().useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
       // Debug.Log(Time.time);
        if (Time.time > tiempoAntesDeCaida)
        {
            GetComponent<Rigidbody>().useGravity = true;
            GetComponent<MeshRenderer>().enabled = true;
        }
    }
}
