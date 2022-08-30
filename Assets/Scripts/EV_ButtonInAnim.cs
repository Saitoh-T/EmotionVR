using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EV_ButtonInAnim : MonoBehaviour
{

    [SerializeField] GameObject EV;

    public void TurnOn()
    {
        EV.GetComponent<TestElv>().EVflag = true;
    }
}
