using UnityEditor;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;


public class EndTrigger : MonoBehaviour
{
    public GameObject panel_basic_ui;
    public GameObject level_completed_ui;
    public GameObject game_over_panel;
    public GameObject pause_panel;
    public GameObject player;

    private void Update()
    {
        if (GameObject.Find("timer").GetComponentInChildren<Timer>().time <= 0) {
            game_over_panel.SetActive(true);
            panel_basic_ui.SetActive(false);
            level_completed_ui.SetActive(false);
            GameObject.Find("FPSController").GetComponent<FirstPersonController>().enabled = false;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("esc pressed ");
            pause_panel.SetActive(true);
            GameObject.Find("FPSController").GetComponent<FirstPersonController>().enabled = false;
            //PauseGame();
        }
        

        if (Input.GetKeyDown(KeyCode.E))
        {
            pause_panel.SetActive(false);
            GameObject.Find("FPSController").GetComponent<FirstPersonController>().enabled = true;
            Time.timeScale = 1;
        }
        
        if (Input.GetKeyDown(KeyCode.Return))
        {
            //added action to set te pause menu back to inactive after resume button is pressed
            pause_panel.SetActive(false);
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") {
            panel_basic_ui.SetActive(false);
            level_completed_ui.SetActive(true);
            GameObject.Find("FPSController").GetComponent<FirstPersonController>().enabled = false;
            
            // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIntex +1 );
        }
    }

    

    private void PauseGame()
    {
        Time.timeScale = 0;
        pause_panel.SetActive(true);
        //Disable scripts that still work while timescale is set to 0
    }

    private void ContinueGame()
    {
        Time.timeScale = 1;
        pause_panel.SetActive(false);
        //enable the scripts again
    }
}
