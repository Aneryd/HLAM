using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pr : MonoBehaviour
{
    public Texture2D CrossHair;

    void OnGUI()
    {
        GUI.DrawTexture(new Rect(Screen.width / 2, Screen.height / 2, 10, 10), CrossHair);
    }
}
