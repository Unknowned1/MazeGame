using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuoviPiastra : MonoBehaviour
{
    int speedAmt = 1;

    void Start()
    {
        
    }

    void Update()
    {
        if(transform.position.x <= -0.65)
        {
            speedAmt = 1;
        }
        if(transform.position.x >= 3)
        {
            speedAmt = -1;
        }
        transform.Translate( speedAmt * Time.deltaTime, 0, 0);
    }
}
