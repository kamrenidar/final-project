using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    public PlayerScriptableObject playerNumbers;
    public float currHealth;
    float currMoveSpeed;
    float currRegen;
    float currArmor;

    public float iFrameDuration;
    float iFrameTimer;
    bool iFramesActive;

    void Awake(){
        currHealth = playerNumbers.MaxHealth;
        currMoveSpeed = playerNumbers.MoveSpeed;
        currRegen = playerNumbers.Regen;
        currArmor = playerNumbers.Armor;
        iFramesActive = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(iFrameTimer > 0){
            iFrameTimer -= Time.deltaTime;
        }
        else if (iFramesActive){
            iFramesActive = false;
        }
    }

    public void damagePlayer(float damage){
        if(!iFramesActive){
            currHealth -= damage;
            iFrameTimer = iFrameDuration;
            iFramesActive = true;

            if(currHealth <= 0){
                playerDeath();
            }
        }
    }

    public void playerDeath(){
        Debug.Log("Game over");
        GetComponent<AudioSource>().Play();
        SceneManager.LoadScene("Main Menu");
    }

    
}
