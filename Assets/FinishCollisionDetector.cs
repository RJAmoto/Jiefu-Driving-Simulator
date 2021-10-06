using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishCollisionDetector : MonoBehaviour
{
    // Start is called before the first frame update

    public bool finish = false;


    public void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Finish Point")
        {
            finish = true;
        }
    }
    public void OnTriggerExit(Collider col)
    {
        if (col.tag == "Finish Point")
        {
            finish = false;
        }
    }
}
