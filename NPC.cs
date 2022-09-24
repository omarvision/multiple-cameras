using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    private enum Moves
    {
        stop = 0,
        forward = 8,
        backward = -8
    }
    private enum Turns
    {
        stop = 0,
        left = -120,
        right = 120
    }

    private Moves moving;
    private Turns turning;

    private void Start()
    {
        InvokeRepeating("DecideMove", 1, 1);
        InvokeRepeating("DecideTurn", 1, 1);
    }
    private void Update()
    {
        this.transform.Translate(Vector3.forward * (int)moving * Time.deltaTime);
        this.transform.Rotate(Vector3.up * (int)turning * Time.deltaTime);
    }
    private void DecideMove()
    {
        int r = Random.Range(0, 100);
        if (r >= 0 && r < 10)
            moving = Moves.forward;
        else if (r >= 10 && r < 15)
            moving = Moves.backward;
        else if (r >= 20 && r < 30)
            moving = Moves.stop;
    }
    private void DecideTurn()
    {
        int r = Random.Range(0, 100);
        if (r >= 0 && r < 10)
            turning = Turns.left;
        else if (r >= 10 && r < 20)
            turning = Turns.right;
        else if (r >= 20 && r < 30)
            turning = Turns.stop;
    }
}
