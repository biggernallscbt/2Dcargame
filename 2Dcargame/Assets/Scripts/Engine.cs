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
    public bool done;




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

        if (Input.GetKeyDown("v") && !engineStarted)
        {
            engineStarted = true;
            done = true;
        }

        if (Input.GetKeyDown("v") && engineStarted)
        {
            engineStarted = false;
            done = false;
        }

        if (done)
        {
            done = false;
            rpm += idleRpm;
        }

        if (!engineStarted && rpm <= 0)
        {
            //rpm -= 50;
        }
    }

    void FixedUpdate()
    {
        //KM_H = Mathf.Round(rb.velocity.magnitude * 3.6f);
        //Debug.Log(KM_H + "Km/H");

        
        if (Input.GetKey("d") && engineStarted)
        {
            rpm += 50;
        }

        if (Input.GetKey("a") && engineStarted)
        {
            rpm -= 50;
        }

        if (Input.GetKey("a") == false || Input.GetKey("d") && engineStarted)
        {
            rpm -= 50;
        }
    }
}
