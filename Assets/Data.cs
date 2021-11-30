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
    public bool canPlay = false;

    public int violations = 0;
    public int btrlCount = 0;
    public int recklessCount = 0;
    public int dtsCount = 0;
    public int overspeedCount = 0;
    public int counterflowCount = 0;
    public int noHeadlightCount = 0;

    public float score = 0;

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

        canPlay = data.canPlay;

        violations = data.violations;
        btrlCount = data.btrlCount;
        recklessCount = data.recklessCount;
        dtsCount = data.dtsCount;
        overspeedCount = data.overspeedCount;
        counterflowCount = data.counterflowCount;
        noHeadlightCount = data.noHeadlightCount;

        score = data.score;
    }

    public void ResetData()
    {
        money = 50000;

        lvl1 = true;
        lvl2 = false;
        lvl3 = false;
        lvl4 = false;
        lvl5 = false;
        lvl6 = false;
        lvl7 = false;
        lvl8 = false;
        lvl9 = false;
        lvl10 = false;

        canPlay = true;

        violations = 0;
        btrlCount = 0;
        recklessCount = 0;
        dtsCount = 0;
        overspeedCount = 0;
        counterflowCount = 0;
        noHeadlightCount = 0;

        score = 0;

        saveData();
    }
}
