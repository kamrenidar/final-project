using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackController : MonoBehaviour
{
    PlayerChoiceHandler playerChoiceHandler;
    public AttackScriptableObject attackStats;
    public float currentCooldown;

    // Start is called before the first frame update
    protected virtual void Start()
    {
        playerChoiceHandler = PlayerChoiceHandler.singleton;
        currentCooldown = attackStats.Cooldown;
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        currentCooldown -= Time.deltaTime;
        if(currentCooldown <= 0f){
            activate();
        }
    }

    protected virtual void activate()
    {
        currentCooldown = attackStats.Cooldown;
    }
}
