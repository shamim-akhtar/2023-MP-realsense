using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public GameObject deathMenu;

    // Update is called once per frame
    void Update()
    {
        if(playerHealth.health <= 0)
        {
            Time.timeScale = 0;
            deathMenu.SetActive(true);
        }
    }
}
