using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PigeonBread : MonoBehaviour
{
    public Bread myBreadScript;
    public PigeonAI myPigeonAIScript;
    GameObject bread; //my bread object in the gamespace
    void Start()
    {
        bread = GameObject.Find("perfectbread");
        myBreadScript = bread.GetComponent<Bread>();
        myPigeonAIScript = GetComponent<PigeonAI>();
    }

    void Update()
    {
        if (myBreadScript.breadHasBeenThrow == true)
        {
            myPigeonAIScript.pigeonTarget = bread;  
        }
    }
}
