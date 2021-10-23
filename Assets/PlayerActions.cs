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
            
            reckless.GetComponent<Animator>().SetTrigger("ViolText");
            redEffect.SetTrigger("RedEffect");
            data.money = data.money - recklessPenalty;

            moneyChange.SetText("-" +recklessPenalty);
            moneyChange.GetComponent<Animator>().SetTrigger("Minus");
            

            
            recklessCount += 1;
            violations += 1;
            data.saveData();
        }
        public void DisregardingTrafficSign()
        {
            disregardingTrafficSign.GetComponent<Animator>().SetTrigger("ViolText");
            redEffect.SetTrigger("RedEffect");
            data.money = data.money - DTSPenalty;

            moneyChange.SetText("-" + DTSPenalty);
            moneyChange.GetComponent<Animator>().SetTrigger("Minus");

        dtsCount += 1;
            violations += 1;
        data.saveData();
        }

        public void BTRL()
        {
            btrl.GetComponent<Animator>().SetTrigger("ViolText");
            redEffect.SetTrigger("RedEffect");
            data.money = data.money - btrlPenalty;
            moneyChange.SetText("-" + btrlPenalty);
            moneyChange.GetComponent<Animator>().SetTrigger("Minus");

        btrlCount += 1;
            violations += 1;
        data.saveData();
        }

        public void overSpeeding()
        {
            overSpeed.GetComponent<Animator>().SetTrigger("ViolText");
            redEffect.SetTrigger("RedEffect");
            data.money = data.money - overSpeedingPenalty;

            moneyChange.SetText("-" + overSpeedingPenalty);
            moneyChange.GetComponent<Animator>().SetTrigger("Minus");

        overspeedCount += 1;
            violations += 1;
            data.saveData();
        }

        public void goodBoy()
        {
            good.GetComponent<Animator>().SetTrigger("ViolText");
            data.money = data.money + reward;

            moneyChange.SetText("+" + reward);
            moneyChange.GetComponent<Animator>().SetTrigger("Add");

        data.saveData();
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
