using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    [HideInInspector]
    public List<Item> item;

    public GameObject cellContainer;
    public KeyCode showInventory;
    public KeyCode takeButton;

    public bool axeC;

    public ControlPers player;

    void Start()
    {
        item = new List<Item>();

        cellContainer.SetActive(false);
        for (int i = 0; i < cellContainer.transform.childCount; i++)
        {
            cellContainer.transform.GetChild(i).GetComponent<CurrentItem>().index = i;
        }

        for (int i = 0; i < cellContainer.transform.childCount; i++)
        {
            item.Add(new Item());
        }
    }

    void Update()
    {
        ToggleInventory();

        if(Input.GetKeyDown(takeButton))
        {
            Ray ray = Camera.main.ScreenPointToRay(new Vector2(Screen.width/2, Screen.height/2)); // Когда есть прицел и экран делиться по полам
            // Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); //Когда наводишь мышью
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit))
            {
                if(hit.collider.GetComponent<Item>())
                {
                   AddItem(hit.collider.GetComponent<Item>());
                }
            }
        }
    }

    void AddItem(Item currentItem)
    {
        if (currentItem.isStackable)
        {
            AddStackable(currentItem);
        }
        else
        {
            AddUnStackable(currentItem);
        }
    }

    void AddUnStackable(Item currentItem)
    {
        for(int i = 0; i < item.Count; i++)
        {
            if(item[i].ID == 0)
            {
                item[i] = currentItem;
                item[i].countItem = 1;
                DisplayItems();
                Destroy(currentItem.gameObject);

                if(item[i].ID == 3)
                {
                    axeC = true;
                }

                break;
            } 
        }
    }

    void AddStackable(Item currentItem)
    {
        for (int i = 0; i < item.Count; i++)
        {
            if (item[i].ID == currentItem.ID)
            {
                item[i].countItem++;
                DisplayItems();
                Destroy(currentItem.gameObject);
                return;
            }
        }
        AddUnStackable(currentItem);
    }

    void ToggleInventory()
    {
        if(Input.GetKeyDown(showInventory))
       {
           if(cellContainer.activeSelf)
           {
                cellContainer.SetActive(false);
                player.enabled = true;
                Time.timeScale = 1;
                Cursor.visible = false;
                Screen.lockCursor = true;
           }
           else
           {
               cellContainer.SetActive(true);
               player.enabled = false;
               Cursor.visible = true;
               Cursor.lockState = CursorLockMode.None;
               Time.timeScale = 0;
           }
       }
    }

    public void DisplayItems()
    {
        for (int i = 0; i < item.Count; i++)
        {
            Transform cell = cellContainer.transform.GetChild(i);
            Transform icon = cell.GetChild(0);
            Transform count = icon.GetChild(0);

            Text txt = count.GetComponent<Text>();
            Image img = icon.GetComponent<Image>();

            if(item[i].ID != 0)
            {
                img.enabled = true;
                img.sprite = Resources.Load<Sprite>(item[i].pathIcon);
                if (item[i].countItem > 1)
                {
                    txt.text = item[i].countItem.ToString();
                } 
            }
            else
            {
                img.enabled = false;
                img.sprite = null;
                txt.text = null;
            }
        }
    }
}
