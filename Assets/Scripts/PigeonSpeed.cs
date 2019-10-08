using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PigeonSpeed : MonoBehaviour
{
    public float currentSpeed;
    public float rateOfIncrease;
    public RigidbodyFirstPerson2 playerMovementScript;

    void Start()
    {
        
    }

    void Update()
    {
        if (playerMovementScript.startedMoving == true) // Pigeons will increase speed when player starts moving
        {
            currentSpeed = currentSpeed + (Time.deltaTime * rateOfIncrease);
        }
    }
}
