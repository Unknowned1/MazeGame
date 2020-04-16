using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallDown : MonoBehaviour
{
    public Animator anim;
    public bool can_go_down;
    public GameObject button;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        can_go_down = false;
        can_go_down = button.GetComponent<PushButton>().buttonPressed;
        //button = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        can_go_down = button.GetComponent<PushButton>().buttonPressed;

        if (can_go_down)
        {
            anim.Play("wall_down");
            StartCoroutine("hide");
        }
        else {
            anim.Play("Wall_Idle");
        }
    }

    IEnumerator hide() {
        yield return new WaitForSeconds(1.8f);
        gameObject.SetActive(false);
    }
}
