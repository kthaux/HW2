using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{

    public Transform target;
    public Transform pivotObject;
    // public Vector3 pivotPoint = new Vector3(0f,0f,0f);
    public float rotationAngle = 90f;

    void Update()
    {
        transform.RotateAround(pivotObject.transform.position, Vector3.up, rotationAngle*Time.deltaTime);

        // transform.position += new Vector3(0.0f, 0.0f, 4.0f);
        // Rotate the camera every frame so it keeps looking at the target
        transform.LookAt(target);

        // Same as above, but setting the worldUp parameter to Vector3.left in this example turns the camera on its side
        // transform.LookAt(target, Vector3.left);
    }

    // //movement speed in units per second
    // public float movementSpeed = 10f;
    // // public Vector3 pivotPoint = new Vector3(4f,4f,4f);

    // void Update()
    // {
    //     //get the Input from Horizontal axis
    //     float horizontalInput = Input.GetAxis("Horizontal");
    //     //get the Input from Vertical axis
    //     float verticalInput = Input.GetAxis("Vertical");
        
    //     //update the position
    //     transform.position = transform.position + new Vector3(horizontalInput * movementSpeed * Time.deltaTime, 0,  verticalInput * movementSpeed * Time.deltaTime);
    //     // Vector3 pivotPoint = new Vector3(0f,50f,0f);
    //     // transform.RotateAround(pivotPoint, Vector3.up, 90*Time.deltaTime);

    // }
}
