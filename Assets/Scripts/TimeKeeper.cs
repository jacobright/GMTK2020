using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeKeeper : MonoBehaviour
{
    public static int curTime = 0;
    private int curTick = 0;
    public UnityEngine.UI.Text clock;
    public ElevatorPing elevator;
    
    void Start()
    {
        curTick = 0;
        curTime = 0;
    }

    float elevatorCounter = 0;

    void FixedUpdate()
    {
        if (curTime + 9 < 10)
            clock.text = "[0" + (curTime + 9) +":00]";
        else if (curTime + 9 > 12) {
            if (curTime + 9 - 12 >= 10) {
                clock.text = "[" + (curTime + 9 - 12) +":00]";
            }
            else {
                clock.text = "[0" + (curTime + 9 - 12) +":00]";
            }
        }
        else {
            clock.text = "[" + (curTime + 9) +":00]";
        }

        curTick += 1;

        if (elevator.GetComponent<Animator>().GetBool("doAnimation")) {
            elevatorCounter += Time.deltaTime;
            if (elevatorCounter > 2.0f) {
                elevator.GetComponent<Animator>().SetBool("doAnimation", false);
                elevatorCounter = 0;
            }
        }

        if (curTick % 500 == 0 && curTime >= 9) {
            curTime += 1;
            PlayerFlags.angerLevel += 3;
        }

        if (curTick % 1500 == 0) { // 50 = 1 sec, 3000 = 1 min
            curTime += 1;

            if (curTime == 2) {
                DialogueBox.SetDialogue(GlobalDialogues.initiation_desk_interact_lunch[HoverPlayer.GetRage()], 2.0f);
            }

            if (curTime == 5 && !PlayerFlags.gotLunch) {
                DialogueBox.SetDialogue(GlobalDialogues.initiation_desk_no_lunch[HoverPlayer.GetRage()], 2.0f);
            }

            if (curTime == 2 || curTime == 3 || curTime == 4 || curTime == 9) {
                elevator.Ping();
            }

        }

        if (curTick == 1) {
            DialogueBox.SetDialogue(GlobalDialogues.initiation_greeting[HoverPlayer.GetRage()], 2.0f);
        }



        if (PlayerFlags.workTimeEnd == curTime) {
            UnityEngine.SceneManagement.SceneManager.LoadScene("WinScene");
        }

        SetFlags();        
    }

    void SetFlags() {
        if (curTime == 0) {
            clock.color = Color.white;

            GameFlags.bathroomLine = false;
            GameFlags.coffeeLine = true;
            GameFlags.lunchLine = false;
            GameFlags.waterLine = false;
            GameFlags.lunchTime = false;
        }

        if (curTime == 1) {
            GameFlags.bathroomLine = false;
            GameFlags.coffeeLine = false;
            GameFlags.lunchLine = false;
            GameFlags.waterLine = false;
            GameFlags.lunchTime = false;
        }

        if (curTime == 2) {
            // lunch starts
            GameFlags.bathroomLine = true;
            GameFlags.coffeeLine = false;
            GameFlags.lunchLine = false;
            GameFlags.waterLine = true;

            GameFlags.lunchTime = true;
        }

        if (curTime == 3) {
            GameFlags.bathroomLine = false;
            GameFlags.coffeeLine = false;
            GameFlags.lunchLine = true;
            GameFlags.waterLine = false;

            GameFlags.lunchTime = true;
        }

        if (curTime == 4) {
            GameFlags.bathroomLine = false;
            GameFlags.coffeeLine = false;
            GameFlags.lunchLine = false;
            GameFlags.waterLine = false;
            GameFlags.lunchTime = true;
        }

        if (curTime == 5) {
            // lunch ends
            GameFlags.bathroomLine = true;
            GameFlags.coffeeLine = false;
            GameFlags.lunchLine = false;
            GameFlags.waterLine = false;
            GameFlags.lunchTime = false;

            if (!PlayerFlags.gotLunch)
                PlayerFlags.skippedLunch = true;
        }

        if (curTime == 6) {
            GameFlags.bathroomLine = false;
            GameFlags.coffeeLine = false;
            GameFlags.lunchLine = false;
            GameFlags.waterLine = false;
            GameFlags.lunchTime = false;
        }

        if (curTime == 7) {
            GameFlags.bathroomLine = false;
            GameFlags.coffeeLine = false;
            GameFlags.lunchLine = false;
            GameFlags.waterLine = false;
            GameFlags.lunchTime = false;
        }

        if (curTime == 8) {
            GameFlags.bathroomLine = false;
            GameFlags.coffeeLine = false;
            GameFlags.lunchLine = false;
            GameFlags.waterLine = false;
            GameFlags.lunchTime = false;
        }

        if (curTime == 9) {
            // overtime starts
            GameFlags.bathroomLine = false;
            GameFlags.coffeeLine = false;
            GameFlags.lunchLine = false;
            GameFlags.waterLine = false;
            GameFlags.lunchTime = false;

            clock.color = Color.red;

            // PlayerFlags.angerLevel += 1;
        }

        if (curTime == 10) {
            GameFlags.bathroomLine = false;
            GameFlags.coffeeLine = false;
            GameFlags.lunchLine = false;
            GameFlags.waterLine = false;
            GameFlags.lunchTime = false;

            // PlayerFlags.angerLevel += 1;
        }

        if (curTime == 11) {
            GameFlags.bathroomLine = false;
            GameFlags.coffeeLine = false;
            GameFlags.lunchLine = false;
            GameFlags.waterLine = false;
            GameFlags.lunchTime = false;

            // PlayerFlags.angerLevel += 1;
        }

        if (curTime == 12) {
            GameFlags.bathroomLine = false;
            GameFlags.coffeeLine = false;
            GameFlags.lunchLine = false;
            GameFlags.waterLine = false;
            GameFlags.lunchTime = false;

            // PlayerFlags.angerLevel += 1;
        }

        if (curTime >= 13) {
            GameFlags.bathroomLine = false;
            GameFlags.coffeeLine = false;
            GameFlags.lunchLine = false;
            GameFlags.waterLine = false;
            GameFlags.lunchTime = false;

            PlayerFlags.angerLevel = 14;
            //DialogueBox.SetDialogue("", 2.0f);
            // day ends
            // move to end screen
        }

    }
}
