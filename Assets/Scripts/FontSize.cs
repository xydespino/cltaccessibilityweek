using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FontSize : MonoBehaviour
{
   public Text text;

    // Update is called once per frame
    public void TextScale(Slider slider)
    {
        text.fontSize = (int)slider.value;
    }
}
