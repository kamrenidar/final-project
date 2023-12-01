using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneBehavior : ProjectileBehavior
{
    Rigidbody2D rb;
    public float interval;
    float passedTime = 0f;
    Vector3 currentVelocity;

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        rb = gameObject.GetComponent<Rigidbody2D>();
        currentVelocity = rb.velocity.normalized;
    }

    // Update is called once per frame
    void Update()
    {
        passedTime += Time.deltaTime;
        if(passedTime >= interval){
            float x = Random.Range(-15f,15f);
            float y = Random.Range(-10f,10f);
            Vector3 newDirection = new Vector3(x,y,0f).normalized;
            
            float speed = rb.velocity.magnitude;
            currentVelocity = newDirection * speed;
            rb.velocity = currentVelocity;
            passedTime = 0;
        }
    }
}
