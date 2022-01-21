using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class AudioFXManager : MonoBehaviour
{
    public Text toggleAudioFxtxt;

    public void Start()
    {
        if (BgScript.BgInstance.Audio.isPlaying)
        {
            toggleAudioFxtxt.text = "OFF";
        }
        else
        {
            toggleAudioFxtxt.text = "ON";
        }
    }
    
    public void MusicToggle()
    {
        if(BgScript.BgInstance.Audio.isPlaying)
        {
            BgScript.BgInstance.Audio.Pause();
            toggleAudioFxtxt.text = "ON";
        }
        else
        {
            BgScript.BgInstance.Audio.Play();
            toggleAudioFxtxt.text = "OFF";
        }
    }
}
