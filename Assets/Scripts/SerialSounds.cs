using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SerialSounds : MonoBehaviour
{
    [SerializeField] AudioSource[] _Sounds;
    [SerializeField] float _Time = 0.5f;

    public void SerialSound() 
    {
        StartCoroutine(serial());
    }

    IEnumerator serial()
    {
        foreach (var _Sound in _Sounds)
        {
            _Sound.Play();
            yield return new WaitForSeconds(_Time);
        }
    }
}
