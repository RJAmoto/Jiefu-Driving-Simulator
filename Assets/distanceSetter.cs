using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class distanceSetter : MonoBehaviour
{

    public GameObject[] guide;

    public double distance;
    public double finalDistance;
   
    // Start is called before the first frame update
    void Start()
    {
        for (int a = 0; a < guide.Length; a++)
        {
            finalDistance += distance;
            guide[a].GetComponentInChildren<FollowPath>().travelled = finalDistance;

            Debug.Log(finalDistance);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
