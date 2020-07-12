using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnger : MonoBehaviour
{
    [Range(0,14)]
    public int rage = 0;

    public GameObject meter;

    public Sprite[] emotes;
    public GameObject emoteObj;

    void Start()
    {
        rage = 0;

        PlayerFlags.angerLevel = 0;
        PlayerFlags.canInteract = true;
        PlayerFlags.gotLunch = false;
        PlayerFlags.skippedLunch = false;
        PlayerFlags.nevermindCounter = 0;
        PlayerFlags.complimentCounter = 0;
        PlayerFlags.workTimeEnd = 9;
    }

    void Update()
    {
        //set the anger level
        rage = PlayerFlags.angerLevel;

        // move bar
        meter.transform.localScale = new Vector3((rage/14.0f), meter.transform.localScale.y, meter.transform.localScale.z);
        
        if (GameObject.FindGameObjectsWithTag("Phone").Length > 1 && HoverPlayer.GetRage() > 2) {
            DialogueBox.SetDialogue(GlobalDialogues.initiation_desk_interact_phone[HoverPlayer.GetRage()], 2.0f);
            Destroy(GameObject.FindGameObjectWithTag("Phone"));
        }


        ChangeEmotes();
    }


    void ChangeEmotes() {
        // CHANGE EMOTES
        if (rage >= 14) {
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
    }

}
