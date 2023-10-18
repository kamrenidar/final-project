using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyScriptableObject", menuName = "ScriptableObjects/Enemy")]

public class EnemyScriptableObject : ScriptableObject
{
    [SerializeField]
    float health;
    public float Health {get => health; set => health = value;}

    [SerializeField]
    float movementSpeed;
    public float MovementSpeed {get => movementSpeed; set => movementSpeed = value;}

    [SerializeField]
    float damage;
    public float Damage {get => damage; set => damage = value;}
}
