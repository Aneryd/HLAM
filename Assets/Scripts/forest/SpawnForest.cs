using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnForest : MonoBehaviour
{
    public Transform spawnZone;
    public GameObject Tree;
    public int sum;

    float maxX;
    float minX;
    float maxZ;
    float minZ;

    int y = 0;

    void Start()
    {
        maxX = spawnZone.position.x + spawnZone.localScale.x / 2;
        minX = spawnZone.position.x - spawnZone.localScale.x / 2;

        maxZ = spawnZone.position.z + spawnZone.localScale.z / 2;
        minZ = spawnZone.position.z - spawnZone.localScale.z / 2;
    }

    void Update()
    {    
        if (y != sum)
        {
            for (int i = 0; i < sum; i++)
            {
                Vector3 spawnPos = new Vector3(Random.Range(minX, maxX), spawnZone.position.y, Random.Range(minZ, maxZ));
                Instantiate(Tree, spawnPos, Quaternion.identity);
                // i++;
                y++;
            }
        }
        else
        {
            
        }         
    }
}
