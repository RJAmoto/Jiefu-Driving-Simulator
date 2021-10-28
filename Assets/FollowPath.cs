
using UnityEngine;
using PathCreation;

public class FollowPath : MonoBehaviour
{
    public PathCreator pathC;

    public double speed;
    public double travelled;
    public float assignedSpeed;
    public float HorsePower;


    void Update()
    {
        transform.position = pathC.path.GetPointAtDistance((float)travelled);
        transform.rotation = pathC.path.GetRotationAtDistance((float)travelled);
            go();
    }
    public void stop()
    {
            speed = 0;
    }
    public void go()
    {
        speed += HorsePower;

        travelled += speed * Time.deltaTime;

        if (speed > assignedSpeed)
        {
            speed = assignedSpeed;
        }
    }
}
