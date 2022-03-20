using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    // Start is called before the first frame update
    
    private Rigidbody2D ballRb;
    private float ballSpeed = 0.5f;
    void Start()
    {
        ballRb = GetComponent<Rigidbody2D>();
        ballRb.AddForce(transform.right * -1 * ballSpeed );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D other) {
        // Check if the collider is one of the paddles, player | enemy
        if(other!=null){
            ballRb.AddForce(transform.right * ballSpeed );
        }
    }
}
