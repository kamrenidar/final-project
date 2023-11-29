using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class choiceTextHandler : MonoBehaviour
{
    PlayerChoiceHandler playerChoiceHandler;

    [SerializeField] public int whichChoice;
    Text choiceText;

    // Start is called before the first frame update
    void Start(){
        playerChoiceHandler = PlayerChoiceHandler.singleton;

        choiceText = GetComponent<Text>();

        if(playerChoiceHandler.choices[0] == 0){
            if(whichChoice == 1) choiceText.text = "Ruyi";
            else choiceText.text = "Claws";
        }
        else if(playerChoiceHandler.choices[1] == 0){
            if(whichChoice == 1) choiceText.text = "Jingu";
            else choiceText.text = "Clouds";
        }
        else{
            if(whichChoice == 1) choiceText.text = "Bang";
            else choiceText.text = "Clones";
        }
    }
}
