using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerMovement : MonoBehaviour {

   

    public float speed;
    Rigidbody rb;
    public float RotateSpeed = 30f;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.transform.position += Vector3.forward * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.transform.position += Vector3.back * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.transform.position += Vector3.right * speed * Time.deltaTime;
            transform.Rotate(Vector3.up * RotateSpeed * Time.deltaTime);


        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.transform.position += Vector3.left * speed * Time.deltaTime;
            transform.Rotate(-Vector3.up * RotateSpeed * Time.deltaTime);
        }


    }

}
