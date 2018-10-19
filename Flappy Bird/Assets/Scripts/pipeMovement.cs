using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeMovement : MonoBehaviour {

    private Rigidbody2D rb;

    public float speed;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        GetComponent<Rigidbody2D>().velocity = transform.right * speed;
    }
}
