using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerDetection : MonoBehaviour
{
    void onCollisionEnter(Collision col)
    {
        Debug.Log("any collision detected");
        if(col.gameObject.name=="player")
        {
            Debug.Log("player detected");

        }
    }


    void Update()
    {
        
    }
}
