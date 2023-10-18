using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CharacterScriptableObject", menuName = "ScriptableObjects/Character")]

public class PlayerScriptableObject : ScriptableObject
{
    [SerializeField]
    float maxHealth;
    public float MaxHealth {get => maxHealth; private set => maxHealth = value;}

    [SerializeField]
    float moveSpeed;
    public float MoveSpeed {get => moveSpeed; private set => moveSpeed = value;}

    [SerializeField]
    float regen;
    public float Regen {get => regen; private set => regen = value;}

    [SerializeField]
    float armor;
    public float Armor {get => armor; private set => armor = value;}
}
