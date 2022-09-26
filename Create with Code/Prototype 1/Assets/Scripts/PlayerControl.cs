using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnspeed = 90.0f;
    private float horizontalInput;
    private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis ("Horizontal");
        forwardInput = Input.GetAxis ("Vertical");
        //Move vehichle forward and backward on input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //Rotates direction vehichle is facing on input
        transform.Rotate(Vector3.up, turnspeed * horizontalInput * Time.deltaTime );
    }
}
