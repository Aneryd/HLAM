using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Item : MonoBehaviour
{
    public string name;
    public int ID;
    public int countItem;
    public bool isStackable;
    [Multiline(5)]
    public string descriptionItem;
    public string pathIcon;
    public string prefab;
    public UnityEvent customEvent;
}
