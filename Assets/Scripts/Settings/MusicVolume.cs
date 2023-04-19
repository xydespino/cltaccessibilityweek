using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicVolume : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    public float DEFAULT_SETTINGS_AUDIO_VOLUME = 1;

    
    public void audioVolumeStatus()
    {
        if(!PlayerPrefs.HasKey("AudioVolume"))
        {
            PlayerPrefs.SetFloat("AudioVolume", DEFAULT_SETTINGS_AUDIO_VOLUME);
            PlayerPrefs.Save();
        }
        
        Debug.Log("Volume Set to: '" + PlayerPrefs.GetFloat("AudioVolume") * 100 + "'%");
        AudioListener.volume = PlayerPrefs.GetFloat("AudioVolume");
    }

    //Music Volume Audio Application - Slider; SliderSave.cs
    public void ChangeVolume()
    {
        //Debug.Log("Volume Slider: " + volumeSlider.value);
        AudioListener.volume = volumeSlider.value;
    }
}
