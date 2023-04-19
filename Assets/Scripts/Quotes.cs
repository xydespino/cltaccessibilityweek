using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Quotes : MonoBehaviour
{
    /*
     Load scene
     */
    string[] sentences;
    byte count;
    TMP_Text TMP;
    float time;
    float waitTime;
    Color TMPColor;
    bool fadingOut = false;
    const byte maxColorValue = 1;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Called start");
        time = 0;
        waitTime = 2f;
        sentences = new string[]
        {
            "sentence 1", "sentences 2", "sentence 3", "sentence 4", "sentence 5"
        };
        TMP = this.gameObject.transform.GetChild(0).transform.GetChild(0).GetComponent<TMP_Text>();
        TMP.text = sentences[Random.Range(0, sentences.Length - 1)];
        TMPColor = new Color(TMP.color.r, TMP.color.g, TMP.color.b, TMP.color.a);
        TMP.color =  new Color(TMPColor.r, TMPColor.g, TMPColor.b, 0.1f);
    }

    // Update is called once per frame
    void Update()
    {
        if(TMP.alpha < 1f && !fadingOut)
        {
            time += Time.deltaTime;
            StartCoroutine(FadeTextToFullAlpha(1f, TMP));
        }
        else if (Input.anyKey)
        {
            StartCoroutine(FadeTextToZeroAlpha(4f, TMP));
        }
    }

    public IEnumerator FadeTextToFullAlpha(float t, TMP_Text i)
    {
        i.color = new Color(i.color.r, i.color.g, i.color.b, 0.1f);
        while (i.color.a < 1.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a + (Time.deltaTime / t));
            yield return null;
        }
    }

    public IEnumerator FadeTextToZeroAlpha(float t, TMP_Text i)
    {
        fadingOut = true;
        i.color = new Color(i.color.r, i.color.g, i.color.b, 1f);
        while (i.color.a > 0.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, (i.color.a - (Time.deltaTime / t)));
            yield return null;
        }
        Destroy(this.gameObject);
        Debug.Log("Quotes object deleted");
    }
}
