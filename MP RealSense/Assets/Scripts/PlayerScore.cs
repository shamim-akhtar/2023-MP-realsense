using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
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
        }
    }
}
