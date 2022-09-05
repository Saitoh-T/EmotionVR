using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EVCollider : MonoBehaviour
{
    [SerializeField] GameObject Player;
    [SerializeField] GameObject EV;
    [SerializeField] GameObject subscript;

    void Start() 
    {
    }

    public void CheckItem()
    {
        var state = Player.GetComponent<InputActionMap>();
        var EVCollider = EV.GetComponent<BoxCollider>();
        if (state.item1 && state.item2)
        {
            EVCollider.enabled = true;
        }
        else 
        {
            StartCoroutine(showSubscript());
        }
    }

    private IEnumerator showSubscript() 
    {
        subscript.SetActive(true);
        yield return new WaitForSeconds(2.0f);
        subscript.SetActive(false);
    }
}
