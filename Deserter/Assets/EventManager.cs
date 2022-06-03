using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public delegate void DeathScreen();
    public static event DeathScreen onDeath;
    // Start is called before the first frame update
    public Stats statistics;
    void stamina0()
    {
        if(statistics.stamina==0)
        {
            if(onDeath!=null)
            {
                onDeath();
            }
        }
    }
    void water0()
    {
        if (statistics.water == 0)
        {
            if (onDeath!= null)
            {
                onDeath();
            }
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
