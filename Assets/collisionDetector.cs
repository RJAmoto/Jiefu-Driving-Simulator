using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class collisionDetector : MonoBehaviour
{

    AudioSource bump1;
    Data data;
    Animator anim;
    Animator wreck;
    public TextMeshProUGUI myTMP;

    public void Start()
    {
        data = GameObject.Find("FileHandler").GetComponent<Data>();
        anim = GameObject.Find("RedEffect").GetComponent<Animator>();
        wreck = myTMP.GetComponent<Animator>();

        bump1 = GetComponent<AudioSource>();
    }
    public void OnCollisionEnter(Collision col)
    {

        if (col.collider.name == "SeatBeltSign")
        {

        }
        else
        {
            bump1.Play();
            anim.SetTrigger("Bumped");
            wreck.SetTrigger("Wreckless");
            Debug.Log("We hit something");
            data.money = data.money - 20;
        }
        data.saveData();
    }
}
