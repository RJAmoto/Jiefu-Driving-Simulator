using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AICarCollider : MonoBehaviour
{


    public VehicleMover mover;


    float SensorLength = 10f;
    float sensorDistance = 1f;

    public float sensorTimer = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    void FixedUpdate()
    {
        sensorTimer -= 1 * Time.deltaTime;

        if (sensorTimer<=0)
        {
            sensorTimer = 0;
        }

        sensor();
    }

    public void sensor()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit, SensorLength))
        {
            if (hit.transform.CompareTag("Player")|| hit.transform.CompareTag("AI"))
            {
                if (sensorTimer==0) {
                    mover.carStop();
                    mover.TimeSet(2);
                    sensorTimer = 3;
                }
            }
        }
        Debug.DrawRay(transform.position, transform.forward * SensorLength, Color.red);

    }
}
