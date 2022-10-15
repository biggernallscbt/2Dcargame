using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speedometer : MonoBehaviour
{
    private const float maxSpeedAngle = -20f;
    private const float zeroSpeedAngle = 210f;
    private Transform needleTransform;
    private float maxSpeed;
    public float speed;

    private void Awake()
    {
        needleTransform = transform.Find("Needle");
        speed = 0f;
        maxSpeed = 200f; 
    }

    private void Update()
    {
        speed += 30f * Time.deltaTime;
        if (speed >= maxSpeed)
        {
            speed--;
        }

    }

    public float GetSpeedRotation(float speed)
    {
        float totalAngleSize = zeroSpeedAngle - maxSpeedAngle;

        float speedNormalized = speed / maxSpeed;

        return zeroSpeedAngle - speedNormalized * totalAngleSize;
    }


}
