using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Opsive.UltimateCharacterController.Traits;

public class EnemyAI : MonoBehaviour
{
    // Start is called before the first frame update
    NavMeshAgent nm;
    GameObject player;

    //public GameObject target;
    void Start()
    {
        player = GameObject.Find("Nolan");
        nm = GetComponent<NavMeshAgent>();


    }

    // Update is called once per frame
    void Update()
    {
        nm.SetDestination(GameObject.Find("wayPoint").transform.position);
    }
    void OnTriggerEnter(Collider Col)
    {
        if (Col.gameObject.tag == "Player")
        {
            var health = player.GetComponent<Health>();
            health.Damage(10);
        }
    }
}