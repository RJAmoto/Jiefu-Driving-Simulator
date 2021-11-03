using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour
{
    public float money = 500;
    public bool lvl1 = true;
    public bool lvl2 = false;
    public bool lvl3 = false;
    public bool lvl4 = false;
    public bool lvl5 = false;
    public bool lvl6 = false;
    public bool lvl7 = false;
    public bool lvl8 = false;
    public bool lvl9 = false;
    public bool lvl10 = false;

    public void saveData()
    {
        SaveSystem.SaveData(this);
    }
    public void loadData()
    {
        GameData data = SaveSystem.LoadData();
        money = data.money;

        lvl1 = data.lvl1;
        lvl2 = data.lvl2;
        lvl3 = data.lvl3;
        lvl4 = data.lvl4;
        lvl5 = data.lvl5;
        lvl6 = data.lvl6;
        lvl7 = data.lvl7;
        lvl8 = data.lvl8;
        lvl9 = data.lvl9;
        lvl10 = data.lvl10;
    }
}
