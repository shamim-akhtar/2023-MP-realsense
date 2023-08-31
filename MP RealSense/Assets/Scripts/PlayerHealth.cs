using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [HideInInspector]
    public int health = 5;

    public Text healthText;
    public AudioClip damageClip;


    private void Start()
    {
        healthText.text = "Health: " + health;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Projectiles") == true)
        {
            health--;
            healthText.text = "Health: " + health;

            AudioSource.PlayClipAtPoint(damageClip, transform.position, 1f);
        }
    }
}
