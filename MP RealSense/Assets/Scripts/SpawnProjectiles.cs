using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnProjectiles : MonoBehaviour
{
    public GameObject proj1;
    public GameObject proj2;
    public GameObject proj3;
    public GameObject proj4;
    public Transform[] spawnPoints;
    public AudioClip clip;
    float spawnInterval;
    float spawnCounter = 0f;

    // Start is called before the first frame update
    public void Start()
    {
        spawnCounter = 0f;
        StartCoroutine(Timer());
        StartCoroutine(Spawn());
    }

    private void Update()
    {
        if(spawnCounter == 1.0f)
        {
            StartCoroutine(Spawn2());
            spawnCounter = 3.0f;
        }
    }

    IEnumerator Timer()
    {
        while (true)
        {
            spawnCounter += 1.0f;
            yield return new WaitForSeconds(20f);
        }
    }

    IEnumerator Spawn()
    {
        while (true)
        {
            spawnInterval = Random.Range(1.0f, 5.0f);
            yield return new WaitForSeconds(spawnInterval);

            Instantiate(proj1, spawnPoints[Random.Range(0, spawnPoints.Length)]);
            AudioSource.PlayClipAtPoint(clip, transform.position, 1.5f);
        }
    }

    IEnumerator Spawn2()
    {
        while (true)
        {
            spawnInterval = Random.Range(1.0f, 5.0f);
            yield return new WaitForSeconds(spawnInterval);

            Instantiate(proj2, spawnPoints[Random.Range(0, spawnPoints.Length)]);
            AudioSource.PlayClipAtPoint(clip, transform.position, 1.5f);
        }
    }
}
