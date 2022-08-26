using UnityEngine;
using System.Collections;

public class TanksLookTarget : MonoBehaviour
{

	[SerializeField]
	Transform target;

	[SerializeField]
	Transform cursor;

	[SerializeField]
	NavMeshAgent agent;

	void Start()
	{
		agent.SetDestination(target.position);
		agent.updateRotation = false;
		agent.updatePosition = false;
	}

	void Update()
	{
		cursor.rotation = Quaternion.LookRotation(agent.steeringTarget - transform.position, Vector3.right);
		agent.nextPosition = transform.position;
	}
}