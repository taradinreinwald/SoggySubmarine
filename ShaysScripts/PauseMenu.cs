using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    // create this object and attach the script to it.
    public GameObject PauseMenuUI;

    public bool GamePaused = false;

    void Start()
    {
        // If I didn't set the timeScale to 1, the game would freeze upon restart. This fixed it.
        Time.timeScale = 1f;

        // Making sure the game starts un-paused.
        GamePaused = false;
    }

    void Update()
    {
        // Uses the Escape key to pause the game.
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(GamePaused)
            {
                // The game will not pause if it's already paused.
                Resume();
            }
            else
            {
                // Otherwise, it will pause.
                Pause();
            }
        }
    }

    // Public so that it can be accessed through the "resume" button.
    public void Resume()
    {
        // Disables the pause menu.
        PauseMenuUI.SetActive(false);

        // Unfreezes the game.
        Time.timeScale = 1f;

        // Flags the game as being un-paused.
        GamePaused = false;
    }

   
    void Pause()
    {
        // Enables the pause menu.
        PauseMenuUI.SetActive(true);

        // Freezes the game.
        Time.timeScale = 0f;

        // Flags the game as being paused.
        GamePaused = true;
    }

    // These two functions are public so they can be accessed by their respective buttons.
    public void RestartGame()
    {
        //Reloads the scene.
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void QuitGame()
    {
        //This is for quitting if the game was built.
        Application.Quit();

        //This is for quitting in Play Mode within the editor. DELETE AFTER WE BUILD THE GAME.
        UnityEditor.EditorApplication.isPlaying = false;

        Debug.Log("Quitting game...");

    }
}
