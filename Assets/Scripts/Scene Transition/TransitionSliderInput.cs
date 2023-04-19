using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionSliderInput : MonoBehaviour
{
    public GameObject transition, quoteObject;
    private bool transitionActive;

    // Start is called before the first frame update
    void Start()
    {
        transitionActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!transitionActive)
        {
            if (Input.GetKeyDown(KeyCode.E) && !transition.GetComponent<MoveSlider>().enabled)
            {
                transition.GetComponent<MoveSlider>().ResetVars();
                transition.GetComponent<MoveSlider>().enabled = true;
            }
            if (transition.GetComponent<MoveSlider>().IsFinishedLerp())
            {
                transition.GetComponent<MoveSlider>().enabled = false;
                Instantiate(quoteObject);
                transitionActive = true;
            }
        }
    }

}
