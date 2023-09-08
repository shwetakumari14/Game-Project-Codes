using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    public float turnSpeed = 30.0f; 
    // public float rotationSpeed = 30.0f;
    public float horizontalInput; 
    public float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        
        // Vector3 movement = (transform.forward * forwardInput + transform.right * horizontalInput) * Time.deltaTime * speed;
        // transform.Translate(movement);

        // Calculate the forward movement
        Vector3 movement = transform.forward * forwardInput * speed * Time.deltaTime;

        // Apply the forward movement to the vehicle
        transform.Translate(movement);

        // Calculate the rotation
        float rotationAmount = horizontalInput * turnSpeed * Time.deltaTime;

        // Create a Quaternion for the rotation
        Quaternion turnRotation = Quaternion.Euler(0, rotationAmount, 0);

        // Apply the rotation to the vehicle
        transform.rotation *= turnRotation;
        
    }
}


