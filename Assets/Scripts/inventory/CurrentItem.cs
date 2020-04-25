using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CurrentItem : MonoBehaviour, IPointerClickHandler
{
    [HideInInspector]
    public int index;

    GameObject inventoryObj;
    Inventory inventory;

    void Start()
    {
        inventoryObj = GameObject.FindGameObjectWithTag("InventoryManager");
        inventory = inventoryObj.GetComponent<Inventory>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if(eventData.button == PointerEventData.InputButton.Right)
        {
            if (inventory.item[index].ID != 0)
            {
                GameObject dropedObj = Instantiate(Resources.Load<GameObject>(inventory.item[index].prefab));
                dropedObj.transform.position = Camera.main.transform.position + Camera.main.transform.forward*15;
                if (inventory.item[index].countItem > 1)
                {
                    inventory.item[index].countItem--;
                }
                else
                {
                    inventory.item[index] = new Item();
                }
                inventory.DisplayItems();
            }
            
        }
    }
}
