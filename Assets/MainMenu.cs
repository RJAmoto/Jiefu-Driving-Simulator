using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
   public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    public void OpenDiscord()
    {
        Application.OpenURL("https://discord.com/invite/DsjFWmm8?fbclid=IwAR1z8OZZAwmxn199R1OtP7f1-NkUqDi7d2716cStojbzKIIcouf8cRn1ByE");
    }
    public void OpenLTO()
    {
        Application.OpenURL("https://www.ltoexamreviewer.com/");
    }
    public void OpenFB()
    {
        Application.OpenURL("https://www.facebook.com/lto.cdmpao");
    }
}
