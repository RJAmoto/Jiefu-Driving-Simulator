using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishCollisionDetector : MonoBehaviour
{
    // Start is called before the first frame update

    public bool finish = false;
    public bool stopped = false;


    public void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Finish Point")
        {
            finish = true;
        }
        else if (col.tag == "Stopping Point")
        {
            stopped = true;
            col.gameObject.GetComponent<StoppingPoint>().used();
        }
    }
    public void OnTriggerExit(Collider col)
    {
        if (col.tag == "Finish Point")
        {
            finish = false;
        }
        else if (col.tag == "Stopping Point")
        {
            stopped = false;
        }
    }
}
