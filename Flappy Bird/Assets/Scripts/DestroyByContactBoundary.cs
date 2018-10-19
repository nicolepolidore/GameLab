using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContactBoundary : MonoBehaviour {


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Pipe")
        {
            Destroy(other.gameObject);
        }

    }
}
