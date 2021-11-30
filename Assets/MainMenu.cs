using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public bool canPlay = true;
    Data data;
    public int requiredScore = 50;
    public float money;
    public void Start()
    {
        data = GameObject.Find("GameData").GetComponent<Data>();
        data.loadData();

        canPlay = data.canPlay;
    }
    public void Update()
    {
        if(data.money <= 1)
        {
            canPlay = false;
            data.canPlay = false;
            data.saveData();
        }
        else if (data.money>1)
        {
            canPlay = true;
            data.canPlay = true;
            data.saveData();
        }

        money = data.money;

    }
    public void PlayGame(int lvl)
    {
        //this.index = index;
        //this.isLocked = isLocked;
        switch (lvl)
        {
            case 1:
                if (GameObject.Find("Lvl1").GetComponent<LevelLocker>().isLocked || canPlay == false || data.score < requiredScore)
                {
                    return;
                }
                else
                {
                    SceneManager.LoadScene(1);
                }
                break;
            case 2:
                if (GameObject.Find("Lvl2").GetComponent<LevelLocker>().isLocked || canPlay == false || data.score < requiredScore)
                {
                    return;
                }
                else
                {
                    SceneManager.LoadScene(2);
                }
                break;
            case 3:
                if (GameObject.Find("Lvl3").GetComponent<LevelLocker>().isLocked || canPlay == false || data.score < requiredScore)
                {
                    return;
                }
                else
                {
                    SceneManager.LoadScene(3);
                }
                break;
            case 4:
                if (GameObject.Find("Lvl4").GetComponent<LevelLocker>().isLocked || canPlay == false || data.score < requiredScore)
                {
                    return;
                }
                else
                {
                    SceneManager.LoadScene(4);
                }
                break;
            case 5:
                if (GameObject.Find("Lvl5").GetComponent<LevelLocker>().isLocked || canPlay == false || data.score < requiredScore)
                {
                    return;
                }
                else
                {
                    SceneManager.LoadScene(5);
                }
                break;
            case 6:
                if (GameObject.Find("Lvl6").GetComponent<LevelLocker>().isLocked || canPlay == false || data.score < requiredScore)
                {
                    return;
                }
                else
                {
                    SceneManager.LoadScene(6);
                }
                break;
            case 7:
                if (GameObject.Find("Lvl7").GetComponent<LevelLocker>().isLocked || canPlay == false || data.score < requiredScore)
                {
                    return;
                }
                else
                {
                    SceneManager.LoadScene(7);
                }
                break;
            case 8:
                if (GameObject.Find("Lvl8").GetComponent<LevelLocker>().isLocked || canPlay == false || data.score < requiredScore)
                {
                    return;
                }
                else
                {
                    SceneManager.LoadScene(8);
                }
                break;
            case 9:
                if (GameObject.Find("Lvl9").GetComponent<LevelLocker>().isLocked || canPlay == false || data.score < requiredScore)
                {
                    return;
                }
                else
                {
                    SceneManager.LoadScene(9);
                }
                break;
            case 10:
                if (GameObject.Find("Lvl10").GetComponent<LevelLocker>().isLocked || canPlay == false || data.score < requiredScore)
                {
                    return;
                }
                else
                {
                    SceneManager.LoadScene(10);
                }
                break;
        }
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
        Application.OpenURL("https://play.google.com/store/apps/details?id=com.lto.exam.reviewer&hl=en&gl=US&fbclid=IwAR0GfhnR1svSKinCj9zAu-wRguViqGtPOrFeBJc49fnT1xLNNtZW6ElPWPg");
    }
    public void OpenFB()
    {
        Application.OpenURL("https://www.facebook.com/lto.cdmpao");
    }
}
