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
    public float blinkDuration = 0.5f;

    private bool isBlinking = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Projectiles") == true)
        {
            score = score + 10;
            if (!isBlinking)
            {
                StartCoroutine(Blink());
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
