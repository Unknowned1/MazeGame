using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorDown : MonoBehaviour
{
    private float limite;
    // Start is called before the first frame update
    void Start()
    {
        limite = transform.position.y - 3;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -1 * Time.deltaTime, 0);
        if (transform.position.y < (limite)) Destroy(gameObject);
    }
}
