using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class updown : MonoBehaviour
{

    public float range = 1.0f;
    public float speed = 0.5f;
    private float startingY;
    public bool bMoveUp = true;

    private void Start()
    {
        startingY = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y >= startingY + range)
            bMoveUp = false;
        else if (transform.position.y <= startingY - range)
            bMoveUp = true;

        if (bMoveUp)
            transform.position += Vector3.up * speed * Time.deltaTime;
        else
            transform.position += Vector3.down * speed * Time.deltaTime;
    }
}