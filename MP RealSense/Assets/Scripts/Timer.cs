using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private float currentTime = 30.0f;
    public Text timer;
    public GameObject timesUpMenu;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = 30.0f;
        timer.text = currentTime.ToString("F2") + "s";
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= Time.deltaTime;
        timer.text = currentTime.ToString("F2") + "s";

        if (currentTime <= 0.0f)
        {
            Time.timeScale = 0;
            timesUpMenu.SetActive(true);
        }
    }
}
