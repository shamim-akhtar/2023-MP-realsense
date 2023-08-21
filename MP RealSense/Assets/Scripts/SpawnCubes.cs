using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCubes : MonoBehaviour
{
    public GameObject cubes;
    public Transform[] spawnPoints;
    float spawnInterval;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while (true)
        {
            spawnInterval = Random.Range(1.0f, 5.0f);
            yield return new WaitForSeconds(spawnInterval);

            Instantiate(cubes, spawnPoints[Random.Range(0, 2)]);
        }
    }
}
