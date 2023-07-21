using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5.0f; 
    [SerializeField] float rotationSpeed = 5.0f;

    CharacterController characterController;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
       float xValue = Input.GetAxis("Horizontal");
       float yValue = 0;
       float zValue = Input.GetAxis("Vertical");

       Vector3 movementDirection = new Vector3(xValue, yValue, zValue);
       movementDirection.Normalize();  //diagonally character moves faster compared to moving in x and y direction. So x, y or diagonally the character will move by 1 unit only.
       characterController.SimpleMove(movementDirection * moveSpeed); //Build-in frame rate independent

       if(movementDirection != Vector3.zero){
            //Characters smooth rotation to the direction along with the face and body
            Quaternion toRotation = Quaternion.LookRotation(movementDirection, Vector3.up); //Calulates rotation value of how much to rotate
            transform.rotation = Quaternion.RotateTowards(transform.rotation,toRotation, rotationSpeed * Time.deltaTime); //smooth rotation of the characters body to the specific directions
       }
    }
}
