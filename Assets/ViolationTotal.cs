using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ViolationTotal : MonoBehaviour
{

    Data data;
    public Text violTotal;

    int violations;
    int btrlCount;
    int recklessCount;
    int dtsCount;
    int overspeedCount;
    int counterflowCount;
    int noHeadlightCount;

    // Start is called before the first frame update
    void Start()
    {
        data = GameObject.Find("GameData").GetComponent<Data>();
    }

    // Update is called once per frame
    void Update()
    {
        data.loadData();

        violations = data.violations;
        btrlCount = data.btrlCount;
        recklessCount = data.recklessCount;
        dtsCount = data.dtsCount;
        overspeedCount = data.overspeedCount;
        counterflowCount = data.counterflowCount;
        noHeadlightCount = data.noHeadlightCount;

        if (violations>0)
        {
            violTotal.text = "Violations \r\nBeating the Red light: "
               + btrlCount / 3 + "\r\nReckless Driving: " + recklessCount/3 + "\r\nDisregarding Traffic Sign: " + dtsCount / 3 + "\r\nOver Speeding: "
               + overspeedCount / 3 + "\r\nIllegal Overtake: " + counterflowCount / 3 + "\r\nCareless Driving: " + counterflowCount / 3;
        }
        else
        {
            violTotal.text = "None";
        }
    }
}
