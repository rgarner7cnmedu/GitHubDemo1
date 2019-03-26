using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballupdate : MonoBehaviour {
	// Update is called once per frame
	void Update () {
        transform.position += transform.up * 0.001f;
	}
}
