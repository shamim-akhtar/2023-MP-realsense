using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnProjectiles : MonoBehaviour
{
    public GameObject projectiles;
    public Transform[] spawnPoints;
    public AudioClip clip;
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

            Instantiate(projectiles, spawnPoints[Random.Range(0, spawnPoints.Length)]);
            AudioSource.PlayClipAtPoint(clip, transform.position, 1.5f);
        }
    }
}
