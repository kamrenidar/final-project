using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class choiceButtonHandler : MonoBehaviour
{
    public void choiceOne(){
        PlayerChoiceHandler playerChoiceHandler;
        playerChoiceHandler = PlayerChoiceHandler.singleton;

        if(playerChoiceHandler.choices[0] == 0){
            playerChoiceHandler.choices[0] = 1;
            SceneManager.LoadScene("Stage 1");
        }
        else if(playerChoiceHandler.choices[1] == 0){
            playerChoiceHandler.choices[1] = 1;
            SceneManager.LoadScene("Stage 2");
        }
        else if(playerChoiceHandler.choices[2] == 0){
            playerChoiceHandler.choices[2] = 1;
            SceneManager.LoadScene("Stage 3");
        }
        else{
            SceneManager.LoadScene("Main Menu");
        }
    }

    public void choiceTwo(){
        PlayerChoiceHandler playerChoiceHandler;
        playerChoiceHandler = PlayerChoiceHandler.singleton;

        if(playerChoiceHandler.choices[0] == 0){
            playerChoiceHandler.choices[0] = 2;
            SceneManager.LoadScene("Stage 1");
        }
        else if(playerChoiceHandler.choices[1] == 0){
            playerChoiceHandler.choices[1] = 2;
            SceneManager.LoadScene("Stage 2");
        }
        else if(playerChoiceHandler.choices[2] == 0){
            playerChoiceHandler.choices[2] = 2;
            SceneManager.LoadScene("Stage 3");
        }
        else{
            SceneManager.LoadScene("Main Menu");
        }
    }
}
