using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerCollisions : MonoBehaviour
{

    pointHandler pointHandler;

    void Awake(){
        pointHandler = GameObject.FindGameObjectWithTag("pointHandler").GetComponent<pointHandler>();
    }

    void OnTriggerEnter2D(Collider2D other){

        if(other.gameObject.tag == "pointTag"){
            GetComponent<AudioSource>().Play();
            pointHandler.addPoints(1);
        }
        else{
            SceneManager.LoadScene("MainMenu");
        }
        Destroy(other.gameObject);
    }

}
