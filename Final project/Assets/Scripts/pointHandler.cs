using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pointHandler : MonoBehaviour
{

    [SerializeField] public int pointsEarned = 0;

    public void addPoints(int pointsToAdd){
        pointsEarned += pointsToAdd;
        GetComponent<AudioSource>().Play();
    }

    void Update(){
        if(pointsEarned >= 20){
            SceneManager.LoadScene("Main Menu");
        }
    }

}
