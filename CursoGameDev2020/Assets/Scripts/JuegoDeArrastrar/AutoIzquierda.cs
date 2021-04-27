using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoIzquierda : MonoBehaviour
{
    [Tooltip ("Es la velocidad a la que se mueve en Z")]
    public float valorVelocidad = 7f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();

    }

    private void MovePlayer()
    {
        transform.Translate(
            Input.GetAxis("Horizontal") * Time.deltaTime * valorVelocidad,
            0 * Time.deltaTime,
            Input.GetAxis("Vertical") * Time.deltaTime * valorVelocidad);
    }
}
