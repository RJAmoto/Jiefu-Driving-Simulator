using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AICarCollider : MonoBehaviour
{


    public VehicleMover mover;


    float SensorLength = 10f;
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
            if (hit.transform.CompareTag("Player")|| hit.transform.CompareTag("AI"))
            {
                mover.carStop();
                mover.TimeSet(2);
            }
        }
        Debug.DrawRay(transform.position, transform.forward * SensorLength, Color.red);

    }
}
