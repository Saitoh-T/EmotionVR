
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestElv : MonoBehaviour
{
    private bool EVflag;
    public float floar;
    // Start is called before the first frame update
    void Start()
    {
        floar = 1f;
        EVflag = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < 11 && floar == 1f && EVflag == true)
        {
            transform.Translate(0, 0.05f, 0);

        }


        if (transform.position.y > 0f && floar == 2f && EVflag == true)
        {
            transform.Translate(0, -0.05f, 0);
        }




    }
    private void OnTriggerEnter(Collider other)//エレベーターの中に入ったら
    {

        EVflag = true;


    }
    private void OnTriggerExit(Collider other)//エレベーターから出たら
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