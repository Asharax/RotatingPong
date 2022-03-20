using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private Rigidbody2D ballRb;
    private float ballSpeed = 2f;
    void Start()
    {
        ballRb = GameObject.FindGameObjectsWithTag("Ball")[0].GetComponent<Rigidbody2D>();
        ballRb.AddForce(transform.right * -1 * ballSpeed );

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
