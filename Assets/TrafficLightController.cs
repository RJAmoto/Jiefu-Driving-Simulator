using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLightController : MonoBehaviour
{
    float time = 5;
    public Light[] lights;
    int index = 0;
    // Update is called once per frame
    PlayerActions action;

    private void Start()    
    {

    }

    void Update()
    {

        time -= 1 * Time.deltaTime;

        if (time <= 0)
        {
            index += 1;
            time = 5;

            if (index>=lights.Length)
            {
                index = 0;
            }
        }


        if (index == 0)
        {
            //red
            lights[0].enabled = true;
            lights[1].enabled = false;
            lights[2].enabled = false;
            lights[3].enabled = false;
        }
        else if (index == 1)
        {
            //red + yelllow
            lights[0].enabled = true;
            lights[1].enabled = true;
            lights[2].enabled = false;
            lights[3].enabled = true;
        }
        else if (index == 2)
        {
            //green
            lights[0].enabled = false;
            lights[1].enabled = false;
            lights[2].enabled = true;
            lights[3].enabled = false;
        }
        else if (index == 3)
        {
            //yellow
            lights[0].enabled = false;
            lights[1].enabled = true;
            lights[2].enabled = false;
            lights[3].enabled = true;
        }
        else
        {
            lights[0].enabled = true;
            lights[1].enabled = true;
            lights[2].enabled = true;
            lights[3].enabled = true;
        }
    }
}
