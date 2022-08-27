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
	
	private InputActionMap _state;

	void Start()
	{
		_state = player.GetComponent<InputActionMap>();
		agent.SetDestination(targets[0].position);
		agent.updateRotation = false;
		agent.updatePosition = false;
	}

	void Update()
	{
		_state = player.GetComponent<InputActionMap>();

		if (_state.item1 && _state.item2 && _state.item3)
		{
			agent.SetDestination(targets[3].position);
		}
		if (_state.item1 && _state.item2 && !_state.item3)
		{
			agent.SetDestination(targets[2].position);
		}
		if (_state.item1 && !_state.item2)
		{
			agent.SetDestination(targets[1].position);
		}
		if (!_state.item1)
		{
			agent.SetDestination(targets[0].position);
		}
		cursor.rotation = Quaternion.LookRotation(agent.steeringTarget - transform.position, Vector3.right);
		agent.nextPosition = transform.position;
	}
}