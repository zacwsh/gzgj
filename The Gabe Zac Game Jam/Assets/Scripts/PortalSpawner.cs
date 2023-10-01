using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalSpawner: MonoBehaviour
{
    public GameObject enemyPrefab;
    private float spawnRange = 20.0f;
    public int enemyCount;
    public int waveNumber = 5;
    public float waitTime = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemyWave(5));
    }

    IEnumerator SpawnEnemyWave(int enemiesToSpawn)
    {
        for (int i = 0; i < enemiesToSpawn; i++)
        {
            Instantiate(enemyPrefab, GenerateSpawnPos(), enemyPrefab.transform.rotation);
            yield return new WaitForSeconds(waitTime); // Wait for 'waitTime' seconds before spawning the next enemy
        }
    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = FindObjectsOfType<Enemy>().Length;

        if (enemyCount == 0)
        {
            waveNumber++;
            StartCoroutine(SpawnEnemyWave(waveNumber));
        }
    }

    private Vector3 GenerateSpawnPos()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);

        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);
     
        return randomPos;
    }
}