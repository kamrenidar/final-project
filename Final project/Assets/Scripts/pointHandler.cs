using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pointHandler : MonoBehaviour
{

    PlayerChoiceHandler playerChoiceHandler;

    [SerializeField] public int pointsEarned = 0;

    void Awake(){
        playerChoiceHandler = PlayerChoiceHandler.singleton;
    }

    public void addPoints(int pointsToAdd){
        pointsEarned += pointsToAdd;
        GetComponent<AudioSource>().Play();
    }

    void Update(){
        if(pointsEarned >= 1){
           SceneManager.LoadScene("upgradeChoice");
        }
    }

}
