using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyVehicle : MonoBehaviour
{
    public Rigidbody thisRigidbody;
    public Vector3 inputVector;
    public float pushSpeed = 2;
    public float torqueSpeed = 2;

   
    void Start()
    {
        thisRigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        inputVector.x = Input.GetAxis("Horizontal");
        inputVector.y = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        thisRigidbody.AddForce(transform.forward * inputVector.y * pushSpeed, ForceMode.Impulse);
        thisRigidbody.AddTorque(transform.up * inputVector.x * torqueSpeed, ForceMode.Impulse);

        //torque is for rotation
        //transform.forward = new Vector3(0, 0, 1); // its 0,0,1 relative to where you object is facing
    }
}
