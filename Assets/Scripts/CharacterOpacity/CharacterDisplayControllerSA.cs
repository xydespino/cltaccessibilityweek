using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CharacterDisplayControllerSA : MonoBehaviour
{
    private GameObject textbox;
    public string currentCharacter;
    public string previousCharacter;
    public string currentEmotion;
    public string previousEmotion;
    private string[] textSplit;
    private TextMeshPro temp;
    private TMP_Text tempTMPText;
    private string tempString;

    public Sprite[] images;
    public GameObject Character1;
    public GameObject Character2;

    // Start is called before the first frame update
    void Start()
    {
        currentCharacter = "Nobody";
        previousCharacter = "Nobody";
        Character1.SetActive(false);
        Character2.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        textbox = GameObject.Find("DialogueText");

        if (textbox != null)
        {
            textSplit = textbox.GetComponent<TMP_Text>().text.Split(':');

            if (textSplit.Length > 0)
            {
                if (textSplit[0] == "VP" || textSplit[0] == "Allie" || textSplit[0] == "Allie(J)")
                {
                    currentCharacter = textSplit[0];
                    currentEmotion = textSplit[0];
                }
                else if (textSplit[0] != "" && textSplit[0] != "V" && textSplit[0] != "A" && textSplit[0] != "Al" && 
                textSplit[0] != "All" && textSplit[0] != "Alli" && textSplit[0] != "Allie" && textSplit[0] != "Allie("
                && textSplit[0] != "Allie(J")
                {
                    currentCharacter = "Nobody";
                    currentEmotion = textSplit[0];
                }
            }
            Debug.Log(currentCharacter);
            
            if (previousCharacter != currentCharacter)
            {
                if (currentCharacter == "Nobody")
                {
                    Character1.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 1f);
                    Character2.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                }
                else if (currentCharacter == "VP")
                {
                    Character1.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character2.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 1f);
                }
                else if (currentCharacter == "Allie" || currentCharacter == "Allie(J)")
                {
                    if (currentEmotion == "Allie(J)") 
                    {
                        Character1.GetComponent<SpriteRenderer>().sprite = images[0];
                    }
                    Character1.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Character2.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                }
                
                previousCharacter = currentCharacter;
                Character1.SetActive(true);
                Character2.SetActive(true);
            }
            else
            {
                Character1.SetActive(true); //Allie is 1st to speak
                Character1.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 1f);
            }
        }

        
    }
}

