using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        gold_coin = GetComponentInChildren<GameObject>();
    }

    
 /*   public void OnCollisionEnter(Collision col)
    {
        if (col.collider.tag == "Player"){

            audioSource = GetComponent<AudioSource>();
            audioSource.clip = coinSound;
            audioSource.Play();
            Debug.Log("coin picked up");

            //gameObject.SetActive(false);
            //Destroy(gameObject);
        }
    }
*/
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            audioSource = GetComponent<AudioSource>();
            audioSource.clip = coinSound;
            audioSource.Play();
            Debug.Log("coin picked up");

            //gameObject.SetActive(false);
            gold_coin.SetActive(false);
        }
    }

}

