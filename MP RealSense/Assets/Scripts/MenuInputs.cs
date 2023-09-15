using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.SceneManagement;

public class MenuInputs : MonoBehaviour
{
    public void EndlessButtonPressed()
    {
        // Unload the current scene
        SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene().buildIndex);

        // Load the target scene
        SceneManager.LoadScene("HandTrackGame 1");

        Time.timeScale = 1;
    }

    public void TimedButtonPressed()
    {
        SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene().buildIndex);

        SceneManager.LoadScene("HandTrackGame 2");

        Time.timeScale = 1;
    }

}
