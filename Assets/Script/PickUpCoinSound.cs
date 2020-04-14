using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class PickUpCoinSound : MonoBehaviour
{

    private AudioSource audioSource;
    public AudioClip coinSound;

    void Start()
    {
        
        GetComponent<AudioSource>().clip = coinSound;
    }

    
    public void OnCollisionEnter(Collision col)
    {
        if (col.collider.tag == "Player"){

            audioSource = GetComponent<AudioSource>();
            audioSource.clip = coinSound;
            audioSource.Play();
            Debug.Log("coin picked up");
            gameObject.SetActive(false);
        }
    }
    
}

