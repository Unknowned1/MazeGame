using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuoviPiastra : MonoBehaviour
{
    int speedAmt = 5;

    void Start()
    {
        
    }

    void Update()
    {
        if(transform.position.x <= -0.65)
        {
            speedAmt = 3;
        }
        if(transform.position.x >= 3)
        {
            speedAmt = -3;
        }
        transform.Translate( speedAmt * Time.deltaTime, 0, 0);
    }
}
