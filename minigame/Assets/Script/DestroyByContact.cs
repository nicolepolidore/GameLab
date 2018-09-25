using UnityEngine;

using System.Collections;

public class DestroyByContact : MonoBehaviour

{


    private GameController gameController;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Boundary")
        {
            return;
        }
        Destroy(other.gameObject);
        Destroy(gameObject);

        if (other.tag == "Player")
        {
            return;

           
        }
     

    }
}

