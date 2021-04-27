using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // se mueve y vuelve según la fuerz aplicada, no la acumula
       // float horizontalThrow = Input.GetAxis("Horizontal");
       // float verticalThrow = Input.GetAxis("Vertical");
       // transform.position = new Vector3(horizontalThrow,0, verticalThrow);


        // se mueve acumula la fuerz aplicada
        float horizontalThrow2 = Input.GetAxis("Horizontal");
        float verticalThrow2 = Input.GetAxis("Vertical");
        transform.position = new Vector3(transform.position.x + horizontalThrow2*0.01f, 0, transform.position.z + verticalThrow2 * 0.01f);

    }
}
