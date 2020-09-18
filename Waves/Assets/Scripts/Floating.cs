using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floating : MonoBehaviour
{
    public Rigidbody rigidbody;
    public float depth = 1f;
    public float disp = 3f;
    public int numberOfFloatingPoints = 1;
    public float waterDrag = 0.99f;
    public float waterAngularDrag = 0.5f;


    private void FixedUpdate()
    {
        rigidbody.AddForceAtPosition(Physics.gravity / numberOfFloatingPoints, transform.position, ForceMode.Acceleration);
        float waveHeight = Wave.instance.WaveHeight(transform.position.x);
        if(transform.position.y < waveHeight)
        {
            float dispMult = Mathf.Clamp01((waveHeight-transform.position.y) / depth) * disp;
            rigidbody.AddForceAtPosition(new Vector3(0f, Math.Abs(Physics.gravity.y) * dispMult, 0f), transform.position, ForceMode.Acceleration);
            rigidbody.AddForce(dispMult * -rigidbody.velocity * waterDrag * Time.fixedDeltaTime, ForceMode.VelocityChange);
            rigidbody.AddTorque(dispMult * -rigidbody.angularVelocity * waterAngularDrag * Time.fixedDeltaTime, ForceMode.VelocityChange);
        }
    }
}
