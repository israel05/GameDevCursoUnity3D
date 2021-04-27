using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerControllerGiro : MonoBehaviour
{

    [SerializeField] InputAction movement;
    public float minRotation = -45f;
    public float maxRotation = 45f;

    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(new Vector3(0, 0.1f, 0));
    }


    /// <summary>
    /// Metodos necesarioas para activar el INPUNTACTION OnEneable
    /// </summary>
    private void OnEnable()
    {
        movement.Enable();
    }
    /// <summary>
    /// Metodos necesarioas para activar el INPUNTACTION OnDisable
    /// </summary>
    private void OnDisable()
    {
        movement.Disable();
    }

    // Update is called once per frame
    void Update()
    {



        ///////////// CON INPUT MANAGER ANTIGUO
        // se mueve y vuelve según la fuerz aplicada, no la acumula
        // float horizontalThrow = Input.GetAxis("Horizontal");
        // float verticalThrow = Input.GetAxis("Vertical");
        // transform.position = new Vector3(horizontalThrow,0, verticalThrow);


        // se mueve acumula la fuerz aplicada
        // float horizontalThrow2 = Input.GetAxis("Horizontal");
        //float verticalThrow2 = Input.GetAxis("Vertical");
        // transform.position = new Vector3(transform.position.x + horizontalThrow2*0.01f, 0, transform.position.z + verticalThrow2 * 0.01f);
        ///////// FIN INPUT MANAGER ANTIGUO


        //  float horizontalThrow = movement.ReadValue<Vector2>().x;
        //  float verticalThrow = movement.ReadValue<Vector2>().y;

        float giroTorretaX = movement.ReadValue<Vector2>().x;
        float giroTorretaY = movement.ReadValue<Vector2>().y;
       // transform.Rotate (new Vector3(0, giroTorretaY, 0)); //solo mueve y vuelve al sitio
        Debug.Log("  " + transform.localRotation.y + " <-localRotation.y");
        Debug.Log("  " + transform.localRotation.eulerAngles.y + " <-localRotation.eulerAngles.y");


        //transofmración inicial
       


        if (transform.localRotation.y >=-0.5f && transform.localRotation.y <= 0.5f) { 
        
            transform.Rotate(new Vector3(0, giroTorretaY, 0));
        }
        
        //corte en horario
        if(transform.localRotation.y < -0.5)
        {
            transform.Rotate(new Vector3(0, minRotation / 100, 0));
            
        } 

        //corte en antihorario
        if (transform.localRotation.y > 0.5)
        {
            transform.Rotate(new Vector3(0, maxRotation / 100, 0));
        }




    }
}
