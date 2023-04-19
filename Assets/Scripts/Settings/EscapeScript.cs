using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EscapeScript : MonoBehaviour
{
    [SerializeField] private GameObject settingsPanel;
    [SerializeField] private GameObject canvas;

 
    private bool settingsActive = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            settingsActive = !settingsActive;

            settingsPanel.SetActive(settingsActive);
            canvas.SetActive(!settingsActive);
        }
    }
}

