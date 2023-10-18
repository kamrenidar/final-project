using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaffController : AttackController
{
    // Start is called before the first frame update
    
    protected override void Start()
    {
        base.Start();
    }

    protected override void activate()
    {
        base.activate();
        GameObject spawnStaff = Instantiate(attackStats.Prefab);
        spawnStaff.transform.position = transform.position;
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 direction = mousePos - spawnStaff.transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        spawnStaff.GetComponent<Rigidbody2D>().velocity = direction.normalized * attackStats.Speed;

        spawnStaff.transform.rotation = Quaternion.Euler(0f,0f,angle);
    }
}
