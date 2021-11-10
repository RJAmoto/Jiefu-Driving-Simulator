using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HornChecker : MonoBehaviour
{
    public CarControl control;
    PlayerActions actions;
    // Start is called before the first frame update
    void Start()
    {

        actions = GameObject.Find("Watcher").GetComponent<PlayerActions>();
    }

    // Update is called once per frame
    public void OnTriggerStay(Collider other)
    {
        if (control.hornOpen)
        {
            actions.DisregardingTrafficSign();
        }
    }
}
