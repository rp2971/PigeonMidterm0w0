using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PigeonAI : MonoBehaviour
{
    public GameObject Capsule;
    public float pigeonSpeed; // (initial? pigeon speed)

    void Start()
    {
       Capsule = GameObject.Find("Capsule"); // at the start of the game, the pigeons will find the wayPoint
    }

   
    void Update()
    {
        float step = pigeonSpeed * Time.deltaTime; // calculate distance to move
        transform.position = Vector3.MoveTowards(transform.position, Capsule.transform.position, step);
    }
}
