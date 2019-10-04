using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PigeonSpeed : MonoBehaviour
{
    public float currentSpeed;
    public float rateOfIncrease;
    void Start()
    {
        
    }

    void Update()
    {
        currentSpeed = currentSpeed + (Time.deltaTime * rateOfIncrease);
    }
}
