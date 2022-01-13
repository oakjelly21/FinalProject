using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject obstaclePrefab;
    private Vector3 spawnPos;
    private float startDelay = 2;
    private float repeatRate = 2;
    private GameObject player;
    //Random r = new Random();
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        player = GameObject.Find("Nolan");
    }
    void SpawnObstacle()
    {
        Vector3 pos = player.transform.position;
        spawnPos = new Vector3(spawnposgen(pos.x),pos.y,spawnposgen(pos.z));
        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
    }
    float spawnposgen(float v)
    {
      v+=Random.Range(10.0f,25.0f);
      if(Random.Range(0.0f,1.0f)>0.5)
        return v;
      else
        return v*-1;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
