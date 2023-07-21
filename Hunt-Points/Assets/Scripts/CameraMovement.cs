using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    // Start is called before the first frame update
    Transform followAt;
    Vector3 offset;
    Vector3 moveVector;

    void Start()
    {
        followAt = GameObject.FindGameObjectWithTag("Player").transform;  //camera to follow the player
        offset = transform.position - followAt.position;   //distance between camera and player  
    }

    // Update is called once per frame
    void Update()
    {
        moveVector = followAt.position + offset; //follow the player by keeping offset distance in between camera and player
        moveVector.x = 0;  //camera should be at the center
        moveVector.y = Mathf.Clamp(moveVector.y, 5, 7); 

        transform.position = moveVector;  
    }
}
