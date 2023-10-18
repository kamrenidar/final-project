using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public PlayerScriptableObject playerStats;
    Movement dm;
    float speedScale;
    

    void Awake(){
        dm = GetComponent<Movement>();
        speedScale = playerStats.MoveSpeed;
    }
    
    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 vel = Vector3.zero;
        
        if(Input.GetKey(KeyCode.A)){
            vel.x = -1;
        }
        else if(Input.GetKey(KeyCode.D)){
            vel.x = 1;
        }
        else if(Input.GetKey(KeyCode.S)){
            vel.y = -1;
        }
        else if(Input.GetKey(KeyCode.W)){
            vel.y = 1;
        }
        dm.MoveRigidBody(vel * speedScale);
    }
}
