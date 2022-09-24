
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class TestElv : MonoBehaviour
{
    public bool EVflag;
    public float floar;
    [SerializeField] GameObject Player;
    [SerializeField] GameObject Fence;
    [SerializeField] GameObject EV;
    [SerializeField] GameObject Stopper;
    NavMeshAgent _navAgent;
    ActionBasedContinuousMoveProvider _playerMOVE;
    private bool fire;
    private bool flag;
    private Animator anim;
    private BoxCollider EVCollider;
    private BoxCollider StopCollider;

    // Start is called before the first frame update
    void Start()
    {
        floar = 1f;
        EVflag = false;
        flag = false;
        _navAgent = Player.GetComponent<NavMeshAgent>();
        anim = Fence.GetComponent<Animator>();
        _playerMOVE = Player.GetComponent<ActionBasedContinuousMoveProvider>();
        EVCollider = EV.GetComponent<BoxCollider>();
        StopCollider = Stopper.GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < 11 && floar == 1f && EVflag == true)
        {
            transform.Translate(0, 0.05f, 0);

        }


        else if (transform.position.y > 0f && floar == 2f && EVflag == true)
        {
            transform.Translate(0, -0.05f, 0);
        }

        else if(EVflag == true)
        {
            _playerMOVE.enabled = true;
            anim.SetTrigger("Open");
            EVflag = false;
            flag = true;
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        _navAgent.enabled = false;
    }

    private void OnTriggerStay(Collider other)
    {
        fire = Player.GetComponent<InputActionMap>().fire;
        if (fire) 
        {
            anim.SetTrigger("Fire");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (floar == 1f && flag == true )
        {
            floar = 2f;
            flag = false;
        }
        if (floar == 2f && flag == true )
        {
            floar = 1f;
            flag = false;
        }

        EVCollider.enabled = false;
        StopCollider.enabled = false;
    }
}