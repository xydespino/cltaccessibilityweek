using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class new_credits : MonoBehaviour
{

    public void ReturnToCredits2()
    {
        SceneManager.LoadScene("Credits_Page(2)");
    } 

    public void ReturnToCredits1()
    {
        SceneManager.LoadScene("Credits_Page_End");
    } 

}