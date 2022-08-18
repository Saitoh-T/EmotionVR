using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knock : MonoBehaviour
{
    [SerializeField] private AudioSource _knock1;
    IEnumerator Wait;

    void Start() 
    {
        Wait = wait();
    }
    
    public void SoundPlay() 
    {
        _knock1.Play();
        Wait = wait();
        StartCoroutine(Wait);
        Debug.Log("AA");
        _knock1.Play();
    }

    private IEnumerator wait() 
    {
        yield return new WaitForSeconds(2f);
    }
}
