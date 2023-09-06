using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.SceneManagement;

public class QuitGame : MonoBehaviour
{
    public void Quit()
    {
        // Unload the current scene
        SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene().buildIndex);

        // Load the target scene
        SceneManager.LoadScene("MenuScene");

    }
}
