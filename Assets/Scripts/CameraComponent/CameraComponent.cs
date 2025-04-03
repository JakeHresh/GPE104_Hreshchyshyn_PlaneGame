using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraComponent : MonoBehaviour
{
    public Transform cameraTransform;

    public Transform targetTransform;

    public float minOffset;

    public float maxOffset;

    public float currentOffset;

    // Start is called before the first frame update
    void Start()
    {
        currentOffset = minOffset;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movePosition = targetTransform.position - cameraTransform.position;



        cameraTransform.LookAt(targetTransform);
    }

    public void ChangeCameraOffset(float amount)
    {
        currentOffset += amount * Time.deltaTime;

        currentOffset = Mathf.Clamp(currentOffset, minOffset, maxOffset);
    }
}
