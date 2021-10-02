using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SeatBeltSignCollisionDetector : MonoBehaviour
{
    // Start is called before the first frame update

    Animator SeatBelt;
    Animator RedEffect;
    InputSystem inputSystem;
    public TextMeshProUGUI tmp;
    Data data;

    void Start()
    {
        SeatBelt = tmp.GetComponent<Animator>();
        RedEffect = GameObject.Find("RedEffect").GetComponent<Animator>();
        data = GameObject.Find("FileHandler").GetComponent<Data>();
        inputSystem = GameObject.Find("CivilianVehicle05").GetComponent<InputSystem>();
    }
    public void OnTriggerEnter(Collider other)
    {
        if (inputSystem.SeatBeltIsOn)
        {
            Debug.Log("Seatbelt is on");
        }
        else
        {
            SeatBelt.SetTrigger("Wreckless");
            RedEffect.SetTrigger("Bumped");
            data.money = data.money - 20;
        }
    }
}
