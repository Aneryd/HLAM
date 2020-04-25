using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMapSearch : MonoBehaviour
{
    public GameObject Player;
    public float distance = 100;

    void Update()
    {
        transform.position = Player.transform.position + Vector3.up * distance;
    }
}
