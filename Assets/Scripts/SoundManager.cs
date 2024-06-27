using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [Header("Audio Source")]
    public AudioSource source;
    [Header("Audio Clips")]
    public AudioClip wings;
    public AudioClip die;
    public AudioClip hit;
    public AudioClip point;


    public void PlayOneShotHelper(AudioClip clip)
    {
        if(source != null)
        {
            source.PlayOneShot(clip);
        }     
    }
}
