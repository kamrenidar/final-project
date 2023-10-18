using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyStats : MonoBehaviour
{
    public EnemyScriptableObject enemyNumbers;

    pointHandler pointHandler;
    float currMovementSpeed;
    float currHealth;
    float currDamage;


    void Awake(){
        currMovementSpeed = enemyNumbers.MovementSpeed;
        currDamage = enemyNumbers.Damage;
        currHealth = enemyNumbers.Health;
        pointHandler = GameObject.FindGameObjectWithTag("pointHandler").GetComponent<pointHandler>();
    }

    public void damageEnemy(float damage){
        currHealth -= damage;

        if(currHealth <= 0){
            enemyDeath();
        }
    }

    public void enemyDeath(){
        pointHandler.addPoints(1);
        GetComponent<AudioSource>().Play();
        Destroy(gameObject);
    }

    public void OnCollisionStay2D(Collision2D collision){
        if(collision.gameObject.CompareTag("Player")){
            PlayerStats player = collision.gameObject.GetComponent<PlayerStats>();
            player.damagePlayer(currDamage);
        }
    }

}
