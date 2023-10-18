using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{
    [SerializeField] float speedScale = 1;
    Movement dm;

    void Awake(){
        dm = GetComponent<Movement>();
    }
    void FixedUpdate()
    {
        Vector3 vel = Vector3.zero;
        vel.y = -1;
        dm.MoveRigidBody(vel * speedScale);
    }
}
