using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

 

public class PauseMenu : MonoBehaviour
{
    public GameObject PauseMenuUI;
    public bool GamePaused;

 

    protected virtual void Awake()
    {
        // Flags the game as not paused
        GamePaused = false;
    }

 

    void Start()
    {
        // Time is normal when the game starts
        Time.timeScale = 1f;

 

        // Starts the game with the soundtrack playing
        AudioManager.Instance.PlayUnderwater();
    }

 

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(GamePaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

 

    public void Resume()
    {
        // Disables the pause menu
        PauseMenuUI.SetActive(false);

 

        // Unfreezes the game
        Time.timeScale = 1f;

 

        // Flags the game as not paused
        GamePaused = false;

 

        // Plays the game soundtrack
        AudioManager.Instance.PlayUnderwater();

 

        // Stops the pause menu music
        AudioManager.Instance.StopMainAndPause();
    }

 

    public void Pause()
    {
        // Enables the pause menu
        PauseMenuUI.SetActive(true);

 

        // Freezes the game
        Time.timeScale = 0f;

 

        // Flags the game as paused
        GamePaused = true;

 

        // Pauses the game soundtrack
        AudioManager.Instance.PauseUnderwater();

 

        // Plays the pause menu music
        AudioManager.Instance.PlayMainAndPause();
    }

 

    public void RestartGame()
    {
        // Reloads the scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

 

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quitting game...");
    }
}
