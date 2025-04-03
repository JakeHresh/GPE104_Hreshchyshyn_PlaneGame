using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPawn : MonoBehaviour
{
    public Rigidbody rb;
    public Transform tf;

    public CameraComponent cameraComponent;

    public float forceMagnitude;

    public float rotationSpeed;

    public float cameraOffsetChangeRate;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        tf = GetComponent<Transform>();
        cameraComponent = GetComponent<CameraComponent>();
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

        if (tf != null)
        {
            tf.Rotate(new Vector3(0, 1, 0) * rotationSpeed * Time.deltaTime);
        }
    }

    public void YawCounterClockwise()
    {
        Debug.Log("yaw counterclockwise");

        if (tf != null)
        {
            tf.Rotate(new Vector3(0, 1, 0) * -rotationSpeed * Time.deltaTime);
        }
    }

    public void RollClockwise()
    {
        Debug.Log("roll clockwise");

        if (tf != null)
        {
            tf.Rotate(new Vector3(0, 0, 1) * -rotationSpeed * Time.deltaTime);
        }
    }

    public void RollCounterClockwise()
    {
        Debug.Log("roll counterclockwise");

        if (tf != null)
        {
            tf.Rotate(new Vector3(0, 0, 1) * rotationSpeed * Time.deltaTime);
        }
    }

    public void PitchClockwise()
    {
        Debug.Log("pitch clockwise");

        if (tf != null)
        {
            tf.Rotate(new Vector3(1, 0, 0) * rotationSpeed * Time.deltaTime);
        }
    }

    public void PitchCounterClockwise()
    {
        Debug.Log("pitch counterclockwise");

        if (tf != null)
        {
            tf.Rotate(new Vector3(1, 0, 0) * -rotationSpeed * Time.deltaTime);
        }
    }

    public void IncreaseCameraOffset()
    {
        cameraComponent.ChangeCameraOffset(cameraOffsetChangeRate);
    }

    public void DecreaseCameraOffset()
    {
        cameraComponent.ChangeCameraOffset(-cameraOffsetChangeRate);
    }
}
