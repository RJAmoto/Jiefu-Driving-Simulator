using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour
{
    public float money = 500;

    public void saveData()
    {
        SaveSystem.SaveData(this);
    }
    public void loadData()
    {
        GameData data = SaveSystem.LoadData();
        money = data.money;
    }
}
