using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Money : MonoBehaviour
{

    public TextMeshProUGUI myTMP;
    // Start is called before the first frame update
    float money = 0.0f;

    public Data data;
    // Update is called once per frame

    public void Start()
    {
        data = GameObject.Find("FileHandler").GetComponent<Data>();
    }

    void Update()
    {
        money = data.money;
        if (myTMP != null)
            myTMP.text = "₱" + money;
    }
}
