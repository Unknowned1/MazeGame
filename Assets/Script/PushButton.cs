using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushButton : MonoBehaviour
{
    // this.gameobject = the button
    public Animator animator;
    public GameObject player;
    public GameObject door;
    bool showGUI;
    public bool buttonPressed;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        showGUI = false;
        buttonPressed = false;
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKeyDown("e"))
        {
            animator.Play("PressButton");
            buttonPressed = true;
            door.GetComponent<DoorDown>().enabled = true;
        }
        else
        {
            animator.Play("Idle");
            buttonPressed = false;
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player") showGUI = true;
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player") showGUI = false;
    }

    void OnGUI()
    {
        if (showGUI) GUI.TextArea(new Rect(500, 300, 100, 30), "Hold E to push ");
    }
}
