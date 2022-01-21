using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SFXManager : MonoBehaviour
{
    public AudioSource Audio;
    public AudioClip Click;

    public static SFXManager sfxInstance;

    private void Awake()
    {
        if(sfxInstance !=null && sfxInstance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        sfxInstance = this;
        DontDestroyOnLoad(this);
    }
}
