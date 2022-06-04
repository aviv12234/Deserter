using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaterBar : MonoBehaviour
{
    public Stats stamStatistics;
    int cnt = 0;


    // Start is called before the first frame update

    public Slider slider;

    public void SetStamina(float stamina)
    {
        slider.value = stamina;
    }

    public void SetMaxStamina(float stamina)
    {
        slider.maxValue = stamina;
        slider.value = stamina;
    }

    void Start()
    {
        SetMaxStamina(stamStatistics.water);
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (cnt % 50 == 0)
        {
            SetStamina(stamStatistics.water);
        }
        cnt++;


    }
}