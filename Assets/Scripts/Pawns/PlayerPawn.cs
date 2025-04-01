using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPawn : MonoBehaviour
{
    public Rigidbody rb;
    public Transform tf;

    public float forceMagnitude;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        tf = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveForward()
    {
        Debug.Log("move forward");

        if (rb != null)
        {
            rb.AddForce(tf.forward * forceMagnitude);
        }
    }

    public void MoveBackward()
    {
        Debug.Log("move backward");

        if (rb != null)
        {
            rb.AddForce(tf.forward * -forceMagnitude);
        }
    }

    public void YawClockwise()
    {
        Debug.Log("yaw clockwise");
    }

    public void YawCounterClockwise()
    {
        Debug.Log("yaw counterclockwise");
    }

    public void RollClockwise()
    {
        Debug.Log("roll clockwise");
    }

    public void RollCounterClockwise()
    {
        Debug.Log("roll counterclockwise");
    }

    public void PitchClockwise()
    {
        Debug.Log("pitch clockwise");
    }

    public void PitchCounterClockwise()
    {
        Debug.Log("pitch counterclockwise");
    }
}
