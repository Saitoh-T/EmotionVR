
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TestElv : MonoBehaviour
{
    private bool EVflag;
    public float floar;
    [SerializeField] GameObject Player;
    [SerializeField] GameObject EVButton;
    NavMeshAgent _navAgent;
    public bool Visible;

    // Start is called before the first frame update
    void Start()
    {
        floar = 1f;
        EVflag = false;
        _navAgent = Player.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        Visible = EVButton.GetComponent<Renderer>().isVisible;
        if (transform.position.y < 11 && floar == 1f && EVflag == true && Visible)
        {
            transform.Translate(0, 0.05f, 0);

        }


        if (transform.position.y > 0f && floar == 2f && EVflag == true && Visible)
        {
            transform.Translate(0, -0.05f, 0);
        }




    }
    private void OnTriggerEnter(Collider other)
    {

        EVflag = true;
        _navAgent.enabled = false;


    }
    private void OnTriggerExit(Collider other)
    {
        if (floar == 1f && EVflag == true)
        {
            floar = 2f;
            EVflag = false;
        }
        if (floar == 2f && EVflag == true)
        {
            floar = 1f;
            EVflag = false;
        }
    }
}