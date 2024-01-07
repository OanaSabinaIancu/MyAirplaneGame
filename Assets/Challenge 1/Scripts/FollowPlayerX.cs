using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset = new Vector3(0, 4, -8);
    private Vector3 rotationPlane = new Vector3(0, 90, 0);
    private float verticalInput;
    public float speed = 15.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        verticalInput = Input.GetAxis("Vertical");
        //setting a camera offset on the plane
        transform.position = plane.transform.position + offset;
        transform.Rotate(offset, verticalInput * Time.deltaTime * speed);
    }
}
