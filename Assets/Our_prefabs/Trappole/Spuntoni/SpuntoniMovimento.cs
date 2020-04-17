using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpuntoniMovimento : MonoBehaviour
{
    public int speedAmt = 1;
    public float posizioneIniziale;
    public float posizioneFinale;

    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= posizioneFinale)
        {
            speedAmt = 1;
        }
        if (transform.position.y >= posizioneIniziale)
        {
            speedAmt = -1;
        }

        transform.Translate(0, speedAmt * Time.deltaTime, 0);
    }
}
