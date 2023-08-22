using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyProjectiles : MonoBehaviour
{
    public GameObject projectile;
    string targetTag = "Destroyer";
    public PlayerHealth playerHealth;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(targetTag) == true)
        {
            Destroy(gameObject);
            playerHealth.LoseHealth();
            Debug.Log("Player takes damage");
        }
    }
}
