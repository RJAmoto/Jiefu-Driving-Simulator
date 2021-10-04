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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        toggle.image.sprite = material;
    }
    public void OnTriggerExit(Collider other)
    {
        toggle.image.sprite = SignUIBlank;
    }
}
