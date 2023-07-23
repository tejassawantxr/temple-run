using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    Transform lookAt;
    Vector3 startOffSet;
    // Start is called before the first frame update
    void Start()
    {
        lookAt = GameObject.FindGameObjectWithTag("Player").transform;
        startOffSet = transform.position - lookAt.position;   //distance between camera and player  
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = lookAt.position + startOffSet;  //follow the player by keeping offset distance in between camera and player
    }
}
