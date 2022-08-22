using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    [SerializeField] AudioSource _Sounds; 
    [SerializeField] AudioSource _RandomSounds;
    bool _flag = false;
    bool _flag_R = false;
    public void Sound()
    {
        if (!_flag)
        {
            _Sounds.Play();
            _flag = true;
        }
    }

    public void RandomSound() 
    {
        if (!_flag_R)
        {
            _RandomSounds.pitch = Random.Range(0.5f, 1.5f);
            _RandomSounds.Play();
            _flag_R = true;
        }
    }

}
