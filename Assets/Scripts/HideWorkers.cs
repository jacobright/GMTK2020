using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideWorkers : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.activeInHierarchy && TimeKeeper.curTime == 9) {
            this.gameObject.SetActive(false);
        }   
    }
}
