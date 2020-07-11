using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnger : MonoBehaviour
{
    [Range(0,14)]
    public static int rage = 0;

    public GameObject meter;

    public Sprite[] emotes;
    public GameObject emoteObj;

    void Start()
    {
        rage = 0;
    }

    void Update()
    {
        meter.transform.localScale = new Vector3((rage/14.0f), meter.transform.localScale.y, meter.transform.localScale.z);

        // CHANGE EMOTES
        if (rage == 14) {
            emoteObj.GetComponent<UnityEngine.UI.Image>().sprite = emotes[6];
        }
        else if (rage >= 12) {
            emoteObj.GetComponent<UnityEngine.UI.Image>().sprite = emotes[5];
        }
        else if (rage >= 10) {
            emoteObj.GetComponent<UnityEngine.UI.Image>().sprite = emotes[4];
        }
        else if (rage >= 6) {
            emoteObj.GetComponent<UnityEngine.UI.Image>().sprite = emotes[3];
        }
        else if (rage >= 4) {
            emoteObj.GetComponent<UnityEngine.UI.Image>().sprite = emotes[2];
        }
        else if (rage >= 1) {
            emoteObj.GetComponent<UnityEngine.UI.Image>().sprite = emotes[1];
        }
        else {
            emoteObj.GetComponent<UnityEngine.UI.Image>().sprite = emotes[0];
        }

        // AngerClick();
    }

    // void AngerClick() {

    // }


    // void OnMouseDown() {
    //     if ()
    // }
}
