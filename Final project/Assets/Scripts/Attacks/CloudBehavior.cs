using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudBehavior : ProjectileBehavior
{
    Transform player;
    public float newSize, growRate, fadeRate;
    SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        newSize += growRate * Time.deltaTime;
        gameObject.transform.localScale += Vector3.one * newSize;

        Color color = spriteRenderer.color;
        float alpha = Mathf.Lerp(color.a, 0, Time.deltaTime * fadeRate);
        spriteRenderer.color = new Color(color.r, color.g, color.b, alpha);

    }
}
