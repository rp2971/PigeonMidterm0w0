using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRayCast : MonoBehaviour
{
    public GameObject prefabBrush;
    void Update()
    {
        // Step One: Define the Ray
        // ScreenPoint to ray is the technique

        Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition); // standard implementation of the technique

        // Step Two: Define Max Raycast Distance
        float maxRaycastDistance = 1000f; // just a big number to catch whatever

        // Step Three: Visualize the Raycast again
        Debug.DrawRay(mouseRay.origin, mouseRay.direction * maxRaycastDistance, Color.red);

        // Lets do something w/ this
        RaycastHit mouseHit = new RaycastHit();

        //Step Five: Shoot the raycast!!
        if(Physics.Raycast(mouseRay, out mouseHit, maxRaycastDistance))
        {
            // Step Six: If true... if we hit the canvas... move the prefab 'brush' to where the pointer is
            prefabBrush.transform.position = mouseHit.point;

            //Step Seven: What if we want the tag of the object we hit?
            Debug.Log(mouseHit.transform.tag);

            //Step Eight: Clone an object during the game
            if (Input.GetMouseButton(0))
            {
                GameObject instantiatedPaint;
                instantiatedPaint = Instantiate(prefabBrush, mouseHit.point, Quaternion.Euler(0, 0, 0));
            }
        }
    }
}
