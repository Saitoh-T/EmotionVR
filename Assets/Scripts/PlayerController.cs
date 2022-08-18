using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class PlayerController : MonoBehaviour
{
    bool m_TriggerDown;
    ActionBasedContinuousMoveProvider _movement;
    // Start is called before the first frame update
    void Start()
    {
    } 

    // Update is called once per frame
    void Update()
    {
        if (m_TriggerDown)
        {
            _movement.moveSpeed = 10;
        }
        else 
        {
            _movement.moveSpeed = 1;
        }
    }

    void TriggerReleased(DeactivateEventArgs args)
    {
        m_TriggerDown = false;
    }

    void TriggerPulled(ActivateEventArgs args)
    {
        m_TriggerDown = true;
    }
}
