using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pointsText : MonoBehaviour
{

    Text PointsText;
    pointHandler pointHandler;

    void Start(){
        PointsText = GetComponent<Text>();
        pointHandler = GameObject.FindGameObjectWithTag("pointHandler").GetComponent<pointHandler>();
        StartCoroutine(pointsRoutine());
    }

    IEnumerator pointsRoutine(){
        while(true){
            yield return new WaitForSeconds(0);
            PointsText.text = pointHandler.pointsEarned.ToString();
        }
        yield return null;
    }

}
