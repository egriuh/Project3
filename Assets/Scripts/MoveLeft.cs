using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    // Variables

    private float speed = 30;
    private PlayerMovement playerMovementScript;
    private float leftBound = -10;

    // Start is called before the first frame update
    void Start()
    {
        playerMovementScript = GameObject.Find("Ken").GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {

        if(playerMovementScript.gameOver == false)
        {
           transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        if(transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
