using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "WeaponScriptableObject", menuName = "ScriptableObjects/Weapon")]
public class AttackScriptableObject : ScriptableObject
{

    [SerializeField]
    GameObject prefab;
    public GameObject Prefab {get => prefab; private set => prefab = value;}

    [SerializeField]
    float damage;
    public float Damage {get => damage; private set => damage = value;}

    [SerializeField]
    float speed;
    public float Speed {get => speed; private set => speed = value;}

    [SerializeField]
    float cooldown;
    public float Cooldown {get => cooldown; private set => cooldown = value;}

    [SerializeField]
    int pierce;
    public int Pierce {get => pierce; private set => pierce = value;}

    [SerializeField]
    float size;
    public float Size {get => size; private set => size = value;}
    



}
