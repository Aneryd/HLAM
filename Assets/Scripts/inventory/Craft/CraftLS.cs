using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftLS : MonoBehaviour
{
    // public Inventory myInv;
    // public string[] recipes;
    // public Transform buttonHolder;

    // public void checkInv()
    // {
    //     for (int i = 0; i < buttonHolder.childCount; i++)
    //     {
    //         Destroy(buttonHolder.GetChild(i).gameObject);
    //     }

    //     for (int i = 0; i < recipes.Length; i++)
    //     {
    //         string[] parts = recipes[i].Split(' ');
    //         int[] elements = new int[parts.Length];
            
    //         for (int j = 0; j < parts.Length; j++)
    //         {
    //             elements[j] = int.Parse(parts[j]);
    //         }

    //         bool recipeExist = true;

    //         for (int j = 0; j < (elements.Length - 2)/2; j++)
    //         {
    //             if (!playerHaveItem(elements[j*2], elements[j*2+1]))
    //             {
    //                 recipeExist = false;
    //             }
    //         }

    //         if (recipeExist)
    //         {
    //             GamObject newButton = Instantiate((GamObject)Resources.Load("CLButton"));
    //             newButton.transform.SetParent(button.Holder);
    //             newButton.GetComponent<ACLButton>().itemID = elements[elements.Length - 2];
    //             newButton.GetComponent<ACLButton>().itemAmmount = elements[elements.Length - 1];
    //             newButton.GetComponent<ACLButton>().myInv = myInv;
    //             newButton.transform.GetChild(0).GetComponent<RawImage>().texture = Item.lib.Images[elements[elements.Length - 2]];
    //             newButton.transform.GetChild(1).GetComponent<Text>().text = elements[elements.Length - 1] + " " + Item.lib.Names[elements[elements.Length - 2]];
    //             newButton.GetComponent<ACLButton>().recipeID = i;
    //             newButton.GetComponent<ACLButton>().myCraft = this;
    //         }
    //     }
    // }
    
    // public void Craft()
    // {
    //     string[] parts = recipes[recipeID].Split(' ');
    //     int[] elements = new int[parts.Length];
        
    //     for (int j = 0; j < parts.Length; j++)
    //     {
    //         elements[j] = int.Parse(parts[j]);
    //     }

    //     for (int i = 0; i < (elements.Length - 2)/2; i++)
    //     {
    //         myInv.removeItems(elements[i*2], elements[i*2 + 1]);
    //     }

    //     myInv.Redraw();
    // }

    // public void PlayerHaveItems()
    // {
    //     int playerHaveAmmount = 0;

    //     for (int i = 0; i < myInv.items.Length; i++)
    //     {
    //         if (myInv.items[i].ID = ID)
    //         {
    //             playerHaveAmmount + myInv.items[i].stack;
    //         }
    //     }
        
    //     return playerHaveAmmount > count;
    // }
}
