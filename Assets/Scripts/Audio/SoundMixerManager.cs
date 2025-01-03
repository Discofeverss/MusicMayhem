using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundMixerManager : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;

    public void SetMasterVolume(float level)
    {
        // audioMixer.SetFloat("masterVolume", level); these are commented out because it is the wrong way to approach this
        audioMixer.SetFloat("masterVolume", Mathf.Log10(level) * 20f);
    }
    public void SetSoundFXVolume(float level)
    {
        // audioMixer.SetFloat("soundFXVolume", level);
        audioMixer.SetFloat("soundFXVolume", Mathf.Log10(level) * 20f);
    }
    public void SetMusicVolume(float level)
    {
        //  audioMixer.SetFloat("musicVolume", level);
        audioMixer.SetFloat("musicVolume", Mathf.Log10(level) * 20f);
    }

    public void SetInstrumentPlayingVolume(float level)
    {
        //  audioMixer.SetFloat("arcadeMachinesVolume", level);
        audioMixer.SetFloat("instrumentPlayingVolume", Mathf.Log10(level) * 20f);
    }
}
