using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounterFlow : MonoBehaviour
{
    bool counterFlow = false;
    bool leftWing = false;
    bool rightWing = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rightWing)
        {
            counterFlow = false;
        }
        else if (leftWing)
        {
            counterFlow = true;
        }
        else if (rightWing&&leftWing)
        {
            counterFlow = false;
        }
        else if (!rightWing&&!leftWing)
        {
            counterFlow = false;
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (this.tag == "RightWing" && other.tag == "RoadSide")
        {
            rightWing = true;
        }
        else if (this.tag == "LeftWing" && other.tag == "RoadSide")
        {
            leftWing = true;
        }
        else
        {
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (this.tag == "RightWing" && other.tag == "RoadSide")
        {
            rightWing = false;
        }
        else if (this.tag == "LeftWing" && other.tag == "RoadSide")
        {
            leftWing = false;
        }
        else
        {
        }
    }
}
