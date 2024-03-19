
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public Camera cam; 
    public float cam_dist = 1;

    // Start is called before the first frame update
    void Start()
    {
        var rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // set camera to follow player
        cam.transform.position = new Vector3(transform.position.x, transform.position.y + cam_dist, transform.position.z - 2*cam_dist);
        cam.transform.LookAt(transform.position);
        var rb = GetComponent<Rigidbody>();
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector3.forward * 10);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector3.back * 10);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.left * 10);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.right * 10);
        }   
    }
}
