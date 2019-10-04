using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maze : MonoBehaviour
{
 
    void Update()
    {
        // Step One: Define the Ray

        Ray playerRay = new Ray(transform.position, transform.forward);

        // Step Two: Define maximum Raycast distance
        float maxRayDistance = 1f; // just a bit in front

        // Step Three: Visualize it again
        Debug.DrawRay(playerRay.origin, playerRay.direction * maxRayDistance, Color.red);

        //Step Four: Shootthe ray and let the player navigate the maze
        //Raycast is currently false. It's not hitting anything

        if(Physics.Raycast(playerRay, maxRayDistance))
        {
            // if the raycast is true,it hits something... a wall in front of us.

            // when that happens..
            // turning logic takes place

            int randomNumber = Random.Range(0, 100); // RNG b/n 0 and 100
            {
                if(randomNumber < 50)
                {
                    // 50 % chance that it will rotate 90 degress to the left
                    transform.Rotate(0f, -90f, 0f);
                }
                else
                {
                    transform.Rotate(0f, 90f, 0f);
                }
            }
        }
        else
        {
            transform.Translate(0f, 0f, 1 * Time.deltaTime);
        }
    }
}
