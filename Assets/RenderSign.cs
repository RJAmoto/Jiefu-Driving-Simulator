using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RenderSign : MonoBehaviour
{

    public Sprite material;
    public Sprite SignUIBlank;
    public Toggle toggle;

    public Image signUI;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") {
            toggle.image.sprite = material;
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            toggle.image.sprite = SignUIBlank;
        }
    }
}
