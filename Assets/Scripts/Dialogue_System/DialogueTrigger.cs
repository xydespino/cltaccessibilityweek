using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DialogueTrigger : MonoBehaviour
{
    [Header("Visual Dialogue Cue Info")]
    [SerializeField] private GameObject dialogueCue;

    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON;

    private bool playerInRange;
    private bool dialogueActive;

    private void Awake()
    {
        playerInRange = true; //OG: Was originally set to false.
        dialogueCue.SetActive(true);

        dialogueActive = false;

        if (SceneManager.GetActiveScene().name == "Story2-#1") {
            dialogueCue.SetActive(false);
            dialogueActive = true;

            DialogueManager.GetInstance().EnterDialogueMode(inkJSON);
        }
    }

    private void Update()
    {
        if (playerInRange && !dialogueActive)
        {
            dialogueCue.SetActive(true);
            //Debug.Log(inkJSON.text);

            if (Input.GetKeyDown("i")||Input.GetKeyDown("q"))
            {
                dialogueCue.SetActive(false);
                
                dialogueActive = true;
                DialogueManager.GetInstance().EnterDialogueMode(inkJSON);

            } else {
                return;
            }
        } else
        {
            return;
        }
    }

    /*
    private void OnTriggerEnter2D(Collider2D collider)
    {
        //Debug.Log("Trigger");
        
        
        if (collider.gameObject.tag == "Player")
        {
            playerInRange = true;
        }
        
    }


    private void OnTriggerExit2D(Collider2D collider)
    {

        //Debug.Log("No Trigger");
       
        
        if (collider.gameObject.tag == "Player")
        {
            playerInRange = false;
        }
        


        //playerInRange = false;
    }
    */

}
