
using UnityEngine;
using PathCreation;

public class FollowPath : MonoBehaviour
{
    public PathCreator pathC;

    public double speed;
    public double travelled;
    public float assignedSpeed;
    public float HorsePower;

    bool somethingInfront = false;

    public float time = 0;

    void Update()
    {

        transform.position = pathC.path.GetPointAtDistance((float)travelled);
        transform.rotation = pathC.path.GetRotationAtDistance((float)travelled);

        if (time <= 0)
        {
            time = 0;
            go();
        }
    }
    public void stop()
    {
        if (speed <= 1)
        {
            speed = 0;
        }
        else
        {
            speed -= 1;
            travelled += speed * Time.deltaTime ;
        }
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
