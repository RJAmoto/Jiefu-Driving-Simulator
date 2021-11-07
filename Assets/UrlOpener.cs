using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UrlOpener : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void OpenDiscord()
    {
        Application.OpenURL("https://discord.gg/bvQjbEcT");
    }
    public void OpenLTO()
    {
        Application.OpenURL("https://lto.gov.ph/");
    }
    public void OpenFB()
    {
        Application.OpenURL("https://www.facebook.com/PH-Driving-Simulator-100205179150086/");
        
    }
}
