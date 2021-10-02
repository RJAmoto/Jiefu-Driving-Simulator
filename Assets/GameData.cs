using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData
{
    public float money;

    public GameData(Data data)
    {
        money = data.money;
    }
}
