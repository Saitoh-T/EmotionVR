using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedDoorInteraction4Tutorial : MonoBehaviour
{

    private Animator animator;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject Canvas;
    private InputActionMap _state;
    private bool _interactFlag = false;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        _state = player.GetComponent<InputActionMap>();
    }

    public void Interaction() 
    {
        if (_state.fire && !_interactFlag && _state.item1) 
        {
            Rotation();
            _interactFlag = true;
            player.GetComponent<InputActionMap>().fire = false;
            Canvas.SetActive(false);
        }
    }

    private void Rotation() 
    {
            animator.SetTrigger("Fire");
    }

}
