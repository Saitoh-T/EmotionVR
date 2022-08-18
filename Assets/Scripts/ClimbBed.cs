using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClimbBed : MonoBehaviour
{

    private Animator animator;
    [SerializeField] private GameObject player;
    private InputActionMap _state;
    private bool _interactFlag = false;

    // Start is called before the first frame update
    void Start()
    {
        _state = player.GetComponent<InputActionMap>();
    }

    
    public void Interaction() 
    {
      
    }
}
