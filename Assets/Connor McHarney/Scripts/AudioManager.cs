using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class AudioManager : MonoBehaviour
{
    public AudioClip spring;
    public AudioClip roll;
    public AudioClip punch;
    public AudioClip smash;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void playClip(AudioClip clip, float volume)
    {
        audioSource.PlayOneShot(clip, volume);
    }
}