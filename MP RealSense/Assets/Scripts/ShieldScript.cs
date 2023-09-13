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
    public float blinkDuration = 0.1f;

    public AudioSource audioSource;

    private bool isBlinking = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Proj1") == true)
        {
            score = score + 10;
            if (!isBlinking)
            {
                StartCoroutine(Blink());
                audioSource.Play();
            }
        }
        else if(collision.gameObject.CompareTag("Proj2") == true)
        {
            score = score + 20;
            if (!isBlinking)
            {
                StartCoroutine(Blink());
                audioSource.Play();
            }
        }
        else
        {
            isBlinking = false;
            lightComponent.color = normalColor;
        }
    }

    IEnumerator Blink()
    {
        isBlinking = true;

        lightComponent.color = blinkColor;
        yield return new WaitForSeconds(blinkDuration);

        lightComponent.color = normalColor;
        yield return new WaitForSeconds(blinkDuration);

        isBlinking = false;
    }
}
