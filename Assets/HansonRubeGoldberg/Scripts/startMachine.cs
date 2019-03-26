using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startMachine : MonoBehaviour
{

    [SerializeField] private Animator lengthenRope;
    [SerializeField] private Animator shortenRope;
    [SerializeField] private Animator tiltPlank;
    //[SerializeField] private Animation lowerPlatform;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Start");
        lengthenRope.enabled = true;
        shortenRope.enabled = true;
        tiltPlank.enabled = true;
        GetComponent<Animator>().enabled = true;
    }
}
