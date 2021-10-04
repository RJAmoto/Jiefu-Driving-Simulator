using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerActions : MonoBehaviour
{
    Animator TextAnimator;
    Animator redEffect;
    Data data;

    public TextMeshProUGUI reckless;
    public TextMeshProUGUI disregardingTrafficSign;
    public TextMeshProUGUI btrl;
    public TextMeshProUGUI good;
    public TextMeshProUGUI overSpeed;

    // Start is called before the first frame update
    void Start()
    {
        data = GameObject.Find("FileHandler").GetComponent<Data>();
        redEffect = GameObject.Find("RedEffect").GetComponent<Animator>();
    }

    // Update is called once per frame
    public void recklessDriving()
    {
        reckless.GetComponent<Animator>().SetTrigger("ViolText");
        redEffect.SetTrigger("RedEffect");
        data.money = data.money - 20;

        data.saveData();
    }
    public void DisregardingTrafficSign()
    {
        disregardingTrafficSign.GetComponent<Animator>().SetTrigger("ViolText");
        redEffect.SetTrigger("RedEffect");
        data.money = data.money - 20;

        data.saveData();
    }

    public void BTRL()
    {
        btrl.GetComponent<Animator>().SetTrigger("ViolText");
        redEffect.SetTrigger("RedEffect");
        data.money = data.money - 20;

        data.saveData();
    }

    public void overSpeeding()
    {
        overSpeed.GetComponent<Animator>().SetTrigger("ViolText");
        redEffect.SetTrigger("RedEffect");
        data.money = data.money - 20;

        data.saveData();
    }

    public void goodBoy()
    {
        good.GetComponent<Animator>().SetTrigger("ViolText");
        data.money = data.money + 200;

        data.saveData();
    }
}
