using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float Movespeed = 8f;
    private float Turnspeed = 120;

    private void Update()
    {
        float x = Input.GetAxis("Horizontal");  // a,d  arrows  gamepad
        float y = Input.GetAxis("Vertical");    // w,s  arrows  gamepad

        this.transform.Translate(Vector3.forward * y * Movespeed * Time.deltaTime);
        this.transform.Rotate(Vector3.up * x * Turnspeed * Time.deltaTime);
    }
}
