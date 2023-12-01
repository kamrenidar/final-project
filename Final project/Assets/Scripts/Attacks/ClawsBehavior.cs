using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClawsBehavior : ProjectileBehavior
{
    Transform player;
    public float growSpeed = 1f;
    public float spinSpeed;
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.localScale += new Vector3(growSpeed,growSpeed,0) * Time.deltaTime;
        growSpeed = growSpeed * 1.005f;

        gameObject.transform.Rotate(Vector3.forward, spinSpeed * Time.deltaTime);
    }
}
