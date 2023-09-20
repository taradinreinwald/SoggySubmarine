using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    int _score;
    [SerializeField] private PauseMenu pause;
    [SerializeField] private Scroller background;
    [SerializeField] private ScoreTracker scoreTracker;
    [SerializeField] private ObjectSpawner spawner;

    public static GameManager Instance
    {
        get
        {
            return instance;
        }
    }

    void Awake()
    {
        // Keeps the correct instance from being destroyed on load
        if (instance == null)
        {
            instance = this;
           // DontDestroyOnLoad(gameObject);
        }
        else
        {
            // If there are multiple instances, destroy this one
            Destroy(this);
        }
    }
    public void IncreaseScore(int value)
    {
        _score += value;
        AudioManager.Instance.PlayPickup();
        scoreTracker.updateScore(string.Format(": {0}", _score));
        Debug.Log(string.Format(": {0}", _score));
    }

    public void DeadPauseControl()
    {
        pause.DeadPause();
    }
    public void StopScrolling()
    {
        background.Stop();
        spawner.StopAll();
    }

}
