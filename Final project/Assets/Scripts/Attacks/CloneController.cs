using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneController : AttackController
{
    float x,y;

    List<GameObject> pool;

    protected override void Start()
    {
        pool = new List<GameObject>();
        base.Start();
        if(playerChoiceHandler.choices[2] != 2 || playerChoiceHandler.choices[1] == 0){
            Destroy(gameObject);
        }
    }

    protected override void activate()
    {
        base.activate();
        x = Random.Range(-15f,15f);
        y = Random.Range(-10f,10f);
        GameObject spawnAttack;
        if(pool.Count > 30){
            pool.RemoveAt(0);
            spawnAttack = pool[0];
        }
        else{
            spawnAttack = Instantiate(attackStats.Prefab);
        }
        
        pool.Add(spawnAttack);
        spawnAttack.transform.position = transform.position;
        Vector3 randPos = new Vector3(x,y,0f);
        Vector3 direction = randPos - spawnAttack.transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        spawnAttack.GetComponent<Rigidbody2D>().velocity = direction.normalized * attackStats.Speed;
    }
}
