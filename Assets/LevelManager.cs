using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject[] levelButtons;
    Data data;

    // Start is called before the first frame update
    void Start()
    {
        data = GameObject.Find("GameData").GetComponent<Data>();
        data.loadData();
    }

    // Update is called once per frame
    void Update()
    {
        if (data.lvl1)
        {
            levelButtons[0].GetComponent<LevelLocker>().setUnLocked();
            data.saveData();
        }
        if (data.lvl2)
        {
            levelButtons[1].GetComponent<LevelLocker>().setUnLocked();
            data.saveData();
        }
        if (data.lvl3)
        {
            levelButtons[2].GetComponent<LevelLocker>().setUnLocked();
            data.saveData();
        }
        if (data.lvl4)
        {
            levelButtons[3].GetComponent<LevelLocker>().setUnLocked();
            data.saveData();
        }
        if (data.lvl5)
        {
            levelButtons[4].GetComponent<LevelLocker>().setUnLocked();
            data.saveData();
        }
        if (data.lvl6)
        {
            levelButtons[5].GetComponent<LevelLocker>().setUnLocked();
            data.saveData();
        }
        if (data.lvl7)
        {
            levelButtons[6].GetComponent<LevelLocker>().setUnLocked();
            data.saveData();
        }
        if (data.lvl8)
        {
            levelButtons[7].GetComponent<LevelLocker>().setUnLocked();
            data.saveData();
        }
        if (data.lvl9)
        {
            levelButtons[8].GetComponent<LevelLocker>().setUnLocked();
            data.saveData();
        }
        if (data.lvl10)
        {
            levelButtons[9].GetComponent<LevelLocker>().setUnLocked();
            data.saveData();
        }
    }
}
