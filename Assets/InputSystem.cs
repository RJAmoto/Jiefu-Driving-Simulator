using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputSystem : MonoBehaviour{

    public float accel;
    public float steer;
    public float brake;

    public Sprite reverse;
    public Sprite Forward;
    public Toggle toggle;



    public bool rev = false;

    CarControl carControl;
    carlights carLight;

    public GameObject UI;

    public void AccelInput(float input)
    {
        if (rev)
        {
            accel = input*-1;
            toggle.image.sprite = reverse;

        }
        else
        {
            accel = input;
            toggle.image.sprite = Forward;
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
        this.rev = rev;
    }

    // Start is called before the first frame update
    void Start()
    {
        carControl = GameObject.Find("Body").GetComponent<CarControl>();
        carLight = GameObject.Find("CivilianVehicle05").GetComponent<carlights>();
    }

    // Update is called once per frame
    void Update()
    {
        UI.SetActive(true);
    }

    void FixedUpdate()
    {
        carControl.Move(accel,steer,brake);
        carLight.setBrake(brake);
    }
}