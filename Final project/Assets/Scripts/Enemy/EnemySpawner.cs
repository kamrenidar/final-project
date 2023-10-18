using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public SpawnerScriptableObject spawnerStats;
    float currTimer;

    void Awake(){
        currTimer = spawnerStats.SpawnSpeed;
        GameObject spawnEnemy = Instantiate(spawnerStats.Prefab, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if(currTimer > 0){
            currTimer -= Time.deltaTime;
        }
        else if (currTimer <= 0){
            currTimer = spawnerStats.SpawnSpeed;
            GameObject spawnEnemy = Instantiate(spawnerStats.Prefab, transform.position, Quaternion.identity);
        }
    }
}
