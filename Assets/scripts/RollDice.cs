﻿using UnityEngine;
using System.Collections;

public class RollDice : MonoBehaviour {

    public float thrust;
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rb.AddForce(transform.forward * thrust);
    }
}
