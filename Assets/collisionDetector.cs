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

    public void Start()
    {
        data = GameObject.Find("GameData").GetComponent<Data>();
        action = GameObject.Find("Watcher").GetComponent<PlayerActions>();

        bump1 = GetComponent<AudioSource>();
    }
    public void OnCollisionEnter(Collision col)
    {

        if (col.collider.name == "SeatBeltSign")
        {
            bump1.Play();
        }
        else
        {
            bump1.Play();
            action.recklessDriving();
        }
        data.saveData();
    }
}
