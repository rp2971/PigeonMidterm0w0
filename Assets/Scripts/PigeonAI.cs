using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PigeonAI : MonoBehaviour
{
    public GameObject Capsule;
    public GameObject PigeonSpeed;
    public float pigeonSpeed; // (initial? pigeon speed)
    RigidbodyFirstPerson2 playerMovementScript;
    PigeonSpeed pigeonSpeedScript;

    void Start()
    {
        Capsule = GameObject.Find("Capsule"); // at the start of the game, the pigeons will find the player
        playerMovementScript = Capsule.GetComponent<RigidbodyFirstPerson2>(); // getting the player move script 
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
        transform.position = Vector3.MoveTowards(transform.position, Capsule.transform.position, step);
        transform.LookAt(Capsule.transform, Vector3.up);
        }

        pigeonSpeed = pigeonSpeedScript.currentSpeed;
    }
}
