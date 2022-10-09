using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public Rigidbody2D backTire;
    public Rigidbody2D frontTire;
    public Rigidbody2D rb;
    public float speed;
    public string drivetrain;
    private float velocity;
    public CameraFollow _cameraFollow;

    void FixedUpdate()
    {

       
        //awd

        if (Input.GetKey("d") && drivetrain == "awd")
        {

            frontTire.AddTorque(speed * -1 * Time.deltaTime);
            backTire.AddTorque(speed * -1 * Time.deltaTime);
        }
        if (Input.GetKey("a") && drivetrain == "awd")
        {

            frontTire.AddTorque(speed * 1 * Time.deltaTime);
            backTire.AddTorque(speed * 1 * Time.deltaTime);
        }







        //rwd

        if (Input.GetKey("d") && drivetrain == "rwd")
        {    
            backTire.AddTorque(speed * -1 * Time.deltaTime);
        }
        if (Input.GetKey("a") && drivetrain == "rwd")
        {
            backTire.AddTorque(speed * 1 * Time.deltaTime);
        }






        //fwd
        
        if (Input.GetKey("d") && drivetrain == "fwd")
        {
            frontTire.AddTorque(speed * -1 * Time.deltaTime);
        }
        if (Input.GetKey("a") && drivetrain == "fwd")
        {
            frontTire.AddTorque(speed * 1 * Time.deltaTime);
        }
    }
    private void Update()
    {
        velocity = (rb.velocity.magnitude);

        _cameraFollow.zoom(velocity);
    }

}
