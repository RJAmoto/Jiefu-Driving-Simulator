using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class VehicleMover : MonoBehaviour
{

    public NavMeshAgent vAgent;
    public GameObject guide;
    public float timer = 0.0f;

    bool inPos = false;

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = guide.transform.position;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
            if (!inPos)
            {
                transform.position = guide.transform.position;
                inPos = true;
            }

        //timer
        timer = timer - 1 * Time.deltaTime;

        if (timer < 0)
        {
            timer = 0;
        }

        //Sets the destination to where the ai would go;
        if (timer == 0)
        {
            vAgent.enabled = true;
            rb.isKinematic = true;
            carMove();
        }
        else
        {
            carStop();
        }
    }

    public void carMove()
    {
        guide.GetComponent<FollowPath>().go();
        vAgent.SetDestination(guide.transform.position);
        vAgent.isStopped = false;
    }

    public void carStop()
    {
        guide.GetComponent<FollowPath>().stop();
        vAgent.isStopped = true;

        //    vAgent.SetDestination(guide.transform.position);
    }

    public void TimeSet(float time)
    {
        timer = time;
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Player")) {
            timer = 8;
            rb.isKinematic = false;
            vAgent.enabled = false;
        }
    }
}