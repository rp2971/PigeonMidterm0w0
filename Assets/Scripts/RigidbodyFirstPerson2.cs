using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RigidbodyFirstPerson2 : MonoBehaviour
{
    public float moveSpeed;
    public Vector3 inputVector;
    public Rigidbody thisRigidbody;
    public bool startedMoving;
    public float magnitude;

    void Start()
    {
        thisRigidbody = GetComponent<Rigidbody>();
        Cursor.visible = false; 
    }

    public float mouseX;
    public float mouseY;

    void Update()
    {
        magnitude = thisRigidbody.velocity.magnitude;
        if (thisRigidbody.velocity.magnitude > 0.5f)
        {
            startedMoving = true;
        }
        
        // Delta
        mouseX = Input.GetAxis("Mouse X") * 5f;
        mouseY = Input.GetAxis("Mouse Y") * 5f;

        transform.Rotate(0, mouseX, 0);
        Camera.main.transform.Rotate(-mouseY, 0, 0);

        // get keyboard input
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // get the input vector from keyboard 
        // and translate it to vector motion
        inputVector = transform.forward * vertical;
        inputVector += transform.right * horizontal;
    }

    void FixedUpdate()
    {
        // translate to input physics and add some gravity sauce
        thisRigidbody.velocity = inputVector * moveSpeed + Physics.gravity * .69f; 
    }

    void OnCollisionEnter(Collision collision)
    {
         if (collision.transform.tag == "pigeontag")
        {
            Debug.Log("Pigeon cAUGht you");
            SceneManager.LoadScene(sceneName: "EndScene");
        }
    }
}
