using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AICarCollider : MonoBehaviour
{
    public FollowPath path;
    public GameObject parent;

    bool stop = false;
    // Start is called before the first frame update
    void Start()
    {

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

        if (stop)
        {
            path.time = 3;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" || other.tag == "AI")
        {
            stop = true;
            path.stop();
        }
    }
    void OnTriggerExit(Collider other)
    {
            stop = false;
    }
}
