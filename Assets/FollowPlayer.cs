
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //public Transform player;
    //public Vector3 offset;

    public GameObject Player;
    public GameObject Child;
    public float speed;
   

    // Update is called once per frame
    /*void Update()
    {
        transform.position = player.position + offset;
    }*/

    private void awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        Child = Player.transform.Find("camera constraint").gameObject;
    }

    private void FixedUpdate()
    {
        follow();
    }
    private void follow()
    {
        gameObject.transform.position = Vector3.Lerp(transform.position, Child.transform.position, Time.deltaTime*speed) ;
        gameObject.transform.LookAt(Player.gameObject.transform.position);

    }


}
