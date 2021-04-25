using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<MeshRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Time.time);
        if (Time.time > 3)
        {
            GetComponent<Rigidbody>().useGravity = true;
            GetComponent<MeshRenderer>().enabled = true;
        }
    }
}
