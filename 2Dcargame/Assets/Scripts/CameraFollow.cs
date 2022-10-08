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
    public float minZ;
    public float maxZ;


    void Update()
    {
        transform.position = car.position + offset;

        elapsedTime += Time.deltaTime;
        percentageComplete = elapsedTime / desiredDuration;
    }

    public void zoom(float KM_H)
    {
        mainCamera.orthographicSize = Mathf.Clamp(Mathf.Lerp(transform.position.z, 3 + KM_H / 5, percentageComplete), minZ, maxZ);
    }
}
