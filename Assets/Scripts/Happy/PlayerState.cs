using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState : MonoBehaviour
{

    public bool Play;
    public bool Brush;
    public bool Feed;
    public bool Ride;
    // Start is called before the first frame update
    void Start()
    {
        //��X���ׂ�false�ɂ���UI����؂�ւ�
        Play = true;
        Brush = false;
        Feed = false;
        Ride = false;
}

    // Update is called once per frame
    void Update()
    {
        
    }
}
