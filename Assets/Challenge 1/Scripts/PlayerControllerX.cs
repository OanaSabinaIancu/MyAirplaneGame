using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private float speed = 3.0f;
    private float horizontalSpeed = 5.0f;
    private float rotationSpeed = 3.0f;
    private float verticalInput;
    private float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.up * horizontalSpeed * verticalInput);
        transform.Translate(Vector3.forward * speed * horizontalInput);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Time.deltaTime * rotationSpeed * verticalInput, 0, 0);
    }
}
