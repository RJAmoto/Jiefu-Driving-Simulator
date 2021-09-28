using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public bool paused;

    public void SetPause()
    {
        this.paused = true;
    }
    public void SetResume()
    {
        this.paused = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (paused)
        { 
          
            pause();
 
        }
        else if (!paused)
        {
            resume();
        }
    }

    public void resume()
    {
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    public void pause() {
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Quit()
    {
        Application.Quit();
    }


}
