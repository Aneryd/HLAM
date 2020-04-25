using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPointStick : MonoBehaviour
{
    public Transform spawnZone;
    public GameObject stick;
    public int sum = 100;

    float maxX;
    float minX;
    float maxZ;
    float minZ;
    
    int i = 0;

    void Start()
    {
        maxX = spawnZone.position.x + spawnZone.localScale.x / 2;
        minX = spawnZone.position.x - spawnZone.localScale.x / 2;

        maxZ = spawnZone.position.z + spawnZone.localScale.z / 2;
        minZ = spawnZone.position.z - spawnZone.localScale.z / 2;
    }

    void Update()
    {
        while (i < sum)
        {
            Vector3 spawnPos = new Vector3(Random.Range(minX, maxX), spawnZone.position.y + 50, Random.Range(minZ, maxZ));
            Instantiate(stick, spawnPos, Quaternion.identity);
            i++;
        }
    }
}
