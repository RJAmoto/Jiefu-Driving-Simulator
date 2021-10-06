
using UnityEngine;
using PathCreation;

public class FollowPath : MonoBehaviour
{
    public PathCreator pathC;

    public float speed;
    public float travelled;
    public float assignedSpeed;
    public float HorsePower;

    bool somethingInfront = false;

    public float time;

    void Update()
    {

        transform.position = pathC.path.GetPointAtDistance(travelled);
        transform.rotation = pathC.path.GetRotationAtDistance(travelled);

        if (time <= 0)
        {
            time = 0;
            travelled += speed * Time.deltaTime;
        }

        if (time == 0)
        {
            speed += HorsePower;
        }

        if (speed>assignedSpeed)
        {
            speed = assignedSpeed;
        }
    }
}
