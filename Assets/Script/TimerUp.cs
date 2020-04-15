using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerUp : MonoBehaviour
{
    public Text timer_txt;
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            // aumenta il tempo
            GameObject.Find("timer").GetComponentInChildren<Timer>().time += 10;
            gameObject.transform.Translate(0, -10, 0);
            gameObject.SetActive(false);
        }
    }
}
