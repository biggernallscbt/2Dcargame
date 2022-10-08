using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engine : MonoBehaviour
{
    public float rpm;
    public float rpmLimit;
    public float idleRpm = 800;
    public Rigidbody2D rb;
    public static float KM_H;
    public CameraFollow _cameraFollow;


    void FixedUpdate()
    {
        KM_H = Mathf.Round(rb.velocity.magnitude * 3.6f);
        Debug.Log(KM_H + "Km/H");

        
    }
    void Update()
    {
        _cameraFollow.zoom(rb.velocity.magnitude);
    }
}
