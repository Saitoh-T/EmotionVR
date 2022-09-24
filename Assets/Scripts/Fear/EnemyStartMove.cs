using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyStartMove : MonoBehaviour
{
    [SerializeField] GameObject Enemy;
    
    public void NavOn()
    {
        Enemy.GetComponent<EnemyMove>().enabled = true;
    }
}
