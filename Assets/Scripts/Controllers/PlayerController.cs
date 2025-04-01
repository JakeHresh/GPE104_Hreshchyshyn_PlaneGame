using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public PlayerPawn pawn;

    public KeyCode moveForwardKey;
    public KeyCode moveBackwardKey;
    public KeyCode yawClockwise;
    public KeyCode yawCounterClockwise;
    public KeyCode rollClockwise;
    public KeyCode rollCounterClockwise;
    public KeyCode pitchClockwise;
    public KeyCode pitchCounterClockwise;

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
        if (Input.GetKey(moveForwardKey))
        {
            // move forward
            pawn.MoveForward();
        }
        if (Input.GetKey(moveBackwardKey))
        {
            // move backward
            pawn.MoveBackward();
        }
        if (Input.GetKey(yawClockwise))
        {
            // yaw clockwise
            pawn.YawClockwise();
        }
        if (Input.GetKey(yawCounterClockwise))
        {
            // yaw counterclockwise
            pawn.YawCounterClockwise();
        }
        if (Input.GetKey(rollClockwise))
        {
            // roll clockwise
            pawn.RollClockwise();
        }
        if (Input.GetKey(rollCounterClockwise))
        {
            // roll counterclockwise
            pawn.RollCounterClockwise();
        }
        if (Input.GetKey(pitchClockwise))
        {
            // pitch clockwise
            pawn.PitchClockwise();
        }
        if (Input.GetKey(pitchCounterClockwise))
        {
            // pitch counterclockwise
            pawn.PitchCounterClockwise();
        }
    }
}
