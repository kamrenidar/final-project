using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BangBehavior : ProjectileBehavior
{
    Transform player;
    public float growSpeed = 1f;
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
        gameObject.transform.localScale += new Vector3(growSpeed,growSpeed*2,0) * Time.deltaTime;
        growSpeed = growSpeed * 0.99f;
    }
}
