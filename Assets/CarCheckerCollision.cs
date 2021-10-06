using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CarCheckerCollision : MonoBehaviour
{
    // Start is called before the first frame update

    InputSystem inputSystem;
    PlayerActions action;
    public TrafficLightController trafficLight;
    Speedometer playerSpeed;

    public float requiredSpeed;

    void Start()
    {
        inputSystem = GameObject.Find("CivilianVehicle05").GetComponent<InputSystem>();
        action = GameObject.Find("Watcher").GetComponent<PlayerActions>();
        playerSpeed = GameObject.Find("Speed Meter").GetComponent<Speedometer>();
    }
    public void OnTriggerEnter(Collider other)
    {
        if (this.name == "SeatBeltSign"&&other.tag == "Player")
        {
            if (inputSystem.SeatBeltIsOn)
            {
                action.goodBoy();
            }
            else
            {
                action.DisregardingTrafficSign();
            }
        }
        else if (this.tag == "Traffic Light"&& other.tag == "Player")
        {
            if (trafficLight.lights[0].enabled == true)
            {
                action.BTRL();
            }
            else
            {
                action.goodBoy();
            }
        }
        else if (this.tag == "Speed Limit Sign"&& other.tag == "Player")
        {
            if (playerSpeed.speed > requiredSpeed)
            {
                action.overSpeeding();
            }
            else
            {
                action.goodBoy();
            }
        }

    }
}
