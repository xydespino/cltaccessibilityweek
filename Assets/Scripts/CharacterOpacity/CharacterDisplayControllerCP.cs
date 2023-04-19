using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CharacterDisplayControllerCP : MonoBehaviour
{
    private GameObject textbox;
    public string previousCharacter;
    public string currentCharacter;
    public string previousEmotion;
    public string currentEmotion;
    private string[] textSplit;
    private string[] textSplitEmotion;
    private TextMeshPro temp;
    private TMP_Text tempTMPText;
    private string tempString;
    
    public Sprite[] images;
    public GameObject Character1;
    public GameObject Character2;
    public GameObject Character3;
    public GameObject Character4;
    public GameObject Character5;
    public GameObject Character6;
    public GameObject Character7;
    public GameObject Character8;
    public GameObject Character9;


    // Start is called before the first frame update
    void Start()
    {
        Character1.SetActive(false);
        Character2.SetActive(false);
        Character3.SetActive(false);
        Character4.SetActive(false);
        Character5.SetActive(false);
        Character6.SetActive(false);
        Character7.SetActive(false);
        Character8.SetActive(false);
        Character9.SetActive(false);
    }

    public void charactersPresent(string characters){

        // Setting all characters to not showing
        Character1.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
        Character2.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
        Character3.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
        Character4.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
        Character5.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
        Character6.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
        Character7.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
        Character8.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
        Character9.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);

        
        // Showing every character included in the characters string
        foreach (char x in characters){
            Debug.Log("characters present: "+ x);
            if (x.CompareTo('1') == 0) {
            Character1.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 1f);
            }
            if (x.CompareTo('2') == 0) {
            Character2.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 1f);
            }
            if (x.CompareTo('3') == 0) {
            Character3.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 1f);
            }
            if (x.CompareTo('4') == 0) {
            Character4.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 1f);
            }
            if (x.CompareTo('5') == 0){
            Character5.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 1f);
            }
            if (x.CompareTo('6') == 0) {
            Character6.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 1f);
            }
            if (x.CompareTo('7') == 0) {
            Character7.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 1f);
            }
            if (x.CompareTo('8') == 0) {
            Character8.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 1f);
            }
            if (x.CompareTo('9') == 0) {
            Character9.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 1f);
            }
        } 

        // Making the changes active
        Character1.SetActive(true);
        Character2.SetActive(true);
        Character3.SetActive(true);
        Character4.SetActive(true);
        Character5.SetActive(true);
        Character6.SetActive(true);
        Character7.SetActive(true);
        Character8.SetActive(true);
        Character9.SetActive(true);
    }

    public void notTalking(){

        // Default to make all characters not currently speaking
        Character1.transform.localScale = new Vector3(0.3f,0.3f,0);
        Character2.transform.localScale = new Vector3(0.3f,0.3f,0);
        Character3.transform.localScale = new Vector3(0.3f,0.3f,0);
        Character4.transform.localScale = new Vector3(0.3f,0.3f,0);
        Character5.transform.localScale = new Vector3(0.3f,0.3f,0);
        Character6.transform.localScale = new Vector3(0.3f,0.3f,0);
        Character7.transform.localScale = new Vector3(0.3f,0.3f,0);
        Character8.transform.localScale = new Vector3(0.3f,0.3f,0);
        Character9.transform.localScale = new Vector3(0.3f,0.3f,0);

        Character1.SetActive(true);
        Character2.SetActive(true);
        Character3.SetActive(true);
        Character4.SetActive(true);
        Character5.SetActive(true);
        Character6.SetActive(true);
        Character7.SetActive(true);
        Character8.SetActive(true);
        Character9.SetActive(true);
    }

    public void showCharacter(string character, int emotion){
        notTalking();

        // Getting character, choosing the appropriate emotion, 
        // and showing they are currently speaking by increasing by increasing their size
        if(character == "Gloria"){
            Character1.GetComponent<SpriteRenderer>().sprite = images[emotion];
            Character1.transform.localScale = new Vector3(0.4f,0.4f,0);
        } else if (character == "Emily"){
            Character2.GetComponent<SpriteRenderer>().sprite = images[emotion];
            Character2.transform.localScale = new Vector3(0.4f,0.4f,0);
        } else if (character == "Marsha"){
            Character3.GetComponent<SpriteRenderer>().sprite = images[emotion];
            Character3.transform.localScale = new Vector3(0.4f,0.4f,0);
        } else if (character == "Glenn"){
            Character4.GetComponent<SpriteRenderer>().sprite = images[emotion];
            Character4.transform.localScale = new Vector3(0.4f,0.4f,0);
        } else if (character == "George"){
            Character5.transform.localScale = new Vector3(0.4f,0.4f,0);
        } else if (character == "Joseph"){
            Character6.transform.localScale = new Vector3(0.4f,0.4f,0);
        } else if (character == "Julie"){
            Character7.transform.localScale = new Vector3(0.4f,0.4f,0);
        } else if (character == "Sonya"){
            Character8.transform.localScale = new Vector3(0.4f,0.4f,0);
        } else if (character == "Henry"){
            Character9.GetComponent<SpriteRenderer>().sprite = images[emotion];
            Character9.transform.localScale = new Vector3(0.4f,0.4f,0);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}