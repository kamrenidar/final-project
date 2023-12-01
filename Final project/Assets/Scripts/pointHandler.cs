using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pointHandler : MonoBehaviour
{

    PlayerChoiceHandler playerChoiceHandler;

    [SerializeField] public int pointsEarned = 0;
    public int goal;

    void Awake(){
        playerChoiceHandler = PlayerChoiceHandler.singleton;

        if(playerChoiceHandler.choices[2] != 0) goal = 20;
        else if(playerChoiceHandler.choices[1] != 0) goal = 20;
        else goal = 20;
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
                SceneManager.LoadScene("Main Menu");
            }
            else{
                SceneManager.LoadScene("upgradeChoice");
            }
           
        }
    }

}
