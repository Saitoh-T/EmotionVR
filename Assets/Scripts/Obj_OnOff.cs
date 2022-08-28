using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obj_OnOff : MonoBehaviour
{
    [SerializeField] private GameObject[] items_disappear;
    [SerializeField] private GameObject[] items_appear;
    private bool _interactFlag = false;

    public void turnOnOff() 
    {
        if (!_interactFlag)
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
        }   
    }
}
