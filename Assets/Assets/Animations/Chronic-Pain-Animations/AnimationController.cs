using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AnimationController : MonoBehaviour
{
    private GameObject topLid;
    private GameObject bottomLid;
    private GameObject crashSound;

    private bool played1;
    private bool played2;
    private bool played3;
    private bool played4;
    private bool played5;
    private bool played6;

    private int linesRead = 0;

    private GameObject textbox;
    private string[] textSplit;

    private TextMeshPro temp;
    private TMP_Text tempTMPText;

    

    // Start is called before the first frame update
    void Start()
    {
        topLid = GameObject.Find("Eyelid_Top");
        bottomLid = GameObject.Find("Eyelid_Bottom");
        crashSound = GameObject.Find("Crash");
        //Car crash soundeffectsfactory. MediaFire. (2021, September 15). Retrieved March 10, 2023, from https://www.mediafire.com/file/cd9k5trccmyt9e0/ 
        
        played1 = false;
        played2 = false;
        played3 = false;
        played4 = false;
        played5 = false;
        played6 = false;
    }

    // Update is called once per frame
    void Update()
    {
        textbox = GameObject.Find("DialogueText");

        if (textbox != null)
        {
            textSplit = textbox.GetComponent<TMP_Text>().text.Split('h');

            if (textSplit.Length > 0)
            {

                if (textSplit[0] == "Gloria: I mig")
                {
                    // Playing the blink animation and crash sound when Gloria crashes
                    if(!played1) 
                    {
                        topLid.GetComponent<Animation>().Play("BlinkTop");
                        bottomLid.GetComponent<Animation>().Play("BlinkBottom");
                        crashSound.GetComponent<AudioSource>().Play(); 
                        played1 = true;
                    }
                }

                textSplit = textbox.GetComponent<TMP_Text>().text.Split('t');
                if (textSplit[0] == "Gloria: Hi Doc")
                {
                    // Playing opening animation once Gloria makes it to the doctor's office
                    if(!played2) 
                    {
                        topLid.GetComponent<Animation>().Play("OpenTop");
                        bottomLid.GetComponent<Animation>().Play("OpenBottom");
                        played2 = true;
                    }
                }

                textSplit = textbox.GetComponent<TMP_Text>().text.Split('w');
                if (textSplit[0] == "Gloria: Alright everyone, as mentioned in the previous lecture your assignment ")
                {
                    // Playing fainting animation when Gloria is giving the lecture
                    if (!played3) 
                    {
                        topLid.GetComponent<Animation>().Play("FaintTop");
                        bottomLid.GetComponent<Animation>().Play("FaintBottom");
                        played3 = true;
                    }
                }

                textSplit = textbox.GetComponent<TMP_Text>().text.Split('G');
                if (textSplit[0] == "Joseph: Hey ")
                {
                    // Playing opening animation once Gloria makes it to the cafeteria 
                    if (!played4)
                    {
                        topLid.GetComponent<Animation>().Play("OpenTop");
                        bottomLid.GetComponent<Animation>().Play("OpenBottom");
                        played4 = true;
                    }  
                }

                textSplit = textbox.GetComponent<TMP_Text>().text.Split('.');
                if (textSplit[0].Contains("my symptoms") || textSplit[0].Contains("Ignore symptoms"))
                {
                    // Covering characters during information scenes
                    if (!played5)
                    {
                        topLid.GetComponent<Animation>().Play("TransitionTop");
                        bottomLid.GetComponent<Animation>().Play("TransitionBottom");
                        played5 = true;
                    }  
                }

                if (textSplit[0].Contains("mediate their symptoms"))
                {
                    // Ending the transition
                    if (!played6)
                    {
                        topLid.GetComponent<Animation>().Play("QuickTop");
                        bottomLid.GetComponent<Animation>().Play("QuickBottom");
                        played6 = true;
                    }  
                }
            }
        }
    }
}

