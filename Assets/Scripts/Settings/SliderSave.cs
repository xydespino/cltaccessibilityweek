using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderSave : MonoBehaviour
{
    private UnityEngine.UI.Slider slider; //Slider Controller
    private new string settingsName; // Settings Name in respect to Game Object interaction.


    // Start is called before the first frame update
    void Start()
    {
        settingsName = this.gameObject.name;
        slider = this.gameObject.GetComponent<UnityEngine.UI.Slider>(); 
        
        if (PlayerPrefs.HasKey(settingsName))
        {
            slider.value = PlayerPrefs.GetFloat(settingsName);
            //Debug.Log($"{settingsName} = {PlayerPrefs.GetFloat(settingsName)}");
        }
    }

    // Based on user input this is updated to reflect new settings configuration into their Player Prefs.
    public void SaveSlider()
    {
        PlayerPrefs.SetFloat(settingsName, slider.value);
        PlayerPrefs.Save();
        //Debug.Log($"{settingsName} has been set to {slider.value} in PlayerPrefs.");
    }
}
