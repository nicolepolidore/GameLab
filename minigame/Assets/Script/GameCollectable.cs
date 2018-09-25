using UnityEngine;
using System.Collections;

public class GameCollectable : MonoBehaviour
{

    public float speed;
    public Vector3 spawnValues;
    public int collectableCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;
    public GameObject collectable;
   // public GameObject OnTriggerEnter;

    //private Rigidbody rb;

    void Start()
    {
        StartCoroutine(SpawnWaves());
    }
    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            for (int i = 0; i < collectableCount; i++)
            {
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(collectable, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(waveWait);
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

            //rb.AddForce(movement * speed);
        }
    }
}

       // void OnTriggerEnter(Collider other)
       // {
     //       if (other.gameObject.CompareTag("Pick Up"))
     //       {
     //           other.gameObject.SetActive(false);
          //  }
     //   }
   // }
//}


 