using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class SceneOpener : MonoBehaviour
{
    public int level;

    Data data;

    public void OpenNextLevel()
    {
        data = GameObject.Find("GameData").GetComponent<Data>();
        data.loadData();
        SceneManager.LoadScene(level);
    }

}
