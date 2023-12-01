using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChoiceHandler : MonoBehaviour
{
    public static PlayerChoiceHandler singleton;
    public int[] choices;
    
    float time;

    void Awake(){
        if(singleton == null){
            choices = new int[3];
            singleton = this;
            choices[0] = 0;
            choices[1] = 0;
            choices[2] = 0;
            DontDestroyOnLoad(gameObject);
        }
        else{
            Destroy(this.gameObject);
        }
    }

    void Update(){
        time -= Time.deltaTime;
        if(time <= 0f){
            Debug.Log("[0] = " + choices[0] + "[1] = " + choices[1] + "[2] = " + choices[2]);
            time = 5;
        }
    }
}
