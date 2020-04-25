using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorItems : MonoBehaviour
{
    Color OriginalColor;
    Color nColor = new Color(0, 255, 0);

    void Start()
    {
        OriginalColor = this.GetComponent<Renderer>().material.color;
    }

    void OnMouseEnter() 
    {
        // GetComponent<Renderer>().material.color = Color.green;
        GetComponent<Renderer>().material.color = nColor;
    }

    void OnMouseExit() 
    {
        GetComponent<Renderer>().material.color = OriginalColor;
    }
}
