using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CharacterDisplayControllerADHD : MonoBehaviour
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
    public GameObject Character3;
    public GameObject Character4;


    // Start is called before the first frame update
    void Start()
    {
        Character1.SetActive(false);
        Character2.SetActive(false);
        Character3.SetActive(false);
        Character4.SetActive(false);
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
                if (textSplit[0] == "Rowan" || textSplit[0] == "Gloria" || textSplit[0] == "Camila" || textSplit[0] == "Arwah")
                {
                    currentCharacter = textSplit[0];
                }
            }
            if (previousCharacter != currentCharacter)
            {
                if (currentCharacter == "Rowan")
                {
                    Character1.transform.localScale = new Vector3(0.5f,0.5f,0);
                    Character1.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 1f);
                    Character2.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character2.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.25f);
                    Character3.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character3.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.25f);
                    Character4.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character4.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.25f);
                }
                if (currentCharacter == "Gloria")
                {
                    Character1.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character1.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.25f);
                    Character2.transform.localScale = new Vector3(0.5f,0.5f,0);
                    Character2.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 1f);
                    Character3.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character3.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.25f);
                    Character4.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character4.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.25f);
                }
                if (currentCharacter == "Camila")
                {
                    Character1.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character1.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.25f);
                    Character2.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character2.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.25f);
                    Character3.transform.localScale = new Vector3(0.5f,0.5f,0);
                    Character3.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 1f);
                    Character4.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character4.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.25f);
                }
                else if (currentCharacter == "Arwah")
                {
                    Character1.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character1.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.25f);
                    Character2.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character2.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.25f);
                    Character3.transform.localScale = new Vector3(0.3f,0.3f,0);
                    Character3.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.25f);
                    Character4.transform.localScale = new Vector3(0.5f,0.5f,0);
                    Character4.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 1f);
                }
                previousCharacter = currentCharacter;
                Character1.SetActive(true);
                Character2.SetActive(true);
                Character3.SetActive(true);
                Character4.SetActive(true);
            }
        }
    }
}
