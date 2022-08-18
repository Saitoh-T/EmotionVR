using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider))]
public class CollisionDetector : MonoBehaviour
{
    [SerializeField] private TriggerEvent onTriggerEnter = new TriggerEvent();
    [SerializeField] private TriggerEvent onTriggerStay = new TriggerEvent();

    private void OnTriggerEnter(Collider other) 
    {
        onTriggerEnter.Invoke(other);
    }
    
    private void OnTriggerStay(Collider other) 
    {
        onTriggerStay.Invoke(other);
    }

    [System.Serializable] public class TriggerEvent : UnityEvent<Collider> 
    {
    }
}
