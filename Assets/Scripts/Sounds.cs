using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    [SerializeField] AudioSource _Sounds; 
    [SerializeField] AudioSource _RandomSounds; 

    public void Sound()
    {
        _Sounds.Play();
    }

    public void RandomSound() 
    {
        _RandomSounds.pitch=Random.Range(0.5f, 1.5f);
        _RandomSounds.Play();
    }

}
