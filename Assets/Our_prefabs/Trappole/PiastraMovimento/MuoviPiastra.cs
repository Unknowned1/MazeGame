using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuoviPiastra : MonoBehaviour
{
    int speedAmt;

    void Start()
    {
        
    }

    void Update()
    {
        if(transform.position.z >= -22.62)
        {
            speedAmt = -10;
        }
        if(transform.position.z <= -39.58)
        {
            speedAmt = 10;
        }
        transform.Translate(0, 0, speedAmt * Time.deltaTime);
    }
}
