using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    [SerializeField] Toggle toggler; //Important: Is set to unticked (OFF) in UNITY Toggle UI.
    public int DEFAULT_SETTING_MUSIC_TOGGLE = 0;

    //Music Volume Toggle Application - SoundManager.cs
    public void musicToggleStatus()
    {
        if(!PlayerPrefs.HasKey("MuteAudio")) 
        {
            PlayerPrefs.SetInt("MuteAudio", DEFAULT_SETTING_MUSIC_TOGGLE);
            PlayerPrefs.Save();
        }

        if (PlayerPrefs.GetInt("MuteAudio") == 1)
        {
            AudioListener.pause = true;
        } else {
            AudioListener.pause = false;
        }
          
        Debug.Log("Muted? " + PlayerPrefs.GetInt("MuteAudio")); //0 is MUTED, 1 is UNMUTED
    }

    public void changeMuteToggle()
    {
        AudioListener.pause = toggler.isOn;
        Debug.Log("Toggled Muted?" + toggler.isOn + " | " + PlayerPrefs.GetInt("MuteAudio") + " \n Updated!");
    }
}
