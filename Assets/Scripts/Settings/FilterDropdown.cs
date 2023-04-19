using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class FilterDropdown : MonoBehaviour
{
    private int selectedOption = 0; // Initialize the selected option to 0.
    private static int holdOption;

    void Start()
    {
        //get the value from drop down, it's like 0, 1, 2, 3
        var dropdown = transform.GetComponent<Dropdown>();
        
        // Retrieve the selected option from PlayerPrefs if it exists.
        if (PlayerPrefs.HasKey("selectedOption"))
        {
            selectedOption = PlayerPrefs.GetInt("selectedOption");
            dropdown.value = selectedOption;
        }

        //make change for dropdown by different choice, detail in function :void DropdownItemSelected(Dropdown d)
        DropdownItemSelected(dropdown);
        holdOption = dropdown.value;
        //apply the change 
        dropdown.onValueChanged.AddListener(delegate {DropdownItemSelected(dropdown);});
    }
    //New method from keenan
    public void dropdownStatus()
    {
        //the colorblind is apply on the main camera
        Camera myCamera=Camera.main;

        var x=myCamera.GetComponent<Wilberforce.Colorblind>();

        // Retrieve the selected option from PlayerPrefs if it exists.
        if (PlayerPrefs.HasKey("selectedOption"))
        {
            selectedOption = PlayerPrefs.GetInt("selectedOption");
            x.Type=selectedOption;
        }

        PlayerPrefs.SetInt("selectedOption", selectedOption);
    }



    void DropdownItemSelected(Dropdown d){

        //the colorblind is apply on the main camera
        Camera myCamera=Camera.main;

        
        var x=myCamera.GetComponent<Wilberforce.Colorblind>();

        //the type in colorblind script is by number0, 1, 2, 3, 
        //so apply the numbers to dropdown after the dropdown choice changes
        x.Type=d.value;

        holdOption = d.value;
        

        PlayerPrefs.SetInt("selectedOption", holdOption);
    }

    
}