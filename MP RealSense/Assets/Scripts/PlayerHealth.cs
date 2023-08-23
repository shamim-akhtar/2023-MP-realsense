using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [HideInInspector]
    public int health;
    public Text healthText;

    public void LoseHealth()
    {
        healthText.text = "Health: " + health--;
    }
}
