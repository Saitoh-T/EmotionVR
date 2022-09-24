using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obj_OnOff_interact : MonoBehaviour
{
    [SerializeField] private GameObject[] items_disappear;
    [SerializeField] private GameObject[] items_appear;
    [SerializeField] private GameObject player;
    public bool _interactFlag = false;
    private InputActionMap _state;

    void Start()
    {
        _state = player.GetComponent<InputActionMap>();
    }

    public void turnOnOff()
    {
        if (_state.fire && !_interactFlag)
        {
            foreach (var item_disappear in items_disappear)
            {
                item_disappear.SetActive(false);
            }
            foreach (var item_appear in items_appear)
            {
                item_appear.SetActive(true);
            }
            _interactFlag = true;
            player.GetComponent<InputActionMap>().fire = false;
            _state.Next();
        }
    }

    public void FlagOff() 
    {
        _interactFlag = false;
    }
}
