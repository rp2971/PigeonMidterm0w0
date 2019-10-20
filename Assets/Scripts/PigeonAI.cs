using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PigeonAI : MonoBehaviour
{
    public GameObject pigeonTarget;
    public GameObject PigeonSpeed;
    public float pigeonSpeed; // (initial? pigeon speed)
    RigidbodyFirstPerson2 playerMovementScript;
    PigeonSpeed pigeonSpeedScript;

    void Start()
    {
        pigeonTarget = GameObject.Find("Capsule"); // at the start of the game, the pigeons will find the player
        playerMovementScript = pigeonTarget.GetComponent<RigidbodyFirstPerson2>(); // getting the player move script 
        PigeonSpeed = GameObject.Find("PigeonSpeed");
        pigeonSpeedScript = PigeonSpeed.GetComponent<PigeonSpeed>();
    }

   
    void Update()
    {
        //Wait for the player to move
        if (playerMovementScript.startedMoving == true)
        {
        // Pigeon movement
        float step = pigeonSpeed * Time.deltaTime; // calculate distance to move
        transform.position = Vector3.MoveTowards(transform.position, pigeonTarget.transform.position, step);
        transform.LookAt(pigeonTarget.transform, Vector3.up);
        }

        pigeonSpeed = pigeonSpeedScript.currentSpeed;
    }
}
