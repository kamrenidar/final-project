using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehavior : MonoBehaviour
{
    public AttackScriptableObject attackStats;

    float currentDamage;
    float currentSpeed;
    float currentCooldown;
    float currentPierce;
    float currentSize;

    protected Vector3 direction;
    public float lifetime;

    void Awake(){
        currentDamage = attackStats.Damage;
        currentSpeed = attackStats.Speed;
        currentCooldown = attackStats.Cooldown;
        currentPierce = attackStats.Pierce;
        currentSize = attackStats.Size;
    }

    // Start is called before the first frame update
    protected virtual void Start()
    {
        Destroy(gameObject, lifetime);
    }

    protected virtual void OnTriggerEnter2D(Collider2D collision){
        if(collision.CompareTag("Enemy")){
            enemyStats enemy = collision.GetComponent<enemyStats>();
            enemy.damageEnemy(currentDamage);
        }
    }

}
