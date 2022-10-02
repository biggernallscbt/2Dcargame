using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public Rigidbody2D backTire;
    public Rigidbody2D frontTire;
    public float speed;
    void FixedUpdate()
    {
        if (Input.GetKey("d"))
        {

            frontTire.AddTorque(speed * -1 * Time.deltaTime);
            backTire.AddTorque(speed * -1 * Time.deltaTime);
        }
        if (Input.GetKey("a"))
        {

            frontTire.AddTorque(speed * 1 * Time.deltaTime);
            backTire.AddTorque(speed * 1 * Time.deltaTime);
        }
    }
}
