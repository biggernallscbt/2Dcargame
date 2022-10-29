using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engine : MonoBehaviour
{
    public float rpm;
    public float rpmLimit;
    public float idleRpm;
    public Rigidbody2D rb;
    public static float KM_H;
    public CameraFollow _cameraFollow;
    public int gear;
    public int numberOfGears;
    public bool engineStarted;



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
 
        }

        if (Input.GetKeyDown("v") && engineStarted)
        {
            engineStarted = false;
            
        }

        

        
    }

    
    
}
