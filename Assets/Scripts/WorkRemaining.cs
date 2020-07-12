using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkRemaining : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<UnityEngine.UI.Text>().text = "Work Remaining: " + (PlayerFlags.workTimeEnd - TimeKeeper.curTime);
    }
}
