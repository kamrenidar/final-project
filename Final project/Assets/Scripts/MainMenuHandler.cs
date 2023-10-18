using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuHandler : MonoBehaviour
{
    public void playGame(){
        SceneManager.LoadScene("Stage 1");
    }

    public void quitGame(){
        Debug.Log("QUIT");
        Application.Quit();
    }

}
