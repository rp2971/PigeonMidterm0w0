using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleRotate : MonoBehaviour
{
    public float rotationSpeed = 1;
    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(transform.up * rotationSpeed);
    }
}