using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Variables

    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private float startDelay = 2;
    private float repeatRate = 2;
    private PlayerMovement playerMovementScript;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        playerMovementScript = GameObject.Find("Ken").GetComponent<PlayerMovement>();
    }
    void SpawnObstacle ()
    {
        if(playerMovementScript.gameOver == false)
        {
           Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }
       
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
