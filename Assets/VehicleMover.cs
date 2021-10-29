using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class VehicleMover : MonoBehaviour
{

    public NavMeshAgent vAgent;
    public GameObject guide;
    public float timer = 0.0f;
    public GameObject look;


    public bool stopped = false;
    public float stopTimer = 18;
    public float random;




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
        //    gameObject.transform.LookAt(look.transform.position);
        //timer
        timer = timer - 1 * Time.deltaTime;

        if (timer < 0)
        {
            timer = 0;
        }

        //Sets the destination to where the ai would go;
        if (timer == 0 || stopped == false)
        {
            vAgent.enabled = true;
            rb.isKinematic = true;
            carMove();
        }
        else
        {
            carStop();
        }

        if (stopped)
        {
            stopTimer -= 1 * Time.deltaTime;

            if(stopTimer <= 0)
            {
                stopTimer = 0;
            }

            if (stopTimer == 0)
            {
                random = Random.Range(0, 100);

                if (random>=0 || random <= 50)
                {
                    stopped = false;
                    stopTimer = 18;
                }
                else
                {
                    stopTimer = 5;
                }

            }
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

        stopped = true;
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