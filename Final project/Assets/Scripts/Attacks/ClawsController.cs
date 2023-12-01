using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClawsController : AttackController
{
    float x,y;
    protected override void Start()
    {
        base.Start();
        if(playerChoiceHandler.choices[0] != 2){
            Destroy(gameObject);
        }
    }

    protected override void activate()
    {
        base.activate();
        x = Random.Range(-20f,20f);
        y = Random.Range(-20f,20f);
        GameObject spawnAttack = Instantiate(attackStats.Prefab);
        spawnAttack.transform.position = transform.position;
        Vector3 randPos = new Vector3(x,y,0f);
        Vector3 direction = randPos - spawnAttack.transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        spawnAttack.GetComponent<Rigidbody2D>().velocity = direction.normalized * attackStats.Speed;

        spawnAttack.transform.rotation = Quaternion.Euler(0f,0f,angle-135f);
    }
}