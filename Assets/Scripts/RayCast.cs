using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{
    float myRayDistance = .6f;

    void Update()
    {
        // 1 Declare my Ray - decting the ground 
        Ray myRay = new Ray(transform.position, Vector3.down);

        Debug.DrawRay(myRay.origin, myRay.direction * myRayDistance, Color.cyan);

        if(Physics.Raycast(myRay, myRayDistance))
        {
            print("WE TOUCHING THE GROUND");
        }
        else
        {
            print("WE ARE AIRBORNE");
            transform.Rotate(0, 1f, 0);
        }
    }
}
