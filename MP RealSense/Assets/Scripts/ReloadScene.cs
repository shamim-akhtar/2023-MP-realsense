using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadScene : MonoBehaviour
{
    public void Start()
    {
        Time.timeScale = 1.0f;
    }

    public void ReloadingScene()
    {
        // Get the current scene's build index
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        // Load the current scene by its build index
        SceneManager.LoadScene(currentSceneIndex);
    }
}
