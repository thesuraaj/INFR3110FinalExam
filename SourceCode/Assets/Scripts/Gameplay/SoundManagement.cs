using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class SoundManagement : MonoBehaviour
{
    public static SoundManagement Instance;

    public Sound[] music, sfx;
    public AudioSource musicSource, sfxSource;

    public void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    private void Start()
    {
        PlayMusic("BackgroundMusic");

    }

    public void PlayMusic(string name)
    {
        Sound soundArray = Array.Find(music, x => x.name == name);

        if (soundArray == null)
        {
            Debug.Log("Sound Not Found");
        }
        else
        {
            musicSource.clip = soundArray.clip;
            musicSource.Play();
        }
    }
    public void PlaySFX(string name)
    {
        Sound soundArray = Array.Find(sfx, x => x.name == name);

        if (soundArray == null)
        {
            Debug.Log("Sound Not Found");
        }
        else
        {
            sfxSource.PlayOneShot(soundArray.clip);
        }
    }

}

