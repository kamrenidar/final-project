using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public PlayerScriptableObject playerNumbers;
    float currHealth;
    Text HealthText;
    PlayerStats player;

    void Start(){
        currHealth = playerNumbers.MaxHealth;
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStats>();
        HealthText = GetComponent<Text>();
        //pointHandler = GameObject.FindGameObjectWithTag("pointHandler").GetComponent<pointHandler>();
        //StartCoroutine(pointsRoutine());
    }

    void Update(){
        string healthString = "Health: " + player.currHealth + " / " + playerNumbers.MaxHealth ;
        HealthText.text = healthString;
    }

}
