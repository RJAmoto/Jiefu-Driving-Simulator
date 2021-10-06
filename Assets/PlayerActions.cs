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

    public TextMeshProUGUI reckless;
    public TextMeshProUGUI disregardingTrafficSign;
    public TextMeshProUGUI btrl;
    public TextMeshProUGUI good;
    public TextMeshProUGUI overSpeed;

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
        data = GameObject.Find("FileHandler").GetComponent<Data>();
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
    public void openFinishPopup()
    {
            GameObject.Find("FinishPopUp").GetComponent<Animator>().SetTrigger("FinishOpen");
    }
    public void closeAnimationPopup()
    {
        GameObject.Find("FinishPopUp").GetComponent<Animator>().SetTrigger("FinishClose");
    }
}
