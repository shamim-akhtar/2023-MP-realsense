using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseAndResumeGame : MonoBehaviour
{
    public void Pause()
    {
        Time.timeScale = 0;
    }

    public void Resume()
    {
        Time.timeScale = 1;
    }

    public void Quit()
    {
        SceneManager.LoadScene("MenuScene");
    }
}
