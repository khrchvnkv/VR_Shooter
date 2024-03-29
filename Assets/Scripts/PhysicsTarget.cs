﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsTarget : MonoBehaviour
{
    public float maxSpeedValue = 10.0f;
    public AudioSource audioSource;
    private Rigidbody rb;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision other) 
    {
        float clampedVolumeValue = 1 - Mathf.Clamp01((maxSpeedValue - rb.velocity.sqrMagnitude) / maxSpeedValue);
        audioSource.volume = clampedVolumeValue;
        audioSource.Play();
    }
}
