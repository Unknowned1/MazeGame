﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float time;
    public Text timer;
    string timer_text;

    // Start is called before the first frame update
    void Start()
    {
        time = 120;
        timer = GetComponent<Text>();
        timer_text = timer.text;

    }

    // Update is called once per frame
    void Update()
    {
        time -= 1 * Time.deltaTime;

        timer.text = timer_text + (int)time;

        if (time <= 0) {
            SceneManager.LoadScene("GameOver");
        }
    }
}
