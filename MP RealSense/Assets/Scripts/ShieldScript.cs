using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldScript : MonoBehaviour
{
    [HideInInspector]
    public int score = 0;

    public Light lightComponent;
    public Color normalColor;
    public Color blinkColor;
    public float blinkDuration = 0.01f;

    public AudioSource audioSource;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Proj1") == true)
        {
            score = score + 10;
            StopCoroutine(Blink());
                audioSource.Play();
                StartCoroutine(Blink());
        }
        else if(collision.gameObject.CompareTag("Proj2") == true)
        {
            score = score + 20;
                audioSource.Play();
                StopCoroutine(Blink());
                StartCoroutine(Blink());
        }
        else if (collision.gameObject.CompareTag("Proj3") == true)
        {
            score = score + 50;
            audioSource.Play();
            StopCoroutine(Blink());
            StartCoroutine(Blink());
        }
        else if (collision.gameObject.CompareTag("Proj4") == true)
        {
            score = score + 30;
            audioSource.Play();
            StopCoroutine(Blink());
            StartCoroutine(Blink());
        }
        else
        {
            lightComponent.color = normalColor;
        }
    }

    IEnumerator Blink()
    {
        lightComponent.color = blinkColor;
        yield return new WaitForSeconds(blinkDuration);

        lightComponent.color = normalColor;
        yield return new WaitForSeconds(blinkDuration);
    }
}
