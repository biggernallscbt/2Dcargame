using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Speedometer : MonoBehaviour
{
    private const float maxSpeedAngle = -20f;
    private const float zeroSpeedAngle = 210f;
    public Transform needleTransform;
    public Rigidbody2D car;
    public TextMeshProUGUI Km_HText;

    private void Awake()
    {
        needleTransform = transform.Find("Needle");
    }

    private void Update()
    {
        needleTransform.eulerAngles = new Vector3(0, 0, GetSpeedRotation(car.velocity.magnitude * 3.6f));

        Km_HText.text = ((int)(car.velocity.magnitude * 3.6f)).ToString();
    }

    public float GetSpeedRotation(float speed)
    {
        float totalAngleSize = zeroSpeedAngle - maxSpeedAngle;

        return zeroSpeedAngle - speed / 200 * totalAngleSize;
    }


}
