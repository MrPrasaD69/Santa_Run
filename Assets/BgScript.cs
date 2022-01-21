using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class BgScript : MonoBehaviour
{
    public static BgScript BgInstance;
    public AudioSource Audio;

    private void Awake()
    {
        if (BgInstance != null && BgInstance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        BgInstance = this;
        DontDestroyOnLoad(this);
    }
}
