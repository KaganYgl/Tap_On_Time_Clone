using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource Source;
    [SerializeField] AudioClip SuccessSFX, FailSFX, DamageSFX;


    
    public void PlaySFX()
    {
        Source.clip = DamageSFX;
        Source.Play();
    }


    public void PlaySFX(bool isSuccessful)
    {
        if (isSuccessful)
        {
            Source.clip = SuccessSFX;
        }
        else
        {
            Source.clip = FailSFX;
        }

        Source.Play();
    }
}
