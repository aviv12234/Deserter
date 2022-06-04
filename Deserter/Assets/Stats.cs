using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    public int stamina = 4800;
    int stamRunningReduction = 8;//4times walking reduct
    int stamWalkingReduction = 2;
    int stamStandingReduction = 1;//half time waking reduct
    public int water = 600;
    int waterRunningReduction = 8;//4times walking reduct
    int waterWalkingReduction = 2;
    int waterStandingReduction = 1;//half time waking reduct
    public playerMovement play;
    int cnt = 0;
    // Start is called before the first frame update
    public void setWater(int waterRefill)
    {
        water = waterRefill;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(cnt%50==0)//every second
        {
            if(play.isRunning)
            {
                stamina -= stamRunningReduction;
                water -= waterRunningReduction;
            }
            if(play.isWalking)
            {
                stamina -= stamWalkingReduction;
                water -= waterWalkingReduction;
            }
            if(play.isStanding)
            {
                stamina -= stamStandingReduction;
                water -= waterStandingReduction;
            }
            
           
        }
        cnt++;
        Debug.Log(stamina.ToString("0.00"));
        Debug.Log(water.ToString("0.00"));


    }
}
