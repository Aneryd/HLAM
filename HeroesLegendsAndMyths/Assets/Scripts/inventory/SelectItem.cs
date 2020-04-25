using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectItem : MonoBehaviour
{
    public Inventory inventory;
    public GameObject inv;

    bool select;

    

    void Start()
    {
        inventory = inv.GetComponent<Inventory>();
        select = inventory.axeC;
    }

    void Update()
    {
        Debug.Log("1");
        Debug.Log("2");
        Debug.Log(select);
    }
}
