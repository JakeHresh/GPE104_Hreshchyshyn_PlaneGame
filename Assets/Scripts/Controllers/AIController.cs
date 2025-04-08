using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIController : MonoBehaviour
{
    public AIPawn pawn;

    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInputs();
    }

    public void ProcessInputs()
    {
        // MoveRigidbody();

        MoveTransform();
    }

    public void MoveRigidbody()
    {
        Vector3 directionToTarget = target.position - pawn.transform.position;

        directionToTarget = directionToTarget.normalized;

        pawn.MoveRigidbody(directionToTarget);
    }

    public void MoveTransform()
    {
        Vector3 directionToTarget = target.position - pawn.transform.position;

        directionToTarget = directionToTarget.normalized;

        pawn.MoveTransform(directionToTarget);
    }
}
