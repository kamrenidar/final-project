using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuyiController : AttackController
{
    protected override void Start()
    {
        base.Start();

        if(playerChoiceHandler.choices[0] != 1){
            Destroy(gameObject);
        }
    }

    protected override void activate()
    {
        base.activate();
        GameObject spawnStaff = Instantiate(attackStats.Prefab);
        spawnStaff.transform.position = transform.position;
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 direction = mousePos - spawnStaff.transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        spawnStaff.GetComponent<Rigidbody2D>().velocity = new Vector2(direction.x, direction.y).normalized * attackStats.Speed;

        spawnStaff.transform.rotation = Quaternion.Euler(0f,0f,angle + 270f);
    }
}
