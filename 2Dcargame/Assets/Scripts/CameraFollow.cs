using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform car;
    public Vector3 offset;
    public Camera mainCamera;
    public float desiredDuration = 0.5f;
    private float elapsedTime;
    private float percentageComplete;


    void Update()
    {
        transform.position = car.position + offset;

        elapsedTime += Time.deltaTime;
        percentageComplete = elapsedTime / desiredDuration;
    }

    public void zoom(float velocity)
    {
        float KM_H = velocity * 3.6f;

        Debug.Log(KM_H);


        if (KM_H <= 50) 
        { 
            mainCamera.orthographicSize = (3000 + KM_H * KM_H) / 1000;
        }
        else
        {
            mainCamera.orthographicSize = (Mathf.Sqrt(KM_H) + 2500) / 1000;
        }
        
    }
}
