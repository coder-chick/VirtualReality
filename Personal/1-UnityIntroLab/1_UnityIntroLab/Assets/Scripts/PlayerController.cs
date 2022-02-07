using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // initializing speed variable
    // public so we can use this variable outside this class
    // changed to private variables
    private float speed = 20.0f;
    private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float forwardInput;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // this is where we get player input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // We'll move the vehicle forward based on vertical input
        // transform.Translate(0, 0, 1);
        // the code below makes for a more accurate speed that based on time
        // and not frames per second, which can vary depending on the device
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        // we use this to turn the vehicle in a more realistic manner as opposed
        // to just shifting from left to right like it was doing in the commented
        // code below
        // based on vertical input
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
        // transform.Translate(Vector3.right* Time.deltaTime * turnSpeed * horizontalInput);
    }
}
