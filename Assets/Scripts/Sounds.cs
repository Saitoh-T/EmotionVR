using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSounds : MonoBehaviour
{
    [SerializeField] AudioSource _doorSounds; 
    [SerializeField] AudioSource _knockSounds; 

    public void doorSound()
    {
        _doorSounds.Play();
    }

    public void knockSound() 
    {
        _knockSounds.pitch=Random.Range(0.8f, 1.2f);
        _knockSounds.Play();
    }

}
