using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backCollider : MonoBehaviour
{
    public bool somethingOnBack;
    // Start is called before the first frame update
    void Start()
    {
        somethingOnBack = false;
    }

    public void OnTriggerEnter(Collider other)
    {
        somethingOnBack = true;
    }
    public void OnTriggerExit(Collider other)
    {
        somethingOnBack = false;
    }
}
