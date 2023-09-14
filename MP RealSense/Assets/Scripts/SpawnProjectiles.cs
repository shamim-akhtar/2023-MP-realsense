using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnProjectiles : MonoBehaviour
{
    public GameObject proj1;
    public GameObject proj2;
    public GameObject proj3;
    public GameObject proj4;
    public Transform[] spawnPoints;
    public AudioClip blaster;
    public AudioClip energyBall;
    public AudioClip speedUp;
    public Text speedText;
    float spawnInterval;
    float spawnCounter = 0f;
    public float speedMulti = 1.0f;

    // Start is called before the first frame update
    public void Start()
    {
        spawnCounter = 0f;
        StartCoroutine(IntervalAction());
        StartCoroutine(Timer());
        StartCoroutine(Spawn());
        speedMulti = 1.0f;
        speedText.text = "Speed: " + speedMulti + "x";
    }

    private void Update()
    {
        if(spawnCounter == 2.0f)
        {
            //20s mark
            StartCoroutine(Spawn2());
            spawnCounter += 1.0f;
        }
        else if (spawnCounter == 4.0f)
        {
            //40s mark
            StartCoroutine(Spawn3());
            spawnCounter += 1.0f;
        }
        else if (spawnCounter == 6.0f)
        {
            //60s mark
            StartCoroutine(Spawn4());
            spawnCounter += 1.0f;
        }

        if (speedMulti >= 1.5f)
        {
            speedMulti = 1.5f;
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
            AudioSource.PlayClipAtPoint(blaster, transform.position, 1.5f);
        }
    }

    IEnumerator Spawn2()
    {
        while (true)
        {
            yield return new WaitForSeconds(5.0f);

            Instantiate(proj2, spawnPoints[Random.Range(0, spawnPoints.Length)]);
            AudioSource.PlayClipAtPoint(blaster, transform.position, 1.5f);
        }
    }

    IEnumerator Spawn3()
    {
        while (true)
        {
            yield return new WaitForSeconds(13.0f);
            AudioSource.PlayClipAtPoint(energyBall, transform.position, 3.5f);
            yield return new WaitForSeconds(2.0f);
            Instantiate(proj3, spawnPoints[Random.Range(0, spawnPoints.Length)]);
        }
    }

    IEnumerator Spawn4()
    {
        while (true)
        {
            yield return new WaitForSeconds(13.0f);
            AudioSource.PlayClipAtPoint(energyBall, transform.position, 3.5f);
            yield return new WaitForSeconds(2.0f);
            Instantiate(proj4, spawnPoints[Random.Range(0, spawnPoints.Length)]);
        }
    }

    IEnumerator IntervalAction()
    {
        while (true)
        {
            speedMulti += 0.1f;
            speedText.text = "Speed: " + speedMulti + "x";
            AudioSource.PlayClipAtPoint(speedUp, this.transform.position);
            // Wait for the specified interval before running the code again
            yield return new WaitForSeconds(30f);
        }
    }
}
