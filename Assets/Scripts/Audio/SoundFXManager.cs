using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundFXManager : MonoBehaviour
{
    public static SoundFXManager Instance;

    [SerializeField] private AudioSource soundFXObject;

    [SerializeField] private AudioClip buttonClickSound;


    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }


    public void PlaySoundFXClip(AudioClip audioClip, Transform spawnTransform, float volume) //Called in need of a short sound effect e.g. button clicked
    {
        AudioSource audioSource = Instantiate(soundFXObject, spawnTransform.position, Quaternion.identity); // The audio source only appears when it is called

        audioSource.clip = audioClip;

        audioSource.volume = volume;

        audioSource.Play();

        float clipLength = audioSource.clip.length;

        Destroy(audioSource.gameObject, clipLength); //The audio source is destroyed when it is no longer needed
    }

    public void PlayButtonClickSound()
    {
        PlaySoundFXClip(buttonClickSound, transform, 0.1f);
    }
}
