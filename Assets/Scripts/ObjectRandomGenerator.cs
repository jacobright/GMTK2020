using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRandomGenerator : MonoBehaviour
{
    public GameObject obj;
    public float spawnTime;
    public int angerAmt;
    public float audioLength;

    private float spawnWait;
    private GameObject objClone;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnWait += Time.deltaTime;

        if (spawnWait >= spawnTime && TimeKeeper.curTime < 9) {
            if (objClone != null) {
                Destroy(objClone);
            }

            objClone = Instantiate(obj, this.transform.position, this.transform.rotation, this.transform);
            spawnWait = 0;
            PlayerFlags.angerLevel += angerAmt;
        }

        if (spawnWait >= audioLength && obj.tag == "Phone") {
            if (objClone != null) {
                Destroy(objClone);
            }
        }
    }
}
