using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AICarCollider : MonoBehaviour
{
    FollowPath path;
    public GameObject parent;
    // Start is called before the first frame update
    void Start()
    {
        path = GameObject.FindGameObjectWithTag("AI").GetComponent<FollowPath>();
    }

     void Update()
    {
        transform.rotation = parent.transform.rotation;
        transform.position = parent.transform.position;
        path.time = path.time - 1 * Time.deltaTime;

        if (path.time <= 0)
        {
            path.time = 0;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "AI")
        {
            path.speed = 0;
            path.HorsePower = 0;
        }
        else if (other.tag == "Player")
        {
            path.speed = 0;
            path.HorsePower = 0;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            path.time = 3;
            path.speed += 14;
        }
        else if (other.tag == "Player")
        {
            path.time = 3;
            path.speed += 14;
        }
    }
}
