using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class HumanHit : MonoBehaviour
{
    public BoxCollider trigger;

    public GameObject rig;
    public Animator animator;
    public FollowNode follow;

    public NavMeshAgent agent;


    float time = 3;
    // Start is called before the first frame update
    void Start()
    {
        getRagdollParts();
        ragdollOff();
    }

    private void Update()
    {
        time = time - 1 * Time.deltaTime;

        if (time<0)
        {
            time = 0;
        }
        if (time == 0)
        {
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player"|| collision.gameObject.tag == "AI") {
            ragdollOn();
        }
    }

    Collider[] ragdollParts;
    Rigidbody[] partsPhysics;
    void getRagdollParts()
    {
        ragdollParts = rig.GetComponentsInChildren<Collider>();
        partsPhysics = rig.GetComponentsInChildren<Rigidbody>();
    }

    void ragdollOn()
    {
        animator.enabled = false;
        follow.enabled = false;
        agent.enabled = false;

        foreach (Collider col in ragdollParts)
        {
            col.enabled = true;
        }
        foreach (Rigidbody col in partsPhysics)
        {
            col.isKinematic = false;
        }

        trigger.enabled = false;
        GetComponent<Rigidbody>().isKinematic = true;
    }
    void ragdollOff()
    {
        foreach (Collider col in ragdollParts)
        {
            col.enabled = false;
        }
        foreach (Rigidbody col in partsPhysics)
        {
            col.isKinematic = true;
        }

        animator.enabled = true;
        trigger.enabled = true;
        GetComponent<Rigidbody>().isKinematic = false;
    }
}
