using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileSpawner : MonoBehaviour
{

    [SerializeField] GameObject projectilePrefab;
    [SerializeField] float spawnTimer;

    void Start(){
        spawnProjectiles();
    }

    void spawnProjectiles(){
        StartCoroutine(spawnProjectilesRoutine());

        IEnumerator spawnProjectilesRoutine(){
            
            while(true){
                yield return new WaitForSeconds(spawnTimer);
                GameObject newProjectile = Instantiate(projectilePrefab, new Vector3(Random.Range(-9,9),6,0), Quaternion.identity);
                Destroy(newProjectile,10);
            }

            yield return null;
        }  
    }

}
