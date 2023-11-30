using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JinguBehavior :  ProjectileBehavior
{
    Transform player;
    float spinSpeed = 720f;

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = player.position;
        gameObject.transform.Rotate(Vector3.forward, -spinSpeed * Time.deltaTime);
    }
}
