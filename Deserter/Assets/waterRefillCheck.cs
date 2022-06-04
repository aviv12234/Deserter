using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterRefillCheck : MonoBehaviour
{
    public Transform trans;
    public Stats statistics;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (trans.position.y<=5)//lowest height for player to not touch water
        {
           
            statistics.setWater(600);//max water
        }
        
    }
}
