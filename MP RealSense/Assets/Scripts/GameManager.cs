using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text scoreText;
    public Text endScoreText;
    public Text deathScoreText;

    ShieldScript shieldScript;

    void Start()
    {
        GameObject shield = GameObject.Find("Shield");
        shieldScript = shield.GetComponent<ShieldScript>();
        shieldScript.score = 0;
    }

    private void Update()
    {
        scoreText.text = "Score: " + shieldScript.score;
        endScoreText.text = scoreText.text;
        deathScoreText.text = scoreText.text;
    }
}
