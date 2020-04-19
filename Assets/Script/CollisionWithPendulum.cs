using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionWithPendulum : MonoBehaviour
{
    private bool eliminaSottraiTimer = false;
    public GameObject panel;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            // diminuisce il tempo
            GameObject.Find("timer").GetComponentInChildren<Timer>().time -= 10;
            GameObject.Find("sottraiTimer").GetComponentInChildren<Text>().text = "-10";
            StartCoroutine(ExampleCoroutine());
            GameObject.Find("sottraiTimer").GetComponentInChildren<Text>().text = "";
        }
    }

   

    IEnumerator ExampleCoroutine()
    {
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(2);

    }
}
