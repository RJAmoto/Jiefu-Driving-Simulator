using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData
{
    public float money;
    public bool canPlay;
    public bool lvl1;
    public bool lvl2;
    public bool lvl3;
    public bool lvl4;
    public bool lvl5;
    public bool lvl6;
    public bool lvl7;
    public bool lvl8;
    public bool lvl9;
    public bool lvl10;

    public GameData(Data data)
    {
        money = data.money;
        canPlay = data.canPlay;
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
