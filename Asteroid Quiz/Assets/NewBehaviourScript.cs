using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	
        void Start()
        {
            Destroy(gameObject, 1.0f);
            GetComponent<Rigidbody>().AddForce(transform.forward * 200);

        }

}
