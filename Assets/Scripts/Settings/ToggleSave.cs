using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleSave : MonoBehaviour
{
    private new string name;
    private UnityEngine.UI.Toggle toggle;

    // Start is called before the first frame update
    void Start()
    {
        name = this.gameObject.name;
        toggle = this.gameObject.GetComponent<UnityEngine.UI.Toggle>();
        int savedValue = PlayerPrefs.GetInt(name);
        
        if (PlayerPrefs.HasKey(name))
        {
            //Toggle Config.: 1 == 1 => True (Toggle ON[ticked]) ~OR~ 0 == 1 => False (Toggle OFF[unticked])
            toggle.isOn = savedValue == 1 ? true : false;
            Debug.Log($"{name} = {PlayerPrefs.GetInt(name)}");
        }
    }

    public void SaveToggle()
    {
        bool toggleState = toggle.isOn;
        PlayerPrefs.SetInt(name, toggleState ? 1 : 0);
        PlayerPrefs.Save();
        Debug.Log($"{name} has been set to {toggleState} in PlayerPrefs.");
    }
}
