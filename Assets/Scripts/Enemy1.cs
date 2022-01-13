using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour
{
  //You may consider adding a rigid body to the zombie for accurate physics simulation
private GameObject wayPoint;

private Vector3 wayPointPos;

//This will be the zombie's speed. Adjust as necessary.
public float speed = 2.0f;

void Start ()
{
   //At the start of the game, the zombies will find the gameobject called wayPoint.
   wayPoint = GameObject.Find("wayPoint");
}

void Update ()
{
   wayPointPos = new Vector3(wayPoint.transform.position.x, transform.position.y, wayPoint.transform.position.z);
   //Here, the zombie's will follow the waypoint.
   Vector3 v = Vector3.MoveTowards(transform.position, wayPointPos, speed * Time.deltaTime);
   transform.position = v;
   wayPoint.transform.rotation = Quaternion.Slerp (wayPoint.transform.rotation, Quaternion.LookRotation (v), Time.deltaTime * 40f);
}

}
