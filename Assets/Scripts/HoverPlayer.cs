using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverPlayer : MonoBehaviour
{



    void OnMouseOver() {
        if (!PlayerFlags.canInteract) {
            return;
        }
        
        if (Input.GetMouseButton(0)) {
            transform.localScale = new Vector3(0.9f, 0.9f, 0.9f);

            // bring up the dialogue box and options, dependent on flags
            DialogueBox.SetDialogue(GetDialogue());
            PlayerFlags.canInteract = false;
            transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);

        }
        else {
            transform.localScale = new Vector3(1.1f, 1.1f, 1.1f);
        }
    }

    void OnMouseExit() {
        transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
    }


    // picks random dialogue bit depending on flags
    public static string GetDialogue() {
        int rage = GetRage();

        if (TimeKeeper.curTime == 0) {
            return GlobalDialogues.initiation_greeting[rage];
        }

        int rand = Random.Range(0,2);
        if (rand == 0)
            return GlobalDialogues.initiation_desk_interact_1[rage];
        else if (rand == 1)
            return GlobalDialogues.initiation_desk_interact_2[rage];
        else
            return GlobalDialogues.initiation_desk_interact_3[rage];

    }




    public static int GetRage() {
        if (PlayerFlags.angerLevel >= 14) {
            return 6;
        }
        else if (PlayerFlags.angerLevel >= 12) {
            return 5;
        }
        else if (PlayerFlags.angerLevel >= 10) {
            return 4;
        }
        else if (PlayerFlags.angerLevel >= 6) {
            return 3;
        }
        else if (PlayerFlags.angerLevel >= 4) {
            return 2;
        }
        else if (PlayerFlags.angerLevel >= 1) {
            return 1;
        }
        else {
            return 0;
        }
    }
}
