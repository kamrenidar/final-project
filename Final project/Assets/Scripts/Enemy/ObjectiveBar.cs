using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectiveBar : MonoBehaviour
{
    Text ObjectiveText;
    pointHandler pointHandler;
    PlayerChoiceHandler playerChoiceHandler;
    string goalString;

    void Start(){
        pointHandler = GameObject.FindGameObjectWithTag("pointHandler").GetComponent<pointHandler>();
        ObjectiveText = GetComponent<Text>();
        
        playerChoiceHandler = PlayerChoiceHandler.singleton;

        if(playerChoiceHandler.choices[2] != 0) goalString = "60";
        else if(playerChoiceHandler.choices[1] != 0) goalString = "40";
        else goalString = "20";
    }

    void Update(){
        string healthString = "Enemies Killed: " + pointHandler.pointsEarned.ToString() + " / " + goalString;
        ObjectiveText.text = healthString;
    }

}