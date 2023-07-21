using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5.0f; 
    [SerializeField] float rotationSpeed = 5.0f;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
       float xValue = Input.GetAxis("Horizontal");
       float yValue = 0;
       float zValue = Input.GetAxis("Vertical");

       Vector3 movementDirection = new Vector3(xValue, yValue, zValue);
       movementDirection.Normalize();
       transform.Translate(movementDirection * moveSpeed * Time.deltaTime, Space.World);
       
       if(movementDirection != Vector3.zero){
            // transform.forward = movementDirection;
            Quaternion toRotation = Quaternion.LookRotation(movementDirection, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation,toRotation, rotationSpeed * Time.deltaTime);
       }
    }
}
