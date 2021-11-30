using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlowB : MonoBehaviour
{
    public Animator closeRem;
    public PauseMenu pause;

    public Toggle battery;
    public Toggle lights;
    public Toggle oil;
    public Toggle water;
    public Toggle brake;
    public Toggle air;
    public Toggle gas;
    public Toggle engine;
    public Toggle tire;
    public Toggle self;

    public GameObject effects;

    float pauseTimer = 5;

    // Start is called before the first frame update
    void Start()
    {
        pause.SetPause();

        effects.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setOk()
    {
        if (battery.isOn && lights.isOn && oil.isOn && water.isOn && brake.isOn && air.isOn && gas.isOn && engine.isOn && tire.isOn && self.isOn)
        {
            closeRem.SetTrigger("Close");
            effects.SetActive(true);
            pause.SetResume();
        }
        else
        {
            return;
        }
    }
}
