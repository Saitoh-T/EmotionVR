using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveWheelchair : MonoBehaviour
{
    private NavMeshAgent _wheelchair;
    private EnemyMove _script;
    // Start is called before the first frame update
    void Start()
    {
       _wheelchair = GetComponentInParent<NavMeshAgent>();
        _script = GetComponentInParent<EnemyMove>();
    }

    // Update is called once per frame
    public void Move_Wheelchair()
    {
        _wheelchair.enabled=true;
        _script.enabled = true;
    }
}
