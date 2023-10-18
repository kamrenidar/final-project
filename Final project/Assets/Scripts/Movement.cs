using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody2D rb;
    void Awake(){
        rb = GetComponent<Rigidbody2D>();
    }
    
    public void MoveTransform(Vector3 vel){
        transform.position += vel * Time.deltaTime;
    }
    
    public void MoveRigidBody(Vector3 vel){
        rb.velocity = vel;
    }

}
