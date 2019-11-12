using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //create a float variable for movement speed and an characterController component Object.
    public float moveSpeed;
    public CharacterController characterController;

    private Vector3 moveDirection;
    public float gravityScale;

    
    // Basically a main method.
    void Start()
    {
        //Instantiate an object of the component.
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame  
    void Update()
    {
        /* Old Create logic for movement.
         * Move along the x axis from the player input by the movement speed
         * stagnate movement along the y.
         * Move along the z axis from the player input by the movement speed.
         */
        //moveDirection = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, moveDirection.y, Input.GetAxis("Vertical") * moveSpeed);

        /* Create logic for movement
         * Move in all directions based on whatever direction the player is facing by the movespeed.
         */
        float yStore = moveDirection.y;
        moveDirection = (transform.forward * Input.GetAxis("Vertical")) + (transform.right * Input.GetAxis("Horizontal"));
        moveDirection = moveDirection.normalized * moveSpeed;
        moveDirection.y = yStore;
        //if the players location in currently on the ground we want to set the movement along the y axis is 0.
        //We do this so gravity physics don't consistently shift the position of y down.
        if(characterController.isGrounded)
        {
            moveDirection.y = 0f;
        }
        //For the players current position on the y axis, apply gravity controlled by the gravity Scale variable.
        moveDirection.y = moveDirection.y + (Physics.gravity.y * gravityScale);

        //Add the movement logic to the characterController object by the current frame rate.
        characterController.Move(moveDirection * Time.deltaTime);
    }
}
