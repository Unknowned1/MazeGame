using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinUp : MonoBehaviour
{

    public int total_coin;
    public Text coins_text;
    public string coins_str;


    // Start is called before the first frame update
    void Start()
    {
        total_coin = 0;
        coins_str = coins_text.text;
            
    }

    // Update is called once per frame
    void Update()
    {
        coins_text.text = coins_str + total_coin;
    }
}
