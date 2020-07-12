using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadGame : MonoBehaviour
{
    public void LoadTheGame() {
        UnityEngine.SceneManagement.SceneManager.LoadScene("SmolGraphic");
    }

    public void QuitGame() {
        Application.Quit();
    }
}
