using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereRaycast : MonoBehaviour {

    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.back, out hit))
        {
            if(hit.collider.tag == "Enemy")
            {
                Destroy(gameObject);
            }
        }
		
	}
}
