using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalSpawner : MonoBehaviour
{
    public GameObject enemy;
    void Start()
    {
        Vector3 spawnPosition = transform.position;

        Instantiate(enemy, spawnPosition, Quaternion.identity);
    }

    void Update()
    {
        
    }
}
