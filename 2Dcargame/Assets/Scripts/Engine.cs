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
    public int gear;
    public int numberOfGears;
    public bool engineStarted;


    private void Start()
    {
        engineStarted = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown("x"))
        {
            gear++;
        }

        if (Input.GetKeyDown("z"))
        {
            gear--;
        }

        gear = Mathf.Clamp(gear, -1, numberOfGears);

        if (Input.GetKeyDown("v"))
        {
            engineStarted = true;
        }

        if (engineStarted)
        {
            rpm = idleRpm;
        }
    }

    void FixedUpdate()
    {
        //KM_H = Mathf.Round(rb.velocity.magnitude * 3.6f);
        //Debug.Log(KM_H + "Km/H");

        
        if (Input.GetKey("d"))
        {
            rpm += 50;
        }
    }
}
