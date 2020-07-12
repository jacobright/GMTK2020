using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerResponses : MonoBehaviour
{
    public ElevatorPing elevator;

    public void ButtonCoffee() {
        PlayerFlags.nevermindCounter = 0;
        PlayerFlags.complimentCounter -= 1;

        if (TimeKeeper.curTime >= 9) {
            DialogueBox.SetDialogue("I can't take a break now! I'm already working overtime!", 2.0f);
            return;
        }

        if (HoverPlayer.GetRage() < 2) {
            GoCoffee();
        }
        else {
            if (Random.Range(HoverPlayer.GetRage(), 11) >= 9) {
                DialogueBox.SetDialogue(GlobalDialogues.response_coffee_disagree[HoverPlayer.GetRage()], 2.0f);
            }
            else {
                GoCoffee();
            }
        }

    }

    public void ButtonWater() {
        PlayerFlags.nevermindCounter = 0;
        PlayerFlags.complimentCounter -= 1;

        if (TimeKeeper.curTime >= 9) {
            DialogueBox.SetDialogue("I can't take a break now! I'm already working overtime!", 2.0f);
            return;
        }

        if (HoverPlayer.GetRage() < 2) {
            GoWater();
        }
        else {
            if (Random.Range(HoverPlayer.GetRage(), 11) >= 9) {
                DialogueBox.SetDialogue(GlobalDialogues.response_water_disagree[HoverPlayer.GetRage()], 2.0f);
            }
            else {
                GoWater();
            }
        }
        
    }

    public void ButtonBathroom() {
        PlayerFlags.nevermindCounter = 0;
        PlayerFlags.complimentCounter -= 1;

        if (HoverPlayer.GetRage() < 2) {
            GoBathroom();
        }
        else {
            if (Random.Range(HoverPlayer.GetRage(), 11) >= 9) {
                DialogueBox.SetDialogue(GlobalDialogues.response_bathroom_disagree[HoverPlayer.GetRage()], 2.0f);
            }
            else {
                GoBathroom();
            }
        }
        
    }

    public void ButtonLunch() {
        PlayerFlags.nevermindCounter = 0;
        PlayerFlags.complimentCounter -= 1;

        if (GameFlags.lunchTime && !PlayerFlags.gotLunch) {
            //chance to actually DO the lunch option
            if (HoverPlayer.GetRage() < 2) {
                //DO THE LUNCH!
                GetLunch();
            }
            else {
                // CHANCE TO DO LUNCH!
                if (Random.Range(HoverPlayer.GetRage(), 12) >= 9) {
                    DialogueBox.SetDialogue(GlobalDialogues.response_lunch_disagree[HoverPlayer.GetRage()], 2.0f);
                }
                else {
                    GetLunch();
                }
            }
        }
        else if (TimeKeeper.curTime < 2)
            DialogueBox.SetDialogue(GlobalDialogues.response_lunch_before[HoverPlayer.GetRage()], 2.0f);
        else if (TimeKeeper.curTime > 4)
            DialogueBox.SetDialogue(GlobalDialogues.response_lunch_after[HoverPlayer.GetRage()], 2.0f);
        else
            DialogueBox.SetDialogue(GlobalDialogues.response_already_ate[HoverPlayer.GetRage()], 2.0f);

    }

    public void ButtonInsult() {
        PlayerFlags.nevermindCounter = 0;
        PlayerFlags.complimentCounter = 0;
        PlayerFlags.angerLevel += (PlayerFlags.angerLevel/2) + 1;

        DialogueBox.SetDialogue(GlobalDialogues.response_insult[HoverPlayer.GetRage()], 2.0f);
    }

    public void ButtonCompliment() {
        PlayerFlags.nevermindCounter = 0;
        PlayerFlags.complimentCounter += 1;
        
        if (PlayerFlags.complimentCounter > 2) {
            PlayerFlags.angerLevel += 2;
            DialogueBox.SetDialogue(GlobalDialogues.response_compliment_negative[HoverPlayer.GetRage()], 2.0f);
            return;
        }

        if (PlayerFlags.angerLevel > 3) {
            if (Random.Range(HoverPlayer.GetRage(), 10) >= 9) {
                PlayerFlags.angerLevel += (PlayerFlags.angerLevel/2);
                DialogueBox.SetDialogue(GlobalDialogues.response_compliment_negative[HoverPlayer.GetRage()], 2.0f);
                PlayerFlags.complimentCounter = 0;
            }
            else {
                PlayerFlags.angerLevel -= (PlayerFlags.angerLevel/2) + 1;
                DialogueBox.SetDialogue(GlobalDialogues.response_compliment_positive[HoverPlayer.GetRage()], 2.0f);
            }
        }
        else {
            PlayerFlags.angerLevel -= (PlayerFlags.angerLevel/2) + 1;
            DialogueBox.SetDialogue(GlobalDialogues.response_compliment_positive[HoverPlayer.GetRage()], 2.0f);
        }

        if (PlayerFlags.angerLevel < 0)
            PlayerFlags.angerLevel = 0;

    }

    public void Nevermind() {
        PlayerFlags.nevermindCounter += 1;
        PlayerFlags.complimentCounter -= 1;

        if (PlayerFlags.nevermindCounter > 2) {
            PlayerFlags.nevermindCounter = 0;
            PlayerFlags.angerLevel += 1;
        }

        DialogueBox.SetDialogue(GlobalDialogues.response_nevermind[HoverPlayer.GetRage()], 2.0f);
    }

    void GetLunch() {
        TimeKeeper.curTime += 1;
        PlayerFlags.gotLunch = true;

        if (GameFlags.lunchLine) {
            DialogueBox.SetDialogue(GlobalDialogues.initiation_desk_post_lunch_line[HoverPlayer.GetRage()], 2.0f);
            PlayerFlags.angerLevel += 1;
        }
        else {
            DialogueBox.SetDialogue(GlobalDialogues.initiation_desk_post_lunch_noline[HoverPlayer.GetRage()], 2.0f);

            if (PlayerFlags.angerLevel < 4)
                PlayerFlags.angerLevel = 0;
            else
                PlayerFlags.angerLevel -= 4;
        }

        if (TimeKeeper.curTime == 2) {
            DialogueBox.SetDialogue(GlobalDialogues.initiation_desk_interact_lunch[HoverPlayer.GetRage()], 2.0f);
        }

        if (TimeKeeper.curTime == 5 && !PlayerFlags.gotLunch) {
            DialogueBox.SetDialogue(GlobalDialogues.initiation_desk_no_lunch[HoverPlayer.GetRage()], 2.0f);
        }

        if (TimeKeeper.curTime == 2 || TimeKeeper.curTime == 3 || TimeKeeper.curTime == 4 || TimeKeeper.curTime == 9) {
            elevator.Ping();
        }
    }

    void GoBathroom() {
        TimeKeeper.curTime += 1;
        PlayerFlags.workTimeEnd += 1;

        if (GameFlags.bathroomLine) {
            DialogueBox.SetDialogue(GlobalDialogues.initiation_bathroom_interact_line[HoverPlayer.GetRage()], 2.0f);
            PlayerFlags.angerLevel += 3;
        }
        else {
            DialogueBox.SetDialogue(GlobalDialogues.initiation_bathroom_interact_no_line[HoverPlayer.GetRage()], 2.0f);

            if (PlayerFlags.angerLevel < 1)
                PlayerFlags.angerLevel = 0;
            else
                PlayerFlags.angerLevel -= 1;
        }

        if (TimeKeeper.curTime == 2) {
            DialogueBox.SetDialogue(GlobalDialogues.initiation_desk_interact_lunch[HoverPlayer.GetRage()], 2.0f);
        }

        if (TimeKeeper.curTime == 5 && !PlayerFlags.gotLunch) {
            DialogueBox.SetDialogue(GlobalDialogues.initiation_desk_no_lunch[HoverPlayer.GetRage()], 2.0f);
        }

        if (TimeKeeper.curTime == 2 || TimeKeeper.curTime == 3 || TimeKeeper.curTime == 4 || TimeKeeper.curTime == 9) {
            elevator.Ping();
        }
    }

    void GoCoffee() {
        TimeKeeper.curTime += 1;
        PlayerFlags.workTimeEnd += 1;

        if (GameFlags.coffeeLine) {
            DialogueBox.SetDialogue(GlobalDialogues.initiation_coffee_interact_line[HoverPlayer.GetRage()], 2.0f);
            PlayerFlags.angerLevel += 2;
        }
        else {
            DialogueBox.SetDialogue(GlobalDialogues.initiation_coffee_interact_no_line[HoverPlayer.GetRage()], 2.0f);

            if (PlayerFlags.angerLevel < 4)
                PlayerFlags.angerLevel = 0;
            else
                PlayerFlags.angerLevel -= 4;
        }

        if (TimeKeeper.curTime == 2) {
            DialogueBox.SetDialogue(GlobalDialogues.initiation_desk_interact_lunch[HoverPlayer.GetRage()], 2.0f);
        }

        if (TimeKeeper.curTime == 5 && !PlayerFlags.gotLunch) {
            DialogueBox.SetDialogue(GlobalDialogues.initiation_desk_no_lunch[HoverPlayer.GetRage()], 2.0f);
        }

        if (TimeKeeper.curTime == 2 || TimeKeeper.curTime == 3 || TimeKeeper.curTime == 4 || TimeKeeper.curTime == 9) {
            elevator.Ping();
        }
    }

    void GoWater() {
        TimeKeeper.curTime += 1;
        PlayerFlags.workTimeEnd += 1;

        if (GameFlags.waterLine) {
            DialogueBox.SetDialogue(GlobalDialogues.initiation_watercooler_interact_line[HoverPlayer.GetRage()], 2.0f);
            PlayerFlags.angerLevel += 2;
        }
        else {
            DialogueBox.SetDialogue(GlobalDialogues.initiation_watercooler_interact_no_line[HoverPlayer.GetRage()], 2.0f);

            if (PlayerFlags.angerLevel < 3)
                PlayerFlags.angerLevel = 0;
            else
                PlayerFlags.angerLevel -= 3;
        }

        if (TimeKeeper.curTime == 2) {
            DialogueBox.SetDialogue(GlobalDialogues.initiation_desk_interact_lunch[HoverPlayer.GetRage()], 2.0f);
        }

        if (TimeKeeper.curTime == 5 && !PlayerFlags.gotLunch) {
            DialogueBox.SetDialogue(GlobalDialogues.initiation_desk_no_lunch[HoverPlayer.GetRage()], 2.0f);
        }

        if (TimeKeeper.curTime == 2 || TimeKeeper.curTime == 3 || TimeKeeper.curTime == 4 || TimeKeeper.curTime == 9) {
            elevator.Ping();
        }
    }
}
