using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    int health = 15;
    Text healthText;

    public void LoseHealth()
    {
        health -= 1;
        healthText.text = "Score: " + health;
    }
}
