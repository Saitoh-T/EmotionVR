using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_disappear : MonoBehaviour
{
    [SerializeField] private GameObject[] items_disappear;
    [SerializeField] private GameObject[] items_appear;
    [SerializeField] private GameObject player;
    private bool _interactFlag = false;
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
            
            if (!_state.item1)
            {
                player.GetComponent<InputActionMap>().item1 = true;
            }
            if (_state.item1 && !_state.item2)
            {
                player.GetComponent<InputActionMap>().item2 = true;
            }
            if (_state.item1 && _state.item2 && !_state.item3)
            {
                player.GetComponent<InputActionMap>().item3 = true;
            }
        }
    }
}
