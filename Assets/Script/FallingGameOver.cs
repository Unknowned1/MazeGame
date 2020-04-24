using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class FallingGameOver : MonoBehaviour
{
    public GameObject game_over_panel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (game_over_panel.activeInHierarchy)
        {
            if (Input.GetKey(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                Debug.Log("clicked");
            }
            if (Input.GetKey(KeyCode.Q))
            {
                Application.Quit();
                Debug.Log("clicked");
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        /*if (other.tag == "Player") {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            GameObject.Find("game_over_panel").GetComponent<GameObject>().SetActive(true);
        }
        */
        if (other.tag == "Player" && this.tag == "invisible_plat")
        {
           
            game_over_panel.SetActive(true);
            GameObject.Find("basic_ui").SetActive(false);
            GameObject.Find("level_completed").SetActive(false);
            GameObject.Find("volume_panel").SetActive(false);
            
            GameObject.Find("FPSController").GetComponent<FirstPersonController>().enabled = false;
            // Cursor.visible = true;

        }
    }
}
