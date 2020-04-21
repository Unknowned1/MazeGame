using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeFromIntroToMenu : MonoBehaviour
{
    bool loading_started = false;
    float seconds_left = 0f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DelayLoadLevel(6.5f));
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator DelayLoadLevel(float seconds) {
        seconds_left = seconds;
        loading_started = true;
        do
        {
            yield return new WaitForSeconds(1);
        } while (--seconds_left > 0);
        SceneManager.LoadScene("MainMenu");
    }
}
