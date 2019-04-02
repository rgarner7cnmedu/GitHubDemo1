using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PunchGlove : MonoBehaviour {
    private Animator _animator;
    [SerializeField]
    private GameObject target;
    [SerializeField]
    private Transform punchLocation;
    [SerializeField]
    private float pushForce;
    [SerializeField]
    private float pushDelay = 0.15f;
    [SerializeField]
    private float timer_push = 0;
    private bool punched = false;
    [SerializeField]
    private AudioManager audio;
    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void OnCollisionEnter(Collision collision)
    {
        _animator.SetBool("Punch", true);
        if (!punched)
        {
            timer_push = pushDelay;
            punched = true;
            audio.playClip(audio.spring, 1f);
        }
    }


    private void Update()
    {
        if (timer_push > 0)
        {
            timer_push = timer_push - Time.deltaTime;
            if (timer_push <= 0)
            {
                Rigidbody rb = target.GetComponent<Rigidbody>();
                rb.AddForceAtPosition(transform.forward * pushForce, punchLocation.position);
                audio.playClip(audio.punch, 1f);
                audio.playClip(audio.roll, 0.5f);
            }
        }
    }
        


}
