using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    //Create a target reference for what the camera is looking at.
    public Transform target;

    //Create a offset variable for the camera to be in location from the player.
    public Vector3 offset;

    //Create a boolean to control whether offset is used or not.
    public bool useOffsetValues;

    //float variable to control how fast our camera rotates.
    public float rotateSpeed;

    
    // Start is called before the first frame update
    void Start()
    {
        //Offset is equal to the targets position from the camera's current position.
        //So when the checkbox for Offset Values is unchecked then set the offset from how far the player is.   

        if (!useOffsetValues)
        {
            offset = target.position - transform.position;
        }

        
        Cursor.lockState = CursorLockMode.Locked;
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //Get the x position of the mouse & rotate the target.
        float horizontal = Input.GetAxis("Mouse X") * rotateSpeed;

        //Rotate whatever the camera is targetting across the Y axis by movement along the X.
        target.Rotate(0, horizontal, 0);
        
        

        //Move the camera based on the current rotation of the target & the original offset
        /*Euler angles are vectors in a quaternion plane of a three dimensional space.
         * Basically for any rotation or sequence of rotations of a coordinate system at a fixed point
         * is equivalent to a single rotation by a given angle that runs through the fixed point from the origin.
         */
        float desiredYAngle = target.eulerAngles.y;

        //Create a Euler Rotation based on the desired angle along the y axis based on the target's euler position coordination to it.
        Quaternion rotation = Quaternion.Euler(0, desiredYAngle, 0);

        // Change the cameras position based on the targets position by the Euler Angle in conjunction of the offset.
        transform.position = target.position - (rotation * offset);

        //Every frame the camera's position is now the target's position minus the offset.
       // transform.position = target.position - offset;
        transform.LookAt(target);
    }
}
