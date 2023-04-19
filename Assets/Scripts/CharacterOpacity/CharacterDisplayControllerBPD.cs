using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CharacterDisplayControllerBPD : MonoBehaviour
{
    private GameObject textbox;
    public string currentCharacter;
    public string previousCharacter;
    private string[] textSplit;
    private TextMeshPro temp;
    private TMP_Text tempTMPText;
    private string tempString;

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
        //print(textbox);
        if (textbox != null)
        {
            
            textSplit = textbox.GetComponent<TMP_Text>().text.Split(':');
            if (textSplit.Length > 0)
            {
                if (textSplit[0] == "Narrator" || textSplit[0] == "Dr. Higashi" || textSplit[0] == "Dmitri")
                {
                    currentCharacter = textSplit[0];
                }
            }
            if (previousCharacter != currentCharacter)
            {
                if (currentCharacter == "Dr. Higashi")
                {
                    Character1.transform.localScale = new Vector3(0.5f,0.5f,0);
                    Character1.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 1f);
                    Character2.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character2.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.25f);
                }
                if (currentCharacter == "Dmitri")
                {
                    Character1.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character1.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.25f);
                    Character2.transform.localScale = new Vector3(0.5f,0.5f,0);
                    Character2.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 1f);
                }
                if (currentCharacter == "Narrator")
                {
                    Character1.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character1.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.25f);
                    Character2.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character2.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.25f);
                }
                previousCharacter = currentCharacter;
                Character1.SetActive(true);
                Character2.SetActive(true);
            }
        }
        
    }
}
