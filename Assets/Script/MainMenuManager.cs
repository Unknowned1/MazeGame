using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{


    public void ChangeToTutorial() {
        SceneManager.LoadScene("Tutorial");
    }

    public void ChangeToCredits() {
        SceneManager.LoadScene("Credits");
    }

    public void ExitApp() {
        Application.Quit();
    }
}
