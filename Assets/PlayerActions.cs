using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class PlayerActions : MonoBehaviour
{
    Animator TextAnimator;
    Animator redEffect;
    Data data;

    int btrlCount = 0;
    int recklessCount = 0;
    int dtsCount = 0;
    int overspeedCount = 0;
    int violations = 0;

    float recklessPenalty = 1000;
    float btrlPenalty = 2000;
    float overSpeedingPenalty = 3000;
    float DTSPenalty = 300;
    float reward = 5000;

    public TextMeshProUGUI reckless;
    public TextMeshProUGUI disregardingTrafficSign;
    public TextMeshProUGUI btrl;
    public TextMeshProUGUI good;
    public TextMeshProUGUI overSpeed;
    public TextMeshProUGUI violation;
    public TextMeshProUGUI moneyChange;

    bool GameIsFinished = false;
    FinishCollisionDetector gComplete1;
    FinishCollisionDetector gComplete2;
    FinishCollisionDetector gComplete3;
    FinishCollisionDetector gComplete4;

    Speedometer meter;

    GameObject Controls;

    public float timer = 0;
    float time = 3;

    // Start is called before the first frame update
    void Start()
    {
        data = GameObject.Find("GameData").GetComponent<Data>();
        redEffect = GameObject.Find("RedEffect").GetComponent<Animator>();

        gComplete1 = GameObject.Find("WheelFrontLeft").GetComponent<FinishCollisionDetector>();
        gComplete2 = GameObject.Find("WheelFrontRight").GetComponent<FinishCollisionDetector>();
        gComplete3 = GameObject.Find("WheelRearLeft").GetComponent<FinishCollisionDetector>();
        gComplete4 = GameObject.Find("WheelRearRight").GetComponent<FinishCollisionDetector>();
        meter = GameObject.Find("Speed Meter").GetComponent<Speedometer>();

        Controls = GameObject.Find("Controls");
    }

        // Update is called once per frame
        void Update()
        {

        timer = timer - 1 * Time.deltaTime;

        if (timer <0)
        {
            timer = 0;
        }
            if (violations == 0)
            {
                violation.SetText("Good Job, You did it without Violations");
            }
            else if (violations > 0)
            {
                violation.SetText("Violations \r\n \r\nBeating the Red light: " + btrlCount/2+ "\r\nReckless Driving: " +recklessCount+ "\r\nDisregarding Traffic Sign: " +dtsCount/2+ "\r\nOver Speeding: " + overspeedCount);
            }


        if (gComplete1.finish == true && gComplete2.finish == true && gComplete3.finish == true && gComplete4.finish == true && meter.speed < 5)
            {
                openFinishPopup();
                Controls.transform.localScale = new Vector3(0,0,0);
            }
        }

        public void recklessDriving()
        {
        if (timer == 0) {
            reckless.GetComponent<Animator>().SetTrigger("ViolText");
            redEffect.SetTrigger("RedEffect");
            data.money = data.money - recklessPenalty;

            if (data.money < 0)
            {
                data.money = 0;
            }
            timer = time;
            moneyChange.SetText("-" + recklessPenalty);
            moneyChange.GetComponent<Animator>().SetTrigger("Minus");



            recklessCount += 1;
            violations += 1;
            data.saveData();
            }
        }
    public void DisregardingTrafficSign()
    {
        if (timer == 0)
        {
            disregardingTrafficSign.GetComponent<Animator>().SetTrigger("ViolText");
            redEffect.SetTrigger("RedEffect");
            data.money = data.money - DTSPenalty;

            timer = time;
            if (data.money < 0)
            {
                data.money = 0;
            }
            moneyChange.SetText("-" + DTSPenalty);
            moneyChange.GetComponent<Animator>().SetTrigger("Minus");

            dtsCount += 1;
            violations += 1;
            data.saveData();
            }
        }

    public void BTRL()
    {
        if (timer == 0)
        {
            btrl.GetComponent<Animator>().SetTrigger("ViolText");
            redEffect.SetTrigger("RedEffect");
            data.money = data.money - btrlPenalty;
            moneyChange.SetText("-" + btrlPenalty);
            moneyChange.GetComponent<Animator>().SetTrigger("Minus");
            timer = time;
            if (data.money < 0)
            {
                data.money = 0;
            }

            btrlCount += 1;
            violations += 1;
            data.saveData();
        }
    }

    public void overSpeeding()
    {

        if (timer == 0)
        {
            overSpeed.GetComponent<Animator>().SetTrigger("ViolText");
            redEffect.SetTrigger("RedEffect");
            data.money = data.money - overSpeedingPenalty;

            timer = time;

            if (data.money < 0)
            {
                data.money = 0;
            }
            moneyChange.SetText("-" + overSpeedingPenalty);
            moneyChange.GetComponent<Animator>().SetTrigger("Minus");

            overspeedCount += 1;
            violations += 1;
            data.saveData();
           }
        }
        public void goodBoy()
        {
        if (timer == time)
        {
            timer = 3;
            good.GetComponent<Animator>().SetTrigger("ViolText");
            data.money = data.money + reward;

            moneyChange.SetText("+" + reward);
            moneyChange.GetComponent<Animator>().SetTrigger("Add");

            data.saveData();
        }
        }
    public void openFinishPopup()
    {
            GameObject.Find("FinishPopUp").GetComponent<Animator>().SetTrigger("FinishOpen");
    }
    public void closeAnimationPopup()
    {
        GameObject.Find("FinishPopUp").GetComponent<Animator>().SetTrigger("FinishClose");
    }
}
