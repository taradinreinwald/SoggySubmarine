using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public void PlayGame()
    {
        // Starts the game by loading the correct scene.
        SceneManager.LoadScene("Game");
    }

    public void ExitGame()
    {
        // Quits the application
        Application.Quit();

        // DELETE THIS when we make our build! Will cause errors!
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
