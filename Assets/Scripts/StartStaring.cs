using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartStaring : MonoBehaviour
{
    [SerializeField] GameObject _Dolls;

    public void Staring()
    {
        var _scripts = GetComponentsInChildren<LookAt>();
        foreach (var _script in _scripts) 
        {
            _script.enabled = true;
        }
    }
}
