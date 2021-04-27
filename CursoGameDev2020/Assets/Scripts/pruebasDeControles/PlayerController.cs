using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerController : MonoBehaviour
{

    [SerializeField] InputAction movement;

    // Start is called before the first frame update
    void Start()
    {
        
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


        float horizontalThrow = movement.ReadValue<Vector2>().x;
        float verticalThrow = movement.ReadValue<Vector2>().y;
        transform.position = new Vector3(transform.position.x + horizontalThrow * 0.01f, 0, transform.position.z + verticalThrow * 0.01f);




    }
}
