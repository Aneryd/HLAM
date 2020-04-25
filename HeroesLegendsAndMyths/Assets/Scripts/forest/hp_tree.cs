using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hp_tree : MonoBehaviour
{
    public float hp;
    public GameObject[] Spawn;

    
    void Update()
    {
        for (int i = 0; i < Spawn.Length; i++)
        {
            Vector3 v3 = new Vector3(transform.position.x, transform.position.y + (Spawn[i].transform.localScale.y + i + i), transform.position.z);
            Instantiate(Spawn[i], v3, Quaternion.identity);
        }
        Destroy(this.gameObject);
    }
}
