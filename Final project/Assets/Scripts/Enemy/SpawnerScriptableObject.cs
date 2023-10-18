using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SpawnerScriptableObject", menuName = "ScriptableObjects/Spawner")]

public class SpawnerScriptableObject : ScriptableObject
{
    [SerializeField]
    GameObject prefab;
    public GameObject Prefab {get => prefab; private set => prefab = value;}

    [SerializeField]
    float spawnSpeed;
    public float SpawnSpeed {get => spawnSpeed; set => spawnSpeed = value;}
}
