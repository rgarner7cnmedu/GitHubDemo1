using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushObjectOnActive : MonoBehaviour {
    private Rigidbody _rb;
    public float explosionForce = 5f;
    private Vector3 explosionPosition;
    public float explosionRadius = 5f;
    public Transform explosionLocation;
	// Use this for initialization
	void Awake () {
        _rb = GetComponent<Rigidbody>();
        explosionPosition = explosionLocation.position;
        _rb.AddExplosionForce(explosionForce, explosionPosition, explosionRadius);
	}
	
	// Update is called once per frame
	void Update () {
	}
}
