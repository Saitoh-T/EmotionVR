using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.XR;
using UnityEngine.XR.Interaction.Toolkit;

//必須コンポーネントとしてPlayerInputを指定
[RequireComponent(typeof(PlayerInput))]
public class InputActionMap : MonoBehaviour
{
    bool _dashState = false;
    bool _light = false;
    bool _runSoundFlag = false;
    bool _walkSoundFlag = false;
    bool _stopFlag = false;

    public bool fire = false;
    public bool item1 = false;
    public bool item2 = false;
    public bool item3 = false;
    [SerializeField] private GameObject Light;
//    [SerializeField] private GameObject Player;
    [SerializeField] private GameObject Guide;
    
    private void OnLeftAction(InputValue arg)
    {
        //振動させるデバイスを取得
        PlayerInput input = GetComponent<PlayerInput>();
        InputAction haptic = input.actions["LeftHaptic"];
        if (haptic.activeControl?.device is XRControllerWithRumble rumbleController)
        {
            rumbleController.SendImpulse(0.9f, 0.25f);
        }
        var move = GetComponent<ActionBasedContinuousMoveProvider>();
        if (!_dashState)
        {
            _dashState = true;
            move.moveSpeed = 4;
        }
        else 
        {
            move.moveSpeed = 2;
            _dashState = false;
        }
    }
    // ActionMapに定義されているActionに対応した処理
    private void OnRightAction(InputValue arg)
    {
        //振動させるデバイスを取得
        PlayerInput input = GetComponent<PlayerInput>();
        InputAction haptic = input.actions["RightHaptic"];
        if (haptic.activeControl?.device is XRControllerWithRumble rumbleController)
        {
            rumbleController.SendImpulse(0.9f, 0.25f);
        }

        StartCoroutine(Fire());
    }

    private void OnAButton(InputValue arg) 
    {
        if (!_light) 
        {
            _light = true;
            Light.SetActive(true);
        }
        else
        {
            _light = false;
            Light.SetActive(false);
        }
    }

    private void OnMoveSounds(InputValue arg)
    {
        var _audio = GetComponent<AudioSource>();
        var _mag = arg.Get<Vector2>().magnitude;
        if (_mag > 1) { _mag = 1; }
        if (_dashState && _mag > 0.3&& !_runSoundFlag)
        {
            _audio.pitch = 4f;
            _audio.Play();
            _runSoundFlag = true;
            _walkSoundFlag = false;
            _stopFlag = false;
        }
        if (!_dashState && _mag > 0.3&&!_walkSoundFlag)
        {
            _audio.pitch = 2f;
            _audio.Play();
            _runSoundFlag = false;
            _walkSoundFlag = true;
            _stopFlag = false;
        }
        if (_mag < 0.3&& !_stopFlag)
        {
            _audio.Stop();
            _runSoundFlag = false;
            _walkSoundFlag = false;
            _stopFlag = true;
        }
    }

    private IEnumerator Fire() 
    {
        fire = true;
        yield return new WaitForSeconds(0.5f);
        fire = false;
    }

    public void Next() 
    {
        Guide.GetComponent<Guide>().next = true;
    }
}