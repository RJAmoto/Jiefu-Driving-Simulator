using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class collisionDetector : MonoBehaviour
{
    AudioSource bump1;
    Data data;
    PlayerActions action;
    public TextMeshProUGUI myTMP;

    float timer = 0;
    float time = 0.7f;

    public void Start()
    {
        data = GameObject.Find("GameData").GetComponent<Data>();
        action = GameObject.Find("Watcher").GetComponent<PlayerActions>();

        bump1 = GetComponent<AudioSource>();
    }

    public void Update()
    {
        timer = timer - 1 * Time.deltaTime;

        if (timer < 0)
        {
            timer = 0;
        }
    }


    public void OnCollisionEnter(Collision col)
    {
        if (timer == 0) {
            if (col.gameObject.name == "SeatBeltSign")
            {
                bump1.Play();
                timer = time;
            }
            else if (col.gameObject.tag == "Pedestrian")
            {
                timer = time;
            }
            else
            {
                bump1.Play();
                action.recklessDriving();
                timer = time;
            }
            data.saveData();
        }
    }
}
