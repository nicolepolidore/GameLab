using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameController : MonoBehaviour
{
    public GameObject Sphere;
    public Vector3 spawnValues;
    public float spawnWait;
    public float startWait;
    public float waveWait;
    private int spawnsRemain;



    void Start()
    {

        StartCoroutine(SpawnWaves());
    }



    IEnumerator SpawnWaves()
    {
        
        while (true)
        {
           
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(Sphere, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(spawnWait);

                yield return new WaitForSeconds(waveWait);
            


        }

    }


}