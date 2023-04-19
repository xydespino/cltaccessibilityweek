using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
    // Boolean to keep track of whether the game is paused
    public static bool isPaused = false;
    
    // Reference to the audio source that plays the music
    AudioSource audioSource;

    private void Start()
    {
        // Find the audio source in the scene
        audioSource = FindObjectOfType<AudioSource>();
    }

    // This method is called when the UI button is clicked
    public void OnPauseButtonClicked()
    {
        // Toggle the pause state
        isPaused = !isPaused;

        // If the game is paused, set the timescale to 0 to freeze everything
        if (isPaused)
        {
            Time.timeScale = 0;
            // Pause the music
            audioSource.Pause();
        }
        // Otherwise, set the timescale back to 1 to resume normal gameplay
        else
        {
            Time.timeScale = 1;
            // Resume the music
            audioSource.UnPause();
        }
    }
}