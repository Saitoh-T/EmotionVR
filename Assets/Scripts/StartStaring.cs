using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class StartStaring : MonoBehaviour
{
    [SerializeField] GameObject _Dolls;
    [SerializeField] GameObject _player;
    bool _flag = false;
    public void Staring()
    {
        if (!_flag)
        {
            StartCoroutine(StopPlayer());
            var _scripts = GetComponentsInChildren<LookAt>();
            foreach (var _script in _scripts)
            {
                _script.enabled = true;
            }
            _flag = true;
        }
    }

    IEnumerator StopPlayer() 
    {
        var _controller = _player.GetComponent<ActionBasedContinuousMoveProvider>();
        _controller.enabled = false;
        yield return new WaitForSeconds(1.0f);
        _controller.enabled = true;
    }
}
