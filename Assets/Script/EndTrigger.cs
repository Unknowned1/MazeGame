using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;


public class EndTrigger : MonoBehaviour
{
    public GameObject panel_basic_ui;
    public GameObject level_completed_ui;
    public GameObject game_over_panel;
    public GameObject player;

    private void Update()
    {
        if (GameObject.Find("timer").GetComponentInChildren<Timer>().time <= 0) {
            game_over_panel.SetActive(true);
            panel_basic_ui.SetActive(false);
            level_completed_ui.SetActive(false);
            GameObject.Find("FPSController").GetComponent<FirstPersonController>().enabled = false;
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


}
