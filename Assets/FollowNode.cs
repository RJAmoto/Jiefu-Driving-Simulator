using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowNode : MonoBehaviour { 

    public NavMeshAgent agent;
    public GameObject Node;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        Node = other.gameObject.GetComponent<Waypoint>().next;
        Debug.Log("Waypoint Reached");
    }

    // Update is called once per frame
    void Update()
    {
        // gameObject.transform.position = Vector3.Lerp(transform.position, Node.transform.position, speed * Time.deltaTime);
        // gameObject.transform.LookAt(Node.gameObject.transform.position);
        if (this.enabled)
        {
            agent.SetDestination(Node.transform.position);
        }
    }
}