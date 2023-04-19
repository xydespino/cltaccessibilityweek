using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Image original;
    public Sprite[] backgrounds;
    public int[] switchScenes;

    private int linesRead = 0;
    private int currentBG = 0;

    // Chronic pain variables
    // private Story currentStory;
    private string currentText;
    
    private void Start()
    {


    }

    private void Update()
    {
        // Debug.Log("Background Switch" + DialogueManager.Continue());
    }

    public void incrementLines()
    {
        linesRead++;
        if (switchScenes.Length > currentBG) {
            if(linesRead == switchScenes[currentBG]){
                nextBackground();
            }
        }
    }
    public void nextBackground()
    {
        original.sprite = backgrounds[currentBG];
        currentBG++;
    }


    public void changeBackground(int i){
        original.sprite = backgrounds[i];
    }
}