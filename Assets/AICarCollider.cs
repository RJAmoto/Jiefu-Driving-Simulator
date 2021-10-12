using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AICarCollider : MonoBehaviour
{
    public FollowPath path;
    public GameObject parent;
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
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "AI")
        {
            path.time = 3;
            path.stop();
        }
        else if (other.tag == "Player")
        {
            path.time = 3;
            path.stop();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            //path.go();
        }
        else if (other.tag == "AI")
        {
            //path.go();
        }
    }
}
