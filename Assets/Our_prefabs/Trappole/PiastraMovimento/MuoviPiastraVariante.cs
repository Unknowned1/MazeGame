﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuoviPiastraVariante : MonoBehaviour
{
    public int speedAmt;
    public float minimo, massimo;
    private int speedAmt1;

    void Start()
    {
        speedAmt1 = speedAmt;
    }

    void Update()
    {
        if ( transform.position.x >= minimo )
        {
            speedAmt1 = -speedAmt;
        }
        if ( transform.position.x <= massimo )
        {
            speedAmt1 = speedAmt;
        }
        transform.Translate( speedAmt1 * Time.deltaTime , 0 , 0 );
    
    }
}
