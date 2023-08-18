using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCubes : MonoBehaviour
{
    GameObject cubes;
    public Transform[] spawnPoints;
    float spawnInterval;

    // Start is called before the first frame update
    void Start()
    {
        cubes = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        spawnInterval = Random.Range(1, 5);

    }

    void Spawn()
    {
        Instantiate(cubes, spawnPoints[Random.Range(0, 2)]);

    }
}
