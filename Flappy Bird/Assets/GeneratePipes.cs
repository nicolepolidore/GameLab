using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratePipes : MonoBehaviour {

    public GameObject original;
    public GameObject thirdPipe;
    public GameObject fourthPipe;
    public GameObject secondPipe;
    public int numberOfObjects = 4;
    public float radius = 5f;
    public float spawnWait;
    public float startWait;
    public float waveWait;
    public Vector2 spawnValues;

    void Start()
    {
        StartCoroutine(GenerateObj());
    }

    IEnumerator GenerateObj()
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            for(int i = 0; i<numberOfObjects; i++)
            {
                Vector2 spawnPosition = new Vector2(Random.Range(-spawnValues.x, spawnValues.y),spawnValues.y);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(original, spawnPosition, spawnRotation);
                Instantiate(secondPipe, spawnPosition, spawnRotation);
                Instantiate(thirdPipe, spawnPosition, spawnRotation);
                Instantiate(fourthPipe, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(waveWait);
        }
    }
}

