using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    private int health = 14;
    public Text healthText;

    private void Start()
    {
        healthText.text = "Health: 15";
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Projectiles") == true)
        {
            healthText.text = "Health: " + health--;
        }
    }
}
