using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MantieniPlayerPlatform : MonoBehaviour
{
    public GameObject player;
    public GameObject piattaforma;

   
    void OnTriggerEnter()
    {

        player.transform.parent = piattaforma.transform;

    }

   
    
}
