using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Groaning : MonoBehaviour
{
    [SerializeField] AudioSource _Groaning1;
    [SerializeField] AudioSource _Groaning2;
    [SerializeField] AudioSource _Groaning3;
    [SerializeField] GameObject _HorrorFace;
    bool _flag=false;

    public void RandomSound()
    {
        if (!_flag)
        {
            StartCoroutine(StartGroaning());
            _flag = true;
        }
    }

    private IEnumerator StartGroaning() 
    {
        _Groaning1.pitch = 0.5f;
        _Groaning2.pitch = 1.0f;
        _Groaning3.pitch = 1.5f;
        _Groaning1.Play();
        yield return new WaitForSeconds(1.0f);
        _Groaning2.Play();
        yield return new WaitForSeconds(1.0f);
        _Groaning3.Play();

        yield return new WaitForSeconds(1.0f);
        _HorrorFace.SetActive(true);
        yield return new WaitForSeconds(0.15f);
        _HorrorFace.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        _HorrorFace.SetActive(true);
        yield return new WaitForSeconds(0.15f);
        _HorrorFace.SetActive(false); 
        yield return new WaitForSeconds(0.2f);
        _HorrorFace.SetActive(true);
        yield return new WaitForSeconds(0.15f);
        _HorrorFace.SetActive(false);
    }

}