using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [HideInInspector]
    public int health = 10;

    public Text healthText;
    public AudioClip damageClip;
    public AudioClip disabled;
    public Color blinkColor;
    public float disableDuration = 2.0f;

    GameObject shield;
    ShieldScript shieldScript;

    private void Start()
    {
        shield = GameObject.Find("Shield");
        shieldScript = shield.GetComponent<ShieldScript>();
        health = 10;
        healthText.text = "Health: " + health;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Proj1") == true)
        {
            health--;
            healthText.text = "Health: " + health;

            AudioSource.PlayClipAtPoint(damageClip, transform.position, 1f);
        }
        else if (collision.gameObject.CompareTag("Proj2") == true)
        {
            health -= 2;
            healthText.text = "Health: " + health;

            AudioSource.PlayClipAtPoint(damageClip, transform.position, 1f);
        }
        else if (collision.gameObject.CompareTag("Proj3") == true)
        {
            health -= 5;
            healthText.text = "Health: " + health;

            AudioSource.PlayClipAtPoint(damageClip, transform.position, 1f);
        }
        else if (collision.gameObject.CompareTag("Proj4") == true)
        {
            health -= 1;
            healthText.text = "Health: " + health;

            AudioSource.PlayClipAtPoint(disabled, transform.position, 1f);
            StartCoroutine(Disable());
        }
    }

    IEnumerator Disable()
    {
        shield.SetActive(false);
        yield return new WaitForSeconds(disableDuration);
        shield.SetActive(true);
    }
}
