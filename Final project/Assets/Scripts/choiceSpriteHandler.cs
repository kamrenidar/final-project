using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class choiceSpriteHandler : MonoBehaviour
{
    PlayerChoiceHandler playerChoiceHandler;

    [SerializeField] public int whichChoice;
    [SerializeField] public Sprite[] sprites; 
    SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        playerChoiceHandler = PlayerChoiceHandler.singleton;

        spriteRenderer = GetComponent<SpriteRenderer>();

        if(playerChoiceHandler.choices[0] == 0){
            spriteRenderer.sprite = sprites[0];
        }
        else if(playerChoiceHandler.choices[1] == 0){
            spriteRenderer.sprite = sprites[1];
        }
        else{
            spriteRenderer.sprite = sprites[2];
        }
    }
}
