using UnityEngine;
using System.Collections;

public class Guide : MonoBehaviour
{

	[SerializeField]
	Transform[] targets;

	[SerializeField]
	Transform cursor;

	[SerializeField]
	UnityEngine.AI.NavMeshAgent agent;

	[SerializeField] 
	GameObject player;

	public Transform target;
	public bool next;
	private int i = 0;

	void Start()
	{
		agent.SetDestination(targets[0].position);
		agent.updateRotation = false;
		agent.updatePosition = false;
	}

	void Update()
	{
		target = targets[i];
		if (next && (i+1 <targets.Length)) 
		{
			i++;
			next = false;
		}
		
		agent.SetDestination(target.position);
		cursor.rotation = Quaternion.LookRotation(agent.steeringTarget - transform.position, Vector3.right);
		agent.nextPosition = transform.position;
	}
}