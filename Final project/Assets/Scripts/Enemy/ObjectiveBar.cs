using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectiveBar : MonoBehaviour
{
    Text ObjectiveText;
    pointHandler pointHandler;

    void Start(){
        pointHandler = GameObject.FindGameObjectWithTag("pointHandler").GetComponent<pointHandler>();
        ObjectiveText = GetComponent<Text>();
        //pointHandler = GameObject.FindGameObjectWithTag("pointHandler").GetComponent<pointHandler>();
        //StartCoroutine(pointsRoutine());
    }

    void Update(){
        string healthString = "Enemies Killed: " + pointHandler.pointsEarned.ToString() + " / 20";
        ObjectiveText.text = healthString;
    }

}