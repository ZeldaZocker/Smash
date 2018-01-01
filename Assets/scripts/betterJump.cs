﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class betterJump : MonoBehaviour {

    public float fallMultiplier = 2.5f;
    public float lowJumpMultiplier = 2.5f;

    Rigidbody rb;


    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (rb.velocity.y < 0)
        {
            rb.velocity += Vector3.up * Physics.gravity.y * (fallMultiplier - 1) * Time.fixedDeltaTime;
        }
        else if (rb.velocity.y > 0 && !Input.GetKey(KeyCode.Space))
        {
            rb.velocity += Vector3.up * Physics.gravity.y * (lowJumpMultiplier - 1) * Time.fixedDeltaTime;
        }
    }
}
