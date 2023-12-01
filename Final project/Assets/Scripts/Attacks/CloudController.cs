using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudController : AttackController
{
    // Start is called before the first frame update
    
    protected override void Start()
    {
        base.Start();
        if(playerChoiceHandler.choices[1] != 2 || playerChoiceHandler.choices[1] == 0){
            Destroy(gameObject);
        }
    }

    protected override void activate()
    {
        base.activate();
        GameObject spawnAttack = Instantiate(attackStats.Prefab);
        spawnAttack.transform.position = transform.position;
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 direction = mousePos - spawnAttack.transform.position;

        spawnAttack.GetComponent<Rigidbody2D>().velocity = new Vector2(direction.x, direction.y).normalized * attackStats.Speed;
    }
}
