using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class PickUpCoinSound : MonoBehaviour
{

    private AudioSource audioSource;
    public AudioClip coinSound;
    public GameObject gold_coin;
    
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        GetComponent<AudioSource>().clip = coinSound;
        //gold_coin = GetComponent<GameObject>();
        
    }

    private void Update()
    {
        //gold_coin = GetComponent<GameObject>();
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            audioSource = GetComponent<AudioSource>();
            audioSource.clip = coinSound;
            audioSource.Play();
            Debug.Log("coin picked up");

            
            GameObject.Find("coins").GetComponentInChildren<CoinUp>().total_coin += 1;
            //GameObject.Find("coins").GetComponent<Text>().text = GameObject.Find("coins").GetComponent<Text>().text + GameObject.Find("coins").GetComponentInChildren<CoinUp>().total_coin;
            //gameObject.SetActive(false);
            gameObject.transform.Translate(0, -1000, 0);
            //gold_coin.SetActive(false);
            //gameObject.SetActive(false);
        }
    }

}

