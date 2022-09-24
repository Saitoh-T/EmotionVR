using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class MoveBoxes : MonoBehaviour
{
	[SerializeField] private GameObject ParentObject;
	private GameObject[] ChildObject;

	void Start()
	{
		GetAllChildObject();
	}

	private void GetAllChildObject()
	{
		ChildObject = new GameObject[ParentObject.transform.childCount];

		for (int i = 0; i < ParentObject.transform.childCount; i++)
		{
			ChildObject[i] = ParentObject.transform.GetChild(i).gameObject;
		}
	}

	public void moveBoxes()
	{
		for(var i = 0; i< 3; i++) 
		{
			ChildObject[i].SetActive(false);
		}	
		for(var i = 3; i< 6; i++) 
		{
			ChildObject[i].SetActive(true);
		}	
		
	}
}
