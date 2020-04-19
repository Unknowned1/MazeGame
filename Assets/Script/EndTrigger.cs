using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameObject panel_basic_ui;
    public GameObject level_completed_ui;
    public GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") {
            panel_basic_ui.SetActive(false);
            level_completed_ui.SetActive(true);
            player.SetActive(false);
            // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIntex +1 );
        }
    }


}
