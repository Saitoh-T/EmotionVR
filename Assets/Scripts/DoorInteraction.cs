using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteraction : MonoBehaviour
{

    private Animator animator;
    [SerializeField] private GameObject player;
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
        if (_state.fire&& !_interactFlag) 
        {
            Rotation();
            _interactFlag = true;
            player.GetComponent<InputActionMap>().fire = false;
        }
    }

    private void Rotation() 
    {
            animator.SetTrigger("Open");
    }

}
