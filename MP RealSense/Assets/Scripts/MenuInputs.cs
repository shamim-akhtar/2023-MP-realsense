using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.SceneManagement;

public class MenuInputs : MonoBehaviour
{
    public void StartButtonPressed()
    {
        // Unload the current scene
        SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene().buildIndex);

        // Load the target scene
        SceneManager.LoadScene("HandTrackGame");

        Time.timeScale = 1;
    }

}
