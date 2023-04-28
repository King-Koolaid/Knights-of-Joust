using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public float spawnRangeX = 10;
    public float spawnPosY = 10;
    public float startDelay = 2;
    public float spawnInterval = 4f;

    void Start()
    {
        InvokeRepeating("SpawnRandomEnemies", startDelay, spawnInterval);
    }

    void Update()
    {

    }

    void SpawnRandomEnemies()
    {
        int enemyIndex = Random.Range(0, enemyPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 2, spawnPosY);

        Instantiate(enemyPrefabs[enemyIndex], spawnPos, enemyPrefabs[enemyIndex].transform.rotation);
    }
}