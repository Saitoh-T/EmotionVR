using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.AI;

public class BallPlay : MonoBehaviour
{
    [SerializeField] GameObject Ball;
    [SerializeField] GameObject Player;
    private PlayerState state;
    private XRGrabInteractable ball;
    private NavMeshAgent _agent;
    private float _speed;
    private bool PickUpFlag;
    private bool ReturnFlag;
    private bool RetrackFlag;
    
    // Start is called before the first frame update
    void Start()
    {
        ball = Ball.GetComponent<XRGrabInteractable>();
        _agent = GetComponentInParent<NavMeshAgent>();
        _speed = _agent.speed;
        PickUpFlag = true;
        ReturnFlag = true;
        RetrackFlag = true;
    }

    // Update is called once per frame
    void Update() 
    {
        if (!ball.isSelected)
        {
            if (ComparePosition(Ball) > 0.8)
            {
                Chasing();
            }
            else 
            {
                PickUpFlag = PickUp(PickUpFlag);
                TakeBallBack();
                if (ComparePosition(Player) < 5.0f)
                {
                    ReturnFlag = Returning(ReturnFlag);
                    Debug.Log("Return");
                }
                else if(ComparePosition(Player) > 6.0f)
                {
                    RetrackFlag = Retrucking(RetrackFlag);
                    Debug.Log("Retrack");
                }
            }
        }
        else 
        {
            Idle();
        }
    }

    void Chasing()
    {
        _agent.destination = Ball.transform.position;
        Ball.transform.SetParent(null);
        PickUpFlag = true;
        ReturnFlag = true;
        RetrackFlag = true;
    }

    void TakeBallBack() 
    {
        _agent.destination = Player.transform.position;
    }
    
    bool Returning(bool flag)
    {
        if (flag)
        {
            Ball.GetComponent<Rigidbody>().isKinematic = false;
            ball.enabled = true;
            _agent.speed = 0f;
            Ball.transform.SetParent(null);
            RetrackFlag = true;
        }

        return false;
    }

    bool Retrucking(bool flag) 
    {
        if (flag)
        {
            Ball.GetComponent<Rigidbody>().isKinematic = true;
            ball.enabled = false;
            _agent.speed = _speed;
            _agent.destination = Player.transform.position;
            Ball.transform.SetParent(transform);
            ReturnFlag = true;
        }

        return false;
    }

    float ComparePosition(GameObject Obj) 
    {
        var diff = Obj.transform.position - transform.position;
        var distance = diff.magnitude;
        return distance;
    }

    bool PickUp(bool flag) 
    {
        if (flag)
        {
            ball.enabled = false;
            Ball.GetComponent<Rigidbody>().isKinematic = true;
            //TODO Anim.SetTrigger?https://futabazemi.net/unity/player_moveset
            Ball.transform.position = new Vector3(transform.position.x, transform.position.y+0.75f, transform.position.z);
            Ball.transform.SetParent(transform);
        }
        return false;
    }

    void Idle() 
    {
        PickUpFlag = true;
        ReturnFlag = true;
        RetrackFlag = true;
        _agent.speed = _speed;
         //TODO Anim.SetTrigger?
    }
}
