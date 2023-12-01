using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointHandler : MonoBehaviour
{

    PlayerChoiceHandler playerChoiceHandler;
    sceneTransitionHandler sceneTransitionHandler;

    [SerializeField] public int pointsEarned = 0;
    public int goal;

    void Awake(){
        sceneTransitionHandler = GameObject.FindGameObjectWithTag("sceneTransitionHandler").GetComponent<sceneTransitionHandler>();
        playerChoiceHandler = PlayerChoiceHandler.singleton;

        if(playerChoiceHandler.choices[2] != 0) goal = 3;
        else if(playerChoiceHandler.choices[1] != 0) goal = 2;
        else goal = 1;
    }

    public void addPoints(int pointsToAdd){
        pointsEarned += pointsToAdd;
        GetComponent<AudioSource>().Play();
    }

    void Update(){
        if(pointsEarned >= goal){
            if(playerChoiceHandler.choices[2] != 0){
                playerChoiceHandler.choices[0] = 0;
                playerChoiceHandler.choices[1] = 0;
                playerChoiceHandler.choices[2] = 0;
                sceneTransitionHandler.sceneTransition("Main Menu");
            }
            else{
                sceneTransitionHandler.sceneTransition("upgradeChoice");
            }
           
        }
    }

}
