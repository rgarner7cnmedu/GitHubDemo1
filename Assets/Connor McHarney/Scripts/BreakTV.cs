using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakTV : MonoBehaviour {
    [SerializeField]
    private GameObject brokenModel;
    public AudioManager audio;

    private void OnCollisionEnter(Collision collision)
    {
        audio.playClip(audio.smash, 1f);
        brokenModel.SetActive(true);
        gameObject.SetActive(false);
    }
}
