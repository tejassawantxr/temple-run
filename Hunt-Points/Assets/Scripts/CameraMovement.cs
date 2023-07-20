using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    // Start is called before the first frame update
    Transform followAt;
    Vector3 offset;

    void Start()
    {
        followAt = GameObject.FindGameObjectWithTag("Player").transform;
        offset = transform.position - followAt.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = followAt.position + offset;
    }
}
