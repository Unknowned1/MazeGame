using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpuntoniMovimento : MonoBehaviour
{
    public int speedAmt = 1;

    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= -1.5)
        {
            speedAmt = 1;
        }
        if (transform.position.y >= 0.295)
        {
            speedAmt = -1;
        }

        transform.Translate(0, speedAmt * Time.deltaTime, 0);
    }
}
