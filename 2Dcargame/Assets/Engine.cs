using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engine : MonoBehaviour
{
    public float rpm;
    public float rpmLimit;
    public float idleRpm = 800;
    public Rigidbody2D rb;


    void FixedUpdate()
    {
        float velocity = Mathf.Round(rb.velocity.magnitude * 3.6f);
        Debug.Log(velocity);


    }
}
