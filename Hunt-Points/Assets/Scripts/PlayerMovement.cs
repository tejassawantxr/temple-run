using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed = 5.0f;
    
    Vector3 moveVector;
    float gravity = -9.81f;

    CharacterController controller;
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(controller.isGrounded){
            gravity=-0.5f;
        }else{
            gravity=-9.81f;
        }
        // moveVector = Vector3.zero;
        moveVector.x = Input.GetAxisRaw("Horizontal") * speed;
        moveVector.y = gravity;
        moveVector.z = speed;

        controller.Move(moveVector * Time.deltaTime); //frame rate independent
    }
}
