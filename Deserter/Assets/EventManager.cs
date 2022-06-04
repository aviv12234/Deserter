using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EventManager : MonoBehaviour
{

    // Start is called before the first frame update
    public Stats statistics;
    void stamina0()
    {
        if(statistics.stamina==0)
        {
            SceneManager.LoadScene("StaminaMenu");
        }
    }
    void water0()
    {
        if (statistics.water == 0)
        {
            SceneManager.LoadScene("WaterMenu");
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
