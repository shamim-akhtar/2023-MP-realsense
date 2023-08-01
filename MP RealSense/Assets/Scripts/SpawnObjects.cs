using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    public GameObject target;
    public float spawnCap = 4;
    public float numberTargets = 0;
    public Vector3 center;
    public Vector3 size;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SpawnTargets();
    }

    //Spawns the targets in but checks if it caps out by spawnCap
    void SpawnTargets()
    {
        if (numberTargets < spawnCap)
        {
            Vector3 spawnPosition = GetRandomSpawnPosition();
            Quaternion spawnRotation = Quaternion.Euler(0f, 0f, 0f);
            Instantiate(target, spawnPosition, spawnRotation);
            numberTargets++;
        }
    }

    //Randomises the spawn location of the targets
    private Vector3 GetRandomSpawnPosition()
    {
        float randomX = Random.Range(-size.x / 2f, size.x / 2f);
        float randomY = Random.Range(-size.y / 2f, size.y / 2f);

        Vector3 spawnPosition = new Vector3(center.x + randomX, center.y + randomY, center.z);

        return spawnPosition;
    }

    //Draws a box around the spawn area
    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(center, size);
    }
}
