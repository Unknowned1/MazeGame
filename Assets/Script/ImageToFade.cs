using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageToFade : MonoBehaviour
{
    public Image img;
    Color color_img;
    public float value_of_fade = 1f;

    // Start is called before the first frame update
    void Start()
    {
        img = GetComponent<Image>();
        color_img = img.GetComponent<Image>().color;
    }

    // Update is called once per frame
    void Update()
    {
        color_img.a -= value_of_fade * Time.deltaTime;
        img.color = color_img;
    }
}
