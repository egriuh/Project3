using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerTrees : MonoBehaviour
{
    // Variables

    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(34, 3, -4);
    private float startDelay = 2;
    private float repeatRate = 2;
    private PlayerMovement playerMovementScript;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        playerMovementScript = GameObject.Find("Player").GetComponent<PlayerMovement>();
    }
    void SpawnObstacle()
    {
        if (playerMovementScript.gameOver == false)
        {
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }
        
    }
}
