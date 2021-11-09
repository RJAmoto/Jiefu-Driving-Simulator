using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CivillianSensor : MonoBehaviour
{
    public NavMeshAgent agent;
    
    float SensorLength = 5f;
    float sensorDistance = 1f;


    // Start is called before the first frame update
    void Start()
    {

    }

    void FixedUpdate()
    {

        sensor();
    }

    public void sensor()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit, SensorLength))
        {
            if (hit.transform.CompareTag("Player") || hit.transform.CompareTag("AI"))
            {

                agent.speed = 0;
                agent.acceleration = 0;

            }
            else
            {
                agent.speed = 2;
                agent.acceleration = 8;
            }
        }
        Debug.DrawRay(transform.position, transform.forward * SensorLength, Color.red);

    }
}
