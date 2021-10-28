using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PedestrianWalk : MonoBehaviour
{
    public GameObject[] pedestrians;
    public GameObject firstWayPoint;
    // Start is called before the first frame update
    void Start()
    {
        for (int a = 0; a < pedestrians.Length; a++) {
            pedestrians[a].GetComponent<FollowNode>().Node = null;
        }

    }

    public void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player") {
            for (int a = 0; a < pedestrians.Length; a++)
            {
                pedestrians[a].GetComponent<FollowNode>().Node = firstWayPoint;
            }
        }
    }


    [System.Serializable]
    struct Pedestrian{
        public GameObject pedestrian;
    }
}
