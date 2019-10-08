using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PigeonSpawner : MonoBehaviour
{
    public GameObject spawnedPigeon;
    public int maxPigeon = 10;
    public float spawnTimeInterval;
    public float currentTimeCounter;
    public RigidbodyFirstPerson2 playerMovementScript;

    void Start()
    {
        currentTimeCounter = spawnTimeInterval;
        SpawnPigeons();
    }

    void SpawnPigeons()
    {
        for (int i = 0; i < maxPigeon; i++)
        {
            Instantiate(spawnedPigeon, transform.position + Random.insideUnitSphere * 10 + Vector3.up * 5, Quaternion.Euler(0, 0, 0));
        }
    }

    void Update()
    {
        //Time counts down from the maximum interval 
        //currentTimeCounter = currentTimeCounter - Time.deltaTime;

        if (playerMovementScript.startedMoving == true) //Pigeons will begin to spawn once the player starts moving
        {
            currentTimeCounter -= Time.deltaTime;

            //Then when timer reaches zero, count down from 5 and Instantiate pigeon
            if (currentTimeCounter < 0)
            {
                //make more pigeons and reset the timer
                SpawnPigeons();
                currentTimeCounter = spawnTimeInterval;
            }
        }
    }
}
