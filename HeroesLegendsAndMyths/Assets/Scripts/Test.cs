using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public GameObject tree;
    public GameObject prefab;
    public int x, y;

    void Start()
    {
        
    }

    void Update()
    {
        // if (Input.GetKeyDown(KeyCode.Y))
        // {
        //     tree.transform.position = transform.position + new Vector3(0 + x, 0 + y, 0);
        // }

        // else if (Input.GetKeyDown(KeyCode.I))
        // {
        //     Destroy(tree);
        // }

        if(Input.GetKeyDown(KeyCode.Y))
        {
            Destroy(tree);
            int i = 2;

            for (int c = 0; c < i; c++)
            {
                Instantiate(prefab);
                prefab.transform.position = new Vector3(-92, -1800, -517);
            }
        }
    }
}
