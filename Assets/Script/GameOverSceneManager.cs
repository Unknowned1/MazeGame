using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverSceneManager : MonoBehaviour
{
    public Button retry_button, exit_button;

    // Start is called before the first frame update
    void Start()
    {
        retry_button = GetComponent<Button>();
        exit_button = GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Retry()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1 );
        Debug.Log("clicked");
    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
