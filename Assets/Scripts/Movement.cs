using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private float speed = 10;    //geschwindigkeit wie cube sich bewegt

    // Update is called once per frame
    void Update()
    {
        //Wenn Pfeiltasten gedrückt --> cube soll sich bewegen
        float horizontalMovement = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float verticalMovement = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        transform.Translate(horizontalMovement, 0, verticalMovement);
    
    }
}
