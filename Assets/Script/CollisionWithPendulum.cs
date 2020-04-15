using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionWithPendulum : MonoBehaviour
{


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            // diminuisce il tempo
            GameObject.Find("timer").GetComponentInChildren<Timer>().time -= 10;
        }
    }
}
