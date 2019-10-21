using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bread : MonoBehaviour
{
    bool pickedUpBread;
    public bool breadHasBeenThrow;
    public Rigidbody breadPhysics;
    public Vector3 breadLocationOffset;
    public GameObject Player;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && pickedUpBread == true) 
        {
            this.transform.SetParent(null); //Deparents the bread from the capsule 
            breadPhysics.useGravity = true;
            breadPhysics.isKinematic = false;
            this.breadPhysics.AddForce(Player.transform.forward * 700f); //Throw bread forward
            pickedUpBread = false;
            breadHasBeenThrow = true;

            //Pigeon know bread has been thrown
        }

        //if(breadHasBeenThrow == true)
        //{
          //  SceneManager.LoadScene("WinScene");
        //}
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.transform.name == "Capsule")
        {
            Player = other.transform.gameObject;
            Debug.Log("Picked Up Bread");
            pickedUpBread = true;
            breadHasBeenThrow = false;

            breadPhysics.useGravity = false;
            breadPhysics.isKinematic = true; 
            this.transform.SetParent(other.transform); // Setting the Capsule as the Parent, so bread will follow you
            this.transform.localPosition = breadLocationOffset; //Change the transform of the bread relative to the camera 
            //Disable the collider on the bread 
        }
    }
}
