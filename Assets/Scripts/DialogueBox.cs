using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueBox : MonoBehaviour
{
    public static string theText;
    public static bool textBoxEnabled;
    public static float theDelay = 0;
    public static string insultText;
    public static string complimentText;

    public GameObject textBox;
    public GameObject textField;
    public GameObject dimmer;
    public GameObject playerOptions;
    public GameObject insultBox;
    public GameObject complimentBox;

    void Update()
    {
        textBox.SetActive(textBoxEnabled);
        dimmer.SetActive(textBoxEnabled);

        if (theDelay > 2)
            playerOptions.SetActive(textBoxEnabled);
        else
            playerOptions.SetActive(false);

        insultBox.GetComponent<UnityEngine.UI.Text>().text = insultText;
        complimentBox.GetComponent<UnityEngine.UI.Text>().text = complimentText;

        if (theDelay > 0) {
            textField.GetComponent<UnityEngine.UI.Text>().text = theText;
            theDelay -= Time.deltaTime;
        }
        else {
            textBoxEnabled = false;
            PlayerFlags.canInteract = true;

            if (HoverPlayer.GetRage() >= 6) {
	        	StartCoroutine(changeDialogueThenLoad());
            }

        }
    }

	IEnumerator changeDialogueThenLoad() { 
        DialogueBox.SetDialogue("I CAN'T TAKE IT ANYMORE", 2.0f);
		yield return new WaitForSeconds (2);
		Time.timeScale = 1;
        UnityEngine.SceneManagement.SceneManager.LoadScene("LoseScene");
	}

    public static void SetDialogue(string text) {
        textBoxEnabled = true;
        theText = text;
        theDelay = 1000000;

        if (HoverPlayer.GetRage() > 3)
            insultText = GlobalDialogues.input_insult_angry[Random.Range(0,GlobalDialogues.input_insult_angry.Length)];
        else
            insultText = GlobalDialogues.input_insult_happy[Random.Range(0,GlobalDialogues.input_insult_happy.Length)];
        
        complimentText = GlobalDialogues.input_compliment[Random.Range(0,GlobalDialogues.input_compliment.Length)];
    }
    public static void SetDialogue(string text, float timeToDisplay) {
        textBoxEnabled = true;
        theText = text;
        theDelay = timeToDisplay;
    }
}
