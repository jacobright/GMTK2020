using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeKeeper : MonoBehaviour
{
    public static int curTime = 0;
    private int curTick = 0;
    
    void Start()
    {
        curTick = 0;
        curTime = 0;
    }

    void FixedUpdate()
    {
        curTick += 1;

        if (curTick % 3000 == 0) { // 50 = 1 sec, 3000 = 1 min
            curTime += 1;
        }

        if (curTime == 2) {
            print("LUNCHTIIIIIME");
        }
        if (curTime == 5) {
            print("LUNCHTIME OVER >:n(");
        }

        if (curTime == 8) {
            print("OVERTIME!");
        }

        if (curTime == 13) {
            print("END DAY // LOSE");
        }
        
    }
}
