using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputSystem : MonoBehaviour {

    public float accel = 0;
    public float steer = 0;
    public float brake = 0;

    public Sprite reverse;
    public Sprite Forward;
    public Sprite seatBeltOn;
    public Sprite seatBeltOff;

    public Toggle toggle;
    public Toggle SeatBelt;

    public bool SeatBeltIsOn = false;



    public bool rev = false;

    public CarControl carControl;
    carlights carLight;

    public GameObject UI;
    void Start()
    {
        carLight = GameObject.Find("CivilianVehicle05").GetComponent<carlights>();
    }
    public void AccelInput(float input)
    {
        if (rev)
        {
            accel = input * -1;

        }
        else
        {
            accel = input;
        }
    }
    public void SteerInput(float input)
    {
        steer = input;
    }
    public void BrakeInput(float input)
    {
        brake = input;
    }

    public void SetReverse(bool rev)
    {
        bool reversed = rev;
        if (reversed)
        {
            toggle.image.sprite = reverse;
        }
        else
        {
            toggle.image.sprite = Forward;
        }
        this.rev = rev;
    }

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        carControl.Move(accel, steer, brake);
        carLight.setBrake(brake);
    }

    public void SeatBeltSwitch(bool input)
    {
        SeatBeltIsOn = input;

        if (SeatBeltIsOn)
        {
            SeatBelt.image.sprite = seatBeltOn;
        }
        else
        {
            SeatBelt.image.sprite = seatBeltOff;
        }
    }
    public bool IsSeatbeltOn()
    {
        return SeatBeltIsOn;
    }
}
