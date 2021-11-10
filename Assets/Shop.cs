using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    Data data;
    string material;
    public Material blue;
    public Material red;
    public Material black;

    // Start is called before the first frame update
    void Start()
    {
        data = GameObject.Find("GameData").GetComponent<Data>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void selectColor(string material)
    {
        if (material == "red" && data.money>=20000)
        {
            data.defaultM = data.red;
            data.saveData();
        }
        else if (material == "blue" && data.money >= 40000)
        {
            data.defaultM = data.blue;
            data.saveData();
        }
        else if (material == "black" && data.money >= 90000)
        {
            data.defaultM = data.black;
            data.saveData();
        }
    } 
}
