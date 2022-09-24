using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] GameObject Enemy;

    public void Spawn()
    {
        Enemy.SetActive(true);
    }
}
