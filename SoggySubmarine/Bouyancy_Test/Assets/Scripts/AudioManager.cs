using UnityEngine;


//AudioManager.Instance.[sound functiom]();
public class AudioManager : MonoBehaviour
{
    // Singleton instance
    private static AudioManager instance;

    // Various sound effects to be included in the game
    [SerializeField] private AudioSource explosion;
    [SerializeField] private AudioSource mainAndPause;
    [SerializeField] private AudioSource pickup;
    [SerializeField] private AudioSource underwater;

    // Public property for access to the singleton instance
    public static AudioManager Instance
    {
        get
        {
            return instance;
        }
    }

    void Awake()
    {
        // Keeps the correct instance from being destroyed on load
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            // If there are multiple instances, destroy this one
            Destroy(this);
        }
    }

    // Explosion sound effect
    public void PlayExplosion()
    {
        explosion.Play();
    }

    // Main/pause music
    public void PlayMainAndPause()
    {
        mainAndPause.Play();
    }

    public void StopMainAndPause()
    {
        mainAndPause.Stop();
    }

    // Pickup sound effect
    public void PlayPickup()
    {
        pickup.Play();
    }

    // Underwater sound effect (background "music" for the game)
    public void PlayUnderwater()
    {
        underwater.Play();
    }

    public void PauseUnderwater()
    {
        underwater.Pause();
    }
}
