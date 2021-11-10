using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HornChecker : MonoBehaviour
{

    PlayerActions actions;
    // Start is called before the first frame update
    void Start()
    {
        actions = GameObject.Find("Watcher").GetComponent<PlayerActions>();
    }

    // Update is called once per frame
    void Update()
    {
        if ()
        {
            actions.disregardingTrafficSign();
        }
    }
}
