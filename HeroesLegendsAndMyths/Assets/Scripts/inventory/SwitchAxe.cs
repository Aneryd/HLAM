using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchAxe : MonoBehaviour
{
    public void switchAxe(GameObject axe)
    {
        axe.SetActive(!axe.activeSelf);
    }
}
