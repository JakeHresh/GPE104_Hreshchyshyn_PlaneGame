using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIPawn : MonoBehaviour
{
    public Rigidbody rb;

    public Transform tf;

    public float force;

    public float speed;

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

    public void MoveRigidbody(Vector3 direction)
    {
        rb.AddForce(direction * force);
    }

    public void MoveTransform(Vector3 direction)
    {
        tf.position += direction * speed * Time.deltaTime;
    }
}
