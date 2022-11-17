using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawners : MonoBehaviour
{
    [SerializeField] GameObject wall;
    [SerializeField] GameObject[] SpawnPoint;

    [Range(1, 4)]
    [SerializeField] float MaxSpawnTime, MinSpawnTime;
    float spawnTime;

    int index;
    private void Awake()
    {
        RandomSpawn();
    }

    private void RandomSpawn()
    {
        index = Random.Range(0, SpawnPoint.Length);
        spawnTime = 0f;
    }

    private void Update()
    {
        spawnTime += Time.deltaTime;
        if (spawnTime > 1)
        {
            Instantiate(wall, SpawnPoint[index].transform.position, Quaternion.identity);
            RandomSpawn();
        }
    }

}
