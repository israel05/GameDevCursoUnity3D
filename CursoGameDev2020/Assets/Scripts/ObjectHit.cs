using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    public int numeroDeColisiones = 0;
    private void OnCollisionEnter(Collision other)
    {
        //Detecta que es Player el que toca
        if(other.gameObject.tag  == "Player")
        {
            Debug.Log("Player ha tocado");
            //Del componente que ha recibido la colisión, coge su meshrenderer. Del meshRenderer coge el material. Del Material coge su color
            GetComponent<MeshRenderer>().material.color = Color.red;
            numeroDeColisiones++;
            Debug.Log("Colisión número:" + numeroDeColisiones);
        }

       
    }
}
